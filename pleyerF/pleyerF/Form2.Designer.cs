﻿namespace pleyerF
{
    partial class Form2
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
            this.playList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // playList
            // 
            this.playList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(160)))));
            this.playList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playList.FormattingEnabled = true;
            this.playList.ItemHeight = 16;
            this.playList.Location = new System.Drawing.Point(12, 12);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(976, 178);
            this.playList.TabIndex = 0;
            this.playList.SelectedIndexChanged += new System.EventHandler(this.playList_SelectedIndexChanged);
            this.playList.DoubleClick += new System.EventHandler(this.playList_DoubleClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1000, 200);
            this.ControlBox = false;
            this.Controls.Add(this.playList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox playList;
    }
}