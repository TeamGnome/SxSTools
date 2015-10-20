using LibSxS.Delta;
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
   public partial class frmViewInfo : Form
   {
      public frmViewInfo()
      {
         InitializeComponent();
      }

      private void btnFile_Click(object sender, EventArgs e)
      {
         using (OpenFileDialog ofd = new OpenFileDialog())
         {
            ofd.Filter = "Delta files|*.*";
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            ofd.AddExtension = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
               DeltaHeaderInfo dhi = DeltaAPI.GetDeltaInformation(ofd.FileName);

               gvInformation.Rows.Clear();

               Type typeData = typeof(DeltaHeaderInfo);
               foreach(var field in typeData.GetFields())
               {
                  DataGridViewRow row = new DataGridViewRow();
                  row.CreateCells(gvInformation);

                  row.Cells[0].Value = field.Name;
                  row.Cells[1].Value = field.GetValue(dhi).ToString();

                  gvInformation.Rows.Add(row);
               }
            }
         }
      }
   }
}
