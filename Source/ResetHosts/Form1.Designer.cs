﻿namespace ResetHosts
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Text_BatResetClear = new System.Windows.Forms.RichTextBox();
            this.Text_BatEditClear = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Text_BatResetClear
            // 
            this.Text_BatResetClear.Location = new System.Drawing.Point(187, 10);
            this.Text_BatResetClear.Name = "Text_BatResetClear";
            this.Text_BatResetClear.ReadOnly = true;
            this.Text_BatResetClear.Size = new System.Drawing.Size(169, 199);
            this.Text_BatResetClear.TabIndex = 2;
            this.Text_BatResetClear.Text = resources.GetString("Text_BatResetClear.Text");
            // 
            // Text_BatEditClear
            // 
            this.Text_BatEditClear.Location = new System.Drawing.Point(12, 10);
            this.Text_BatEditClear.Name = "Text_BatEditClear";
            this.Text_BatEditClear.ReadOnly = true;
            this.Text_BatEditClear.Size = new System.Drawing.Size(169, 201);
            this.Text_BatEditClear.TabIndex = 4;
            this.Text_BatEditClear.Text = resources.GetString("Text_BatEditClear.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 250);
            this.Controls.Add(this.Text_BatEditClear);
            this.Controls.Add(this.Text_BatResetClear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(384, 289);
            this.MinimumSize = new System.Drawing.Size(384, 289);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HackinGuide.Net - Host Cleaner";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox Text_BatResetClear;
        private System.Windows.Forms.RichTextBox Text_BatEditClear;
    }
}

