using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExpandManifests
{
   public partial class mainFrm : Form
   {
      public mainFrm()
      {
         InitializeComponent();
      }

      private void btnLoad_Click(object sender, EventArgs e)
      {
         if (string.IsNullOrEmpty(txtManifest.Text))
         {
            MessageBox.Show("You have not selected a manifest file.", "Error opening manifest file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }
         FileInfo fi = new FileInfo(txtManifest.Text);
         if (!fi.Exists)
         {
            MessageBox.Show("The manifest file does not exist.", "Error opening manifest file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         string newName = fi.FullName.Replace(".manifest", ".new.manifest");

         txtOutput.Text = GetManifest(txtManifest.Text).ToString();

         //bool success = PatchAPI.ApplyDeltaW(DELTA_FLAG_TYPE.DELTA_FLAG_NONE, "manifest.bin", fi.FullName, newName);
         //MessageBox.Show(success ? "The manifest has been extracted successfully" : $"Error: 0x{Marshal.GetLastWin32Error():X8}");

         //if (!success) return;

         //using (FileStream fStr = new FileStream(newName, FileMode.Open, FileAccess.Read, FileShare.Read))
         //using (TextReader tr = new StreamReader(fStr) as TextReader)
         //{
         //   txtOutput.Text = tr.ReadToEnd();
         //}
      }

      private unsafe XDocument GetManifest(string path)
      {
         byte[] source, delta, output;
         DELTA_OUTPUT outData;
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
            DELTA_INPUT sourceData = new DELTA_INPUT()
            {
               lpStart = new IntPtr(sourcePtr),
               uSize = (uint)source.Length,
               Editable = false
            };

            DELTA_INPUT deltaData = new DELTA_INPUT()
            {
               lpStart = new IntPtr(deltaPtr),
               uSize = (uint)delta.Length,
               Editable = false
            };

            success = PatchAPI.ApplyDeltaB(DELTA_FLAG_TYPE.DELTA_FLAG_NONE, sourceData, deltaData, out outData);

            output = new byte[outData.uSize];
            for (int i = 0; i < outData.uSize; i++)
            {
               output[i] = Marshal.PtrToStructure<byte>(outData.lpStart + i);
            }
         }

         using (MemoryStream mStr = new MemoryStream(output))
         {
            return XDocument.Load(mStr);
         }
      }

      private void btnManifest_Click(object sender, EventArgs e)
      {
         using (OpenFileDialog ofd = new OpenFileDialog())
         {
            ofd.Filter = "Manifest files|*.manifest";
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            ofd.AddExtension = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
               txtManifest.Text = ofd.FileName;
            }
         }
      }

      private void btnSource_Click(object sender, EventArgs e)
      {
         using (OpenFileDialog ofd = new OpenFileDialog())
         {
            ofd.Filter = "WCP.DLL|wcp.dll";
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            ofd.AddExtension = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
               txtSource.Text = ofd.FileName;
            }
         }
      }
   }
}
