namespace FBTIS1B_Almirol_Ochotorena_FinalMP
{
    partial class PhantomOdyssey_Minigame2
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
            picMC = new PictureBox();
            pBtnRetaliate = new PictureBox();
            pBtnRun = new PictureBox();
            lblHealthLvl = new Label();
            lblTimer = new Label();
            picPhantom = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picMC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBtnRetaliate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBtnRun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPhantom).BeginInit();
            SuspendLayout();
            // 
            // picMC
            // 
            picMC.BackColor = Color.Transparent;
            picMC.BackgroundImage = Properties.Resources.mc_pls_remove_bg;
            picMC.BackgroundImageLayout = ImageLayout.Zoom;
            picMC.Location = new Point(88, 278);
            picMC.Name = "picMC";
            picMC.Size = new Size(190, 132);
            picMC.TabIndex = 0;
            picMC.TabStop = false;
            // 
            // pBtnRetaliate
            // 
            pBtnRetaliate.BackColor = Color.Transparent;
            pBtnRetaliate.BackgroundImage = Properties.Resources.RETALIATE;
            pBtnRetaliate.BackgroundImageLayout = ImageLayout.Zoom;
            pBtnRetaliate.Location = new Point(24, 124);
            pBtnRetaliate.Name = "pBtnRetaliate";
            pBtnRetaliate.Size = new Size(150, 75);
            pBtnRetaliate.TabIndex = 1;
            pBtnRetaliate.TabStop = false;
            pBtnRetaliate.Click += pBtnRetaliate_Click;
            // 
            // pBtnRun
            // 
            pBtnRun.BackColor = Color.Transparent;
            pBtnRun.BackgroundImage = Properties.Resources.RUN;
            pBtnRun.BackgroundImageLayout = ImageLayout.Zoom;
            pBtnRun.Location = new Point(242, 124);
            pBtnRun.Name = "pBtnRun";
            pBtnRun.Size = new Size(146, 68);
            pBtnRun.TabIndex = 2;
            pBtnRun.TabStop = false;
            pBtnRun.Click += pBtnRun_Click;
            // 
            // lblHealthLvl
            // 
            lblHealthLvl.AutoSize = true;
            lblHealthLvl.ForeColor = Color.White;
            lblHealthLvl.Location = new Point(40, 27);
            lblHealthLvl.Name = "lblHealthLvl";
            lblHealthLvl.Size = new Size(102, 25);
            lblHealthLvl.TabIndex = 3;
            lblHealthLvl.Text = "Health: 100";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.ForeColor = Color.White;
            lblTimer.Location = new Point(251, 27);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(79, 25);
            lblTimer.TabIndex = 4;
            lblTimer.Text = "Time: 15";
            // 
            // picPhantom
            // 
            picPhantom.BackColor = Color.Transparent;
            picPhantom.BackgroundImage = Properties.Resources.final_boss;
            picPhantom.BackgroundImageLayout = ImageLayout.Zoom;
            picPhantom.Location = new Point(625, 292);
            picPhantom.Name = "picPhantom";
            picPhantom.Size = new Size(231, 96);
            picPhantom.TabIndex = 5;
            picPhantom.TabStop = false;
            picPhantom.Click += picPhantom_Click;
            // 
            // PhantomOdyssey_Minigame2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(985, 553);
            Controls.Add(picPhantom);
            Controls.Add(lblTimer);
            Controls.Add(lblHealthLvl);
            Controls.Add(pBtnRun);
            Controls.Add(pBtnRetaliate);
            Controls.Add(picMC);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PhantomOdyssey_Minigame2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhantomOdyssey_Minigame2";
            Load += PhantomOdyssey_Minigame2_Load;
            KeyDown += PhantomOdyssey_Minigame2_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picMC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBtnRetaliate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBtnRun).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPhantom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picMC;
        private PictureBox pBtnRetaliate;
        private PictureBox pBtnRun;
        private Label lblHealthLvl;
        private Label lblTimer;
        private PictureBox picPhantom;
    }
}