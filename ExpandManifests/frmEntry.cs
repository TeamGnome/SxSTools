using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpandManifests
{
   public partial class frmEntry : Form
   {
      public frmEntry()
      {
         InitializeComponent();
      }

      private void btnManifest_Click(object sender, EventArgs e)
      {
         frmViewManifest f = new frmViewManifest();
         f.Show();

         Hide();
      }

      private void btnPaths_Click(object sender, EventArgs e)
      {
         frmDumpPaths f = new frmDumpPaths();
         f.Show();

         Hide();
      }

      private void btnDelta_Click(object sender, EventArgs e)
      {
         frmViewInfo f = new frmViewInfo();
         f.Show();

         Hide();
      }
   }
}
