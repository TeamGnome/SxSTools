namespace ExpandManifests
{
   partial class frmEntry
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
         this.grpManfiest = new System.Windows.Forms.GroupBox();
         this.btnPaths = new System.Windows.Forms.Button();
         this.btnManifest = new System.Windows.Forms.Button();
         this.grpOther = new System.Windows.Forms.GroupBox();
         this.btnDelta = new System.Windows.Forms.Button();
         this.splitContainer = new System.Windows.Forms.SplitContainer();
         this.btnPathsXml = new System.Windows.Forms.Button();
         this.grpManfiest.SuspendLayout();
         this.grpOther.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
         this.splitContainer.Panel1.SuspendLayout();
         this.splitContainer.Panel2.SuspendLayout();
         this.splitContainer.SuspendLayout();
         this.SuspendLayout();
         // 
         // grpManfiest
         // 
         this.grpManfiest.Controls.Add(this.btnPathsXml);
         this.grpManfiest.Controls.Add(this.btnPaths);
         this.grpManfiest.Controls.Add(this.btnManifest);
         this.grpManfiest.Dock = System.Windows.Forms.DockStyle.Fill;
         this.grpManfiest.Location = new System.Drawing.Point(4, 4);
         this.grpManfiest.Name = "grpManfiest";
         this.grpManfiest.Size = new System.Drawing.Size(226, 273);
         this.grpManfiest.TabIndex = 0;
         this.grpManfiest.TabStop = false;
         this.grpManfiest.Text = "Manifest tools";
         // 
         // btnPaths
         // 
         this.btnPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.btnPaths.Location = new System.Drawing.Point(7, 51);
         this.btnPaths.Name = "btnPaths";
         this.btnPaths.Size = new System.Drawing.Size(213, 23);
         this.btnPaths.TabIndex = 0;
         this.btnPaths.Text = "Dump Manifest Paths";
         this.btnPaths.UseVisualStyleBackColor = true;
         this.btnPaths.Click += new System.EventHandler(this.btnPaths_Click);
         // 
         // btnManifest
         // 
         this.btnManifest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.btnManifest.Location = new System.Drawing.Point(7, 22);
         this.btnManifest.Name = "btnManifest";
         this.btnManifest.Size = new System.Drawing.Size(213, 23);
         this.btnManifest.TabIndex = 0;
         this.btnManifest.Text = "Expand Manifest";
         this.btnManifest.UseVisualStyleBackColor = true;
         this.btnManifest.Click += new System.EventHandler(this.btnManifest_Click);
         // 
         // grpOther
         // 
         this.grpOther.Controls.Add(this.btnDelta);
         this.grpOther.Dock = System.Windows.Forms.DockStyle.Fill;
         this.grpOther.Location = new System.Drawing.Point(1, 4);
         this.grpOther.Name = "grpOther";
         this.grpOther.Size = new System.Drawing.Size(226, 273);
         this.grpOther.TabIndex = 0;
         this.grpOther.TabStop = false;
         this.grpOther.Text = "Other";
         // 
         // btnDelta
         // 
         this.btnDelta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.btnDelta.Location = new System.Drawing.Point(7, 22);
         this.btnDelta.Name = "btnDelta";
         this.btnDelta.Size = new System.Drawing.Size(213, 23);
         this.btnDelta.TabIndex = 0;
         this.btnDelta.Text = "Delta Information";
         this.btnDelta.UseVisualStyleBackColor = true;
         this.btnDelta.Click += new System.EventHandler(this.btnDelta_Click);
         // 
         // splitContainer
         // 
         this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer.IsSplitterFixed = true;
         this.splitContainer.Location = new System.Drawing.Point(0, 0);
         this.splitContainer.Name = "splitContainer";
         // 
         // splitContainer.Panel1
         // 
         this.splitContainer.Panel1.Controls.Add(this.grpManfiest);
         this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(4, 4, 1, 4);
         // 
         // splitContainer.Panel2
         // 
         this.splitContainer.Panel2.Controls.Add(this.grpOther);
         this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(1, 4, 4, 4);
         this.splitContainer.Size = new System.Drawing.Size(464, 281);
         this.splitContainer.SplitterDistance = 231;
         this.splitContainer.SplitterWidth = 2;
         this.splitContainer.TabIndex = 1;
         // 
         // btnPathsXml
         // 
         this.btnPathsXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.btnPathsXml.Location = new System.Drawing.Point(7, 80);
         this.btnPathsXml.Name = "btnPathsXml";
         this.btnPathsXml.Size = new System.Drawing.Size(213, 23);
         this.btnPathsXml.TabIndex = 0;
         this.btnPathsXml.Text = "Dump Manifest Paths (XML)";
         this.btnPathsXml.UseVisualStyleBackColor = true;
         this.btnPathsXml.Click += new System.EventHandler(this.btnPathsXml_Click);
         // 
         // frmEntry
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.Window;
         this.ClientSize = new System.Drawing.Size(464, 281);
         this.Controls.Add(this.splitContainer);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "frmEntry";
         this.ShowIcon = false;
         this.Text = "WinSxS Tools";
         this.grpManfiest.ResumeLayout(false);
         this.grpOther.ResumeLayout(false);
         this.splitContainer.Panel1.ResumeLayout(false);
         this.splitContainer.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
         this.splitContainer.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox grpManfiest;
      private System.Windows.Forms.GroupBox grpOther;
      private System.Windows.Forms.Button btnManifest;
      private System.Windows.Forms.Button btnPaths;
      private System.Windows.Forms.Button btnDelta;
      private System.Windows.Forms.SplitContainer splitContainer;
      private System.Windows.Forms.Button btnPathsXml;
   }
}