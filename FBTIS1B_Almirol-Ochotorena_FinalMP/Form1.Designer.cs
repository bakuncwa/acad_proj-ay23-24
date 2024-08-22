namespace FBTIS1B_Almirol_Ochotorena_FinalMP
{
    partial class formTitleScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picTitle1 = new PictureBox();
            picTitle2 = new PictureBox();
            picTitle3 = new PictureBox();
            picStart = new PictureBox();
            picExit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picTitle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTitle2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTitle3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            SuspendLayout();
            // 
            // picTitle1
            // 
            picTitle1.BackColor = Color.Transparent;
            picTitle1.BackgroundImage = Properties.Resources._3;
            picTitle1.BackgroundImageLayout = ImageLayout.Zoom;
            picTitle1.Location = new Point(306, 65);
            picTitle1.Name = "picTitle1";
            picTitle1.Size = new Size(338, 84);
            picTitle1.TabIndex = 0;
            picTitle1.TabStop = false;
            // 
            // picTitle2
            // 
            picTitle2.BackColor = Color.Transparent;
            picTitle2.BackgroundImage = Properties.Resources._4;
            picTitle2.BackgroundImageLayout = ImageLayout.Zoom;
            picTitle2.Location = new Point(253, 136);
            picTitle2.Name = "picTitle2";
            picTitle2.Size = new Size(463, 193);
            picTitle2.TabIndex = 1;
            picTitle2.TabStop = false;
            // 
            // picTitle3
            // 
            picTitle3.BackColor = Color.Transparent;
            picTitle3.BackgroundImage = Properties.Resources._5;
            picTitle3.BackgroundImageLayout = ImageLayout.Zoom;
            picTitle3.Location = new Point(334, 326);
            picTitle3.Name = "picTitle3";
            picTitle3.Size = new Size(273, 89);
            picTitle3.TabIndex = 2;
            picTitle3.TabStop = false;
            // 
            // picStart
            // 
            picStart.BackColor = Color.Transparent;
            picStart.BackgroundImage = Properties.Resources._6;
            picStart.BackgroundImageLayout = ImageLayout.Zoom;
            picStart.Location = new Point(306, 434);
            picStart.Name = "picStart";
            picStart.Size = new Size(150, 75);
            picStart.TabIndex = 3;
            picStart.TabStop = false;
            picStart.Click += picStart_Click;
            // 
            // picExit
            // 
            picExit.BackColor = Color.Transparent;
            picExit.BackgroundImage = Properties.Resources._7;
            picExit.BackgroundImageLayout = ImageLayout.Zoom;
            picExit.Location = new Point(479, 434);
            picExit.Name = "picExit";
            picExit.Size = new Size(145, 75);
            picExit.TabIndex = 4;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
            // 
            // formTitleScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(985, 553);
            Controls.Add(picExit);
            Controls.Add(picStart);
            Controls.Add(picTitle3);
            Controls.Add(picTitle2);
            Controls.Add(picTitle1);
            Name = "formTitleScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhantomOdyssey_TS";
            ((System.ComponentModel.ISupportInitialize)picTitle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTitle2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTitle3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picTitle1;
        private PictureBox picTitle2;
        private PictureBox picTitle3;
        private PictureBox picStart;
        private PictureBox picExit;
    }
}
