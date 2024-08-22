namespace ISPRGG2_FXTIS1B_MMP_ALMIROL_OCHOTORENA
{
    partial class Menu
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
            btnPwdSet = new Button();
            btnConPanel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPwdSet
            // 
            btnPwdSet.Font = new Font("Aileron Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnPwdSet.Location = new Point(160, 254);
            btnPwdSet.Name = "btnPwdSet";
            btnPwdSet.Size = new Size(193, 38);
            btnPwdSet.TabIndex = 11;
            btnPwdSet.Text = "PASSWORD SETTINGS";
            btnPwdSet.UseVisualStyleBackColor = true;
            btnPwdSet.Click += btnPwdSet_Click;
            // 
            // btnConPanel
            // 
            btnConPanel.Font = new Font("Aileron Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnConPanel.Location = new Point(160, 196);
            btnConPanel.Name = "btnConPanel";
            btnConPanel.Size = new Size(193, 38);
            btnConPanel.TabIndex = 10;
            btnConPanel.Text = "CONTACTS PANEL";
            btnConPanel.UseVisualStyleBackColor = true;
            btnConPanel.Click += btnConPanel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Aileron Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(193, 133);
            label1.Name = "label1";
            label1.Size = new Size(125, 42);
            label1.TabIndex = 12;
            label1.Text = "MENU";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(515, 450);
            Controls.Add(label1);
            Controls.Add(btnPwdSet);
            Controls.Add(btnConPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Whisk Away Bakery - Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPwdSet;
        private Button btnConPanel;
        private Label label1;
    }
}