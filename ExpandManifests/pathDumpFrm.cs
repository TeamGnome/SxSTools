using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExpandManifests
{
   public partial class pathDumpFrm : Form
   {
      public pathDumpFrm()
      {
         InitializeComponent();
      }

      private void btnFolder_Click(object sender, EventArgs e)
      {
         using (FolderBrowserDialog fbd = new FolderBrowserDialog())
         {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
               Task.Run(() =>
               {
                  string[] manifests = Directory.GetFiles(fbd.SelectedPath, "*.manifest");
                  List<XDocument> manifestDocs = new List<XDocument>(manifests.Length);

                  foreach (string manifest in manifests)
                  {
                     manifestDocs.Add(PatchAPI.GetManifest(manifest));
                  }

                  var paths = manifestDocs
                     .Where(m => m.Root.Element(XName.Get("file", "urn:schemas-microsoft-com:asm.v3")) != null)
                     .SelectMany(m => m.Root.Elements(XName.Get("file", "urn:schemas-microsoft-com:asm.v3")))
                     .Where(xe => xe.Attribute("destinationPath") != null)
                     .Where(xe => xe.Attribute("name") != null)
                     .Select(xe => Path.Combine(xe.Attribute("destinationPath").Value, xe.Attribute("name").Value));

                  StringBuilder sb = new StringBuilder(string.Join("\r\n", paths).ToLower());
                  sb.Replace("$(runtime.bootdrive)", @"");
                  sb.Replace("$(runtime.programdata)", @"\ProgramData");
                  sb.Replace("$(runtime.startmenu)", @"\ProgramData\Microsoft\Windows\Start Menu\Programs");
                  sb.Replace("$(runtime.programfiles)", @"\Program Files");
                  sb.Replace("$(runtime.commonfiles)", @"\Program Files\Common Files");
                  sb.Replace("$(runtime.documentssettings)", @"\Users");
                  sb.Replace("$(runtime.windows)", @"\Windows");
                  sb.Replace("$(runtime.windir)", @"\Windows");
                  sb.Replace("$(runtime.systemroot)", @"\Windows");
                  sb.Replace("$(runtime.fonts)", @"\Windows\Fonts");
                  sb.Replace("$(runtime.help)", @"\Windows\Help");
                  sb.Replace("$(runtime.inf)", @"\Windows\inf");
                  sb.Replace("$(runtime.system32)", @"\Windows\System32");
                  sb.Replace("$(runtime.drivers)", @"\Windows\System32\Drivers");
                  sb.Replace("$(runtime.wbem)", @"\Windows\Wbem");

                  string[] presort = sb.ToString().Split(new string[] { "\r\n" }, StringSplitOptions.None);

                  this.BeginInvoke(new Action(() =>
                  {
                     txtOutput.Text = string.Join("\r\n", presort.OrderBy(p => p));
                  }));
               });
            }
         }
      }
   }
}
