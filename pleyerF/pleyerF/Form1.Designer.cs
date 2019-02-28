namespace pleyerF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.slVol = new MB.Controls.ColorSlider();
            this.slTime = new MB.Controls.ColorSlider();
            this.timePlayNow = new System.Windows.Forms.Label();
            this.timePlayOver = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(80, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(40, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "П";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "--";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(880, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 40);
            this.panel1.TabIndex = 4;
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::pleyerF.Properties.Resources.iconfinder_chevron_circle_left_1608621;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(377, 63);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 40);
            this.button10.TabIndex = 10;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::pleyerF.Properties.Resources.stop;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(423, 63);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 40);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::pleyerF.Properties.Resources.right;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(566, 63);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::pleyerF.Properties.Resources.pause;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(525, 66);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 35);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::pleyerF.Properties.Resources.play;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(469, 58);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::pleyerF.Properties.Resources.open;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(920, 105);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::pleyerF.Properties.Resources.iconfinder_document_music_down_103489;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(960, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::pleyerF.Properties.Resources.newWave;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // slVol
            // 
            this.slVol.BackColor = System.Drawing.Color.Transparent;
            this.slVol.BarOuterColor = System.Drawing.Color.DarkSlateBlue;
            this.slVol.BarPenColor = System.Drawing.Color.Black;
            this.slVol.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.slVol.DrawFocusRectangle = false;
            this.slVol.ElapsedInnerColor = System.Drawing.Color.MediumPurple;
            this.slVol.ElapsedOuterColor = System.Drawing.Color.MediumPurple;
            this.slVol.LargeChange = ((uint)(5u));
            this.slVol.Location = new System.Drawing.Point(653, 105);
            this.slVol.Name = "slVol";
            this.slVol.Size = new System.Drawing.Size(221, 30);
            this.slVol.SmallChange = ((uint)(1u));
            this.slVol.TabIndex = 13;
            this.slVol.Text = "colorSlider2";
            this.slVol.ThumbInnerColor = System.Drawing.Color.DimGray;
            this.slVol.ThumbOuterColor = System.Drawing.SystemColors.WindowFrame;
            this.slVol.ThumbPenColor = System.Drawing.Color.Black;
            this.slVol.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.slVol.ThumbSize = 10;
            this.slVol.Value = 100;
            this.slVol.Scroll += new System.Windows.Forms.ScrollEventHandler(this.slVol_Scroll);
            // 
            // slTime
            // 
            this.slTime.BackColor = System.Drawing.Color.Transparent;
            this.slTime.BarOuterColor = System.Drawing.Color.DarkSlateBlue;
            this.slTime.BarPenColor = System.Drawing.Color.Black;
            this.slTime.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.slTime.DrawFocusRectangle = false;
            this.slTime.ElapsedInnerColor = System.Drawing.Color.MediumPurple;
            this.slTime.ElapsedOuterColor = System.Drawing.Color.MediumPurple;
            this.slTime.LargeChange = ((uint)(5u));
            this.slTime.Location = new System.Drawing.Point(111, 12);
            this.slTime.Name = "slTime";
            this.slTime.Size = new System.Drawing.Size(763, 45);
            this.slTime.SmallChange = ((uint)(1u));
            this.slTime.TabIndex = 14;
            this.slTime.Text = "colorSlider1";
            this.slTime.ThumbInnerColor = System.Drawing.Color.DimGray;
            this.slTime.ThumbOuterColor = System.Drawing.SystemColors.WindowFrame;
            this.slTime.ThumbPenColor = System.Drawing.Color.Black;
            this.slTime.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.slTime.ThumbSize = 1;
            this.slTime.Value = 0;
            this.slTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.slTime_Scroll);
            // 
            // timePlayNow
            // 
            this.timePlayNow.AutoSize = true;
            this.timePlayNow.BackColor = System.Drawing.Color.Transparent;
            this.timePlayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timePlayNow.Location = new System.Drawing.Point(111, 9);
            this.timePlayNow.Name = "timePlayNow";
            this.timePlayNow.Size = new System.Drawing.Size(44, 17);
            this.timePlayNow.TabIndex = 15;
            this.timePlayNow.Text = "00:00";
            // 
            // timePlayOver
            // 
            this.timePlayOver.AutoSize = true;
            this.timePlayOver.BackColor = System.Drawing.Color.Transparent;
            this.timePlayOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timePlayOver.Location = new System.Drawing.Point(810, 9);
            this.timePlayOver.Name = "timePlayOver";
            this.timePlayOver.Size = new System.Drawing.Size(64, 17);
            this.timePlayOver.TabIndex = 16;
            this.timePlayOver.Text = "00:00:00";
            this.timePlayOver.Click += new System.EventHandler(this.timePlayOver_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1000, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timePlayOver);
            this.Controls.Add(this.timePlayNow);
            this.Controls.Add(this.slTime);
            this.Controls.Add(this.slVol);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private MB.Controls.ColorSlider slVol;
        private MB.Controls.ColorSlider slTime;
        private System.Windows.Forms.Label timePlayNow;
        private System.Windows.Forms.Label timePlayOver;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

