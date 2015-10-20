using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;

namespace LibSxS.Delta
{
   public static class DeltaAPI
   {
      [DllImport("msdelta.dll", SetLastError = true, CharSet = CharSet.Unicode)]
      public static extern bool ApplyDeltaB(
         DeltaInputFlags ApplyFlags,
         DeltaInput Source,
         DeltaInput Delta,
         out DeltaOutput lpTarget);

      [DllImport("msdelta.dll", SetLastError = true, CharSet = CharSet.Unicode)]
      public static extern bool ApplyDeltaW(
         DeltaInputFlags ApplyFlags,
         string lpSourceName,
         string lpDeltaName,
         string lpTargetName);

      [DllImport("msdelta.dll", SetLastError = true, CharSet = CharSet.Unicode)]
      public static extern bool GetDeltaInfoB(
         DeltaInput Delta,
         out DeltaHeaderInfo lpHeaderInfo);

      [DllImport("msdelta.dll", SetLastError = true, CharSet = CharSet.Unicode)]
      public static extern bool GetDeltaInfoW(
         string lpDeltaName,
         out DeltaHeaderInfo lpHeaderInfo);


      public static unsafe DeltaHeaderInfo GetDeltaInformation(string path)
      {
         byte[] delta;
         DeltaHeaderInfo info;

         using (FileStream fStr = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
         using (MemoryStream mStr = new MemoryStream((int)fStr.Length))
         {
            fStr.Position = 4;
            fStr.CopyTo(mStr);
            delta = mStr.ToArray();
         }

         fixed (byte* deltaPtr = delta)
         {
            DeltaInput deltaData = new DeltaInput()
            {
               lpStart = new IntPtr(deltaPtr),
               uSize = (uint)delta.Length,
               Editable = false
            };

            bool success = GetDeltaInfoB(deltaData, out info);
            if (!success)
            {
               throw new Win32Exception(Marshal.GetLastWin32Error());
            }
         }

         return info;
      }

      public static unsafe XDocument GetManifest(string path)
      {
         byte[] source, delta, output;
         DeltaOutput outData;
         bool success = false;

         using (FileStream fStr = new FileStream("manifest.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
         using (MemoryStream mStr = new MemoryStream((int)fStr.Length))
         {
            fStr.CopyTo(mStr);
            source = mStr.ToArray();
         }

         using (FileStream fStr = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
         using (MemoryStream mStr = new MemoryStream((int)fStr.Length))
         {
            fStr.Position = 4;
            fStr.CopyTo(mStr);
            delta = mStr.ToArray();
         }

         fixed (byte* sourcePtr = source)
         fixed (byte* deltaPtr = delta)
         {
            DeltaInput sourceData = new DeltaInput()
            {
               lpStart = new IntPtr(sourcePtr),
               uSize = (uint)source.Length,
               Editable = false
            };

            DeltaInput deltaData = new DeltaInput()
            {
               lpStart = new IntPtr(deltaPtr),
               uSize = (uint)delta.Length,
               Editable = false
            };

            success = ApplyDeltaB(DeltaInputFlags.DELTA_FLAG_NONE, sourceData, deltaData, out outData);

            output = new byte[outData.uSize];
            for (int i = 0; i < outData.uSize; i++)
            {
               output[i] = (byte)Marshal.PtrToStructure(outData.lpStart + i, typeof(byte));
            }
         }

         using (MemoryStream mStr = new MemoryStream(output))
         {
            return XDocument.Load(mStr);
         }
      }
   }
}
