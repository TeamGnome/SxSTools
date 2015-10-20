namespace ExpandManifests
{
   partial class frmDumpPaths
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.btnFolder = new System.Windows.Forms.Button();
         this.txtOutput = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // btnFolder
         // 
         this.btnFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.btnFolder.Location = new System.Drawing.Point(13, 13);
         this.btnFolder.Name = "btnFolder";
         this.btnFolder.Size = new System.Drawing.Size(279, 23);
         this.btnFolder.TabIndex = 0;
         this.btnFolder.Text = "Select folder...";
         this.btnFolder.UseVisualStyleBackColor = true;
         this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
         // 
         // txtOutput
         // 
         this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtOutput.Location = new System.Drawing.Point(13, 43);
         this.txtOutput.Multiline = true;
         this.txtOutput.Name = "txtOutput";
         this.txtOutput.ReadOnly = true;
         this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.txtOutput.Size = new System.Drawing.Size(279, 386);
         this.txtOutput.TabIndex = 1;
         // 
         // pathDumpFrm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(304, 441);
         this.Controls.Add(this.txtOutput);
         this.Controls.Add(this.btnFolder);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "pathDumpFrm";
         this.ShowIcon = false;
         this.Text = "Dump Paths";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnFolder;
      private System.Windows.Forms.TextBox txtOutput;
   }
}