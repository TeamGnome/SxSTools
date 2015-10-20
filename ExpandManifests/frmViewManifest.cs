using LibSxS.Delta;
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
   public partial class frmViewManifest : Form
   {
      public frmViewManifest()
      {
         InitializeComponent();
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

               FileInfo fi = new FileInfo(txtManifest.Text);
               string newName = fi.FullName.Replace(".manifest", ".new.manifest");

               txtOutput.Text = DeltaAPI.GetManifest(txtManifest.Text).ToString();
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
