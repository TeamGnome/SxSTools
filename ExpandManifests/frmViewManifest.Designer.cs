﻿namespace ExpandManifests
{
   partial class frmViewManifest
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
         this.lblManifest = new System.Windows.Forms.Label();
         this.txtManifest = new System.Windows.Forms.TextBox();
         this.btnManifest = new System.Windows.Forms.Button();
         this.lblSource = new System.Windows.Forms.Label();
         this.txtSource = new System.Windows.Forms.TextBox();
         this.btnSource = new System.Windows.Forms.Button();
         this.txtOutput = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // lblManifest
         // 
         this.lblManifest.AutoSize = true;
         this.lblManifest.Location = new System.Drawing.Point(12, 15);
         this.lblManifest.Name = "lblManifest";
         this.lblManifest.Size = new System.Drawing.Size(55, 13);
         this.lblManifest.TabIndex = 0;
         this.lblManifest.Text = "Manifest:";
         // 
         // txtManifest
         // 
         this.txtManifest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtManifest.Location = new System.Drawing.Point(131, 12);
         this.txtManifest.Name = "txtManifest";
         this.txtManifest.ReadOnly = true;
         this.txtManifest.Size = new System.Drawing.Size(360, 22);
         this.txtManifest.TabIndex = 0;
         this.txtManifest.Click += new System.EventHandler(this.btnManifest_Click);
         // 
         // btnManifest
         // 
         this.btnManifest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnManifest.Location = new System.Drawing.Point(497, 11);
         this.btnManifest.Name = "btnManifest";
         this.btnManifest.Size = new System.Drawing.Size(75, 24);
         this.btnManifest.TabIndex = 1;
         this.btnManifest.Text = "Browse...";
         this.btnManifest.UseVisualStyleBackColor = true;
         this.btnManifest.Click += new System.EventHandler(this.btnManifest_Click);
         // 
         // lblSource
         // 
         this.lblSource.AutoSize = true;
         this.lblSource.Location = new System.Drawing.Point(12, 43);
         this.lblSource.Name = "lblSource";
         this.lblSource.Size = new System.Drawing.Size(99, 13);
         this.lblSource.TabIndex = 0;
         this.lblSource.Text = "Source (WCP.DLL):";
         // 
         // txtSource
         // 
         this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtSource.Location = new System.Drawing.Point(131, 40);
         this.txtSource.Name = "txtSource";
         this.txtSource.ReadOnly = true;
         this.txtSource.Size = new System.Drawing.Size(360, 22);
         this.txtSource.TabIndex = 2;
         this.txtSource.Click += new System.EventHandler(this.btnSource_Click);
         // 
         // btnSource
         // 
         this.btnSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnSource.Location = new System.Drawing.Point(497, 39);
         this.btnSource.Name = "btnSource";
         this.btnSource.Size = new System.Drawing.Size(75, 24);
         this.btnSource.TabIndex = 3;
         this.btnSource.Text = "Browse...";
         this.btnSource.UseVisualStyleBackColor = true;
         this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
         // 
         // txtOutput
         // 
         this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtOutput.Location = new System.Drawing.Point(15, 69);
         this.txtOutput.Multiline = true;
         this.txtOutput.Name = "txtOutput";
         this.txtOutput.ReadOnly = true;
         this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.txtOutput.Size = new System.Drawing.Size(556, 180);
         this.txtOutput.TabIndex = 5;
         // 
         // mainFrm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(584, 261);
         this.Controls.Add(this.txtOutput);
         this.Controls.Add(this.btnSource);
         this.Controls.Add(this.btnManifest);
         this.Controls.Add(this.txtSource);
         this.Controls.Add(this.lblSource);
         this.Controls.Add(this.txtManifest);
         this.Controls.Add(this.lblManifest);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "mainFrm";
         this.ShowIcon = false;
         this.Text = "Expand WinSxS Manifests";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblManifest;
      private System.Windows.Forms.TextBox txtManifest;
      private System.Windows.Forms.Button btnManifest;
      private System.Windows.Forms.Label lblSource;
      private System.Windows.Forms.TextBox txtSource;
      private System.Windows.Forms.Button btnSource;
      private System.Windows.Forms.TextBox txtOutput;
   }
}

