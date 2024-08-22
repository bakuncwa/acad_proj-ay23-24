namespace FBTIS1B_Almirol_Ochotorena_FinalMP
{
    partial class PhantomOdyssey_Minigame1
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
            components = new System.ComponentModel.Container();
            tRender1 = new System.Windows.Forms.Timer(components);
            lblHealthLevel = new Label();
            SuspendLayout();
            // 
            // tRender1
            // 
            tRender1.Enabled = true;
            tRender1.Interval = 50;
            tRender1.Tick += tRender1_Tick;
            // 
            // lblHealthLevel
            // 
            lblHealthLevel.AutoSize = true;
            lblHealthLevel.ForeColor = Color.White;
            lblHealthLevel.Location = new Point(834, 20);
            lblHealthLevel.Name = "lblHealthLevel";
            lblHealthLevel.Size = new Size(139, 25);
            lblHealthLevel.TabIndex = 2;
            lblHealthLevel.Text = "Health: 100/100";
            // 

            // 
            // PhantomOdyssey_Minigame1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(985, 553);
            Controls.Add(lblHealthLevel);
            Name = "PhantomOdyssey_Minigame1";
            Text = "PhantomOdyssey_Minigame1";
            Load += PhantomOdyssey_Minigame1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tRender1;
        private Label lblHealthLevel;
        private System.Windows.Forms.Timer tRender2;
    }
}