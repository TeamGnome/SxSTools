using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExpandManifests
{
   internal static class PatchAPI
   {
      [DllImport("msdelta.dll", SetLastError = true, CharSet = CharSet.Unicode)]
      public static extern bool ApplyDeltaB(DELTA_FLAG_TYPE ApplyFlags, DELTA_INPUT Source, DELTA_INPUT Delta, out DELTA_OUTPUT lpTarget);

      [DllImport("msdelta.dll", SetLastError = true, CharSet = CharSet.Unicode)]
      public static extern bool ApplyDeltaW(DELTA_FLAG_TYPE ApplyFlags, string lpSourceName, string lpDeltaName, string lpTargetName);

      [DllImport("msdelta.dll", SetLastError = true, CharSet = CharSet.Unicode)]
      public static extern bool GetDeltaInfoW(string lpDeltaName, out DELTA_HEADER_INFO lpHeaderInfo);
   }

   internal static class ResourceAPI
   {
      [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
      public static extern IntPtr LoadLibrary(string lpFileName);

      [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
      public static extern IntPtr FindResourceEx(IntPtr hModule, string lpType, string lpName, ushort wLanguage);

      [DllImport("kernel32.dll", SetLastError = true)]
      public static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

      [DllImport("kernel32.dll", SetLastError = true)]
      public static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);

      [DllImport("kernel32.dll", SetLastError = true)]
      public static extern IntPtr LockResource(IntPtr hResData);

      [DllImport("user32.dll", CharSet = CharSet.Unicode)]
      public static extern int LoadString(IntPtr hInstance, uint uID, StringBuilder lpBuffer, int nBufferMax);

      [DllImport("kernel32.dll", SetLastError = true)]
      public static extern bool FreeLibrary(IntPtr hModule);
   }

   [Flags]
   internal enum DELTA_FLAG_TYPE : ulong
   {
      DELTA_FLAG_NONE = 0x0,
      DELTA_APPLY_FLAG_ALLOW_PA19 = 0x1
      //DELTA_FLAG_E8 = 0x1,
      //DELTA_FLAG_MARK = 0x2
   }

   [Flags]
   internal enum DELTA_FILE_TYPE : ulong
   {
      DELTA_FILE_TYPE_RAW = 0x1,
      DELTA_FILE_TYPE_I386 = 0x2,
      DELTA_FILE_TYPE_IA64 = 0x4,
      DELTA_FILE_TYPE_AMD64 = 0x8,
      DELTA_FILE_TYPE_CLI4_I386 = 0x10,
      DELTA_FILE_TYPE_CLI4_AMD64 = 0x20,
      DELTA_FILE_TYPE_CLI4_ARM = 0x40,
      DELTA_FILE_TYPE_CLI4_ARM64 = 0x80
   }

   internal struct DELTA_INPUT
   {
      public IntPtr lpStart { get; set; }
      public uint uSize { get; set; }
      public bool Editable { get; set; }
   }

   internal struct DELTA_OUTPUT
   {
      public IntPtr lpStart { get; set; }
      public uint uSize { get; set; }
   }

   internal struct DELTA_HEADER_INFO
   {
      DELTA_FILE_TYPE FileTypeSet;
      DELTA_FILE_TYPE FileType;
      DELTA_FLAG_TYPE Flags;
      uint TargetSize;
      FILETIME TargetFileTime;
      uint TargetHashAlgId;
      DELTA_HASH TargetHash;
   }

   internal struct FILETIME
   {
      uint dwLowDateTime;
      uint dwHighDateTime;
   }

   internal unsafe struct DELTA_HASH
   {
      uint HashSize;
      fixed byte HashValue[32];
   }
}
