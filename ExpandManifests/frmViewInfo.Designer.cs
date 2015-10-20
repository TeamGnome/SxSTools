namespace ExpandManifests
{
   partial class frmViewInfo
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
         this.btnFile = new System.Windows.Forms.Button();
         this.gvInformation = new System.Windows.Forms.DataGridView();
         this.colField = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.gvInformation)).BeginInit();
         this.SuspendLayout();
         // 
         // btnFile
         // 
         this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.btnFile.Location = new System.Drawing.Point(12, 12);
         this.btnFile.Name = "btnFile";
         this.btnFile.Size = new System.Drawing.Size(280, 23);
         this.btnFile.TabIndex = 1;
         this.btnFile.Text = "Select delta...";
         this.btnFile.UseVisualStyleBackColor = true;
         this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
         // 
         // gvInformation
         // 
         this.gvInformation.AllowUserToAddRows = false;
         this.gvInformation.AllowUserToDeleteRows = false;
         this.gvInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.gvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.gvInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colField,
            this.colData});
         this.gvInformation.Location = new System.Drawing.Point(13, 42);
         this.gvInformation.Name = "gvInformation";
         this.gvInformation.ReadOnly = true;
         this.gvInformation.Size = new System.Drawing.Size(279, 387);
         this.gvInformation.TabIndex = 2;
         // 
         // colField
         // 
         this.colField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.colField.HeaderText = "Field";
         this.colField.Name = "colField";
         this.colField.ReadOnly = true;
         // 
         // colData
         // 
         this.colData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.colData.HeaderText = "Data";
         this.colData.Name = "colData";
         this.colData.ReadOnly = true;
         // 
         // frmViewInfo
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(304, 441);
         this.Controls.Add(this.gvInformation);
         this.Controls.Add(this.btnFile);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "frmViewInfo";
         this.ShowIcon = false;
         this.Text = "View Delta Information";
         ((System.ComponentModel.ISupportInitialize)(this.gvInformation)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnFile;
      private System.Windows.Forms.DataGridView gvInformation;
      private System.Windows.Forms.DataGridViewTextBoxColumn colField;
      private System.Windows.Forms.DataGridViewTextBoxColumn colData;
   }
}