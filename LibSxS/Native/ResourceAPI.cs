using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace LibSxS.Native
{
   public static class ResourceAPI
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
}
