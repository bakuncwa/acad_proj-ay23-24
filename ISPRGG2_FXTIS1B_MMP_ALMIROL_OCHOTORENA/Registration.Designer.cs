namespace ISPRGG2_FXTIS1B_MMP_ALMIROL_OCHOTORENA
{
    partial class Registration
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
            btnAdd = new Button();
            cboxShowPwd = new CheckBox();
            txtPwd = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pbxHomepage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxHomepage).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(384, 568);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 63);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "REGISTER";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboxShowPwd
            // 
            cboxShowPwd.AutoSize = true;
            cboxShowPwd.Checked = true;
            cboxShowPwd.CheckState = CheckState.Checked;
            cboxShowPwd.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            cboxShowPwd.Location = new Point(380, 463);
            cboxShowPwd.Margin = new Padding(4, 5, 4, 5);
            cboxShowPwd.Name = "cboxShowPwd";
            cboxShowPwd.Size = new Size(168, 24);
            cboxShowPwd.TabIndex = 16;
            cboxShowPwd.Text = "Show Password";
            cboxShowPwd.UseVisualStyleBackColor = true;
            cboxShowPwd.CheckedChanged += cboxShowPwd_CheckedChanged;
            // 
            // txtPwd
            // 
            txtPwd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPwd.Location = new Point(197, 415);
            txtPwd.Margin = new Padding(4, 5, 4, 5);
            txtPwd.Name = "txtPwd";
            txtPwd.PlaceholderText = "Enter new password";
            txtPwd.Size = new Size(335, 28);
            txtPwd.TabIndex = 15;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(197, 303);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter new username";
            txtUsername.Size = new Size(335, 28);
            txtUsername.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(197, 383);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 13;
            label4.Text = "PASSWORD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(197, 272);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 12;
            label3.Text = "USERNAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(140, 165);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(475, 25);
            label2.TabIndex = 11;
            label2.Text = "Enter your credentials to sign in to your account.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(220, 95);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(304, 61);
            label1.TabIndex = 10;
            label1.Text = "REGISTER";
            // 
            // pbxHomepage
            // 
            pbxHomepage.BackgroundImage = Properties.Resources.hicon;
            pbxHomepage.BackgroundImageLayout = ImageLayout.Zoom;
            pbxHomepage.Location = new Point(629, 43);
            pbxHomepage.Margin = new Padding(4, 5, 4, 5);
            pbxHomepage.Name = "pbxHomepage";
            pbxHomepage.Size = new Size(59, 48);
            pbxHomepage.SizeMode = PictureBoxSizeMode.CenterImage;
            pbxHomepage.TabIndex = 20;
            pbxHomepage.TabStop = false;
            pbxHomepage.Click += pbxHomepage_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(736, 750);
            Controls.Add(pbxHomepage);
            Controls.Add(btnAdd);
            Controls.Add(cboxShowPwd);
            Controls.Add(txtPwd);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Whisk Away Bakery - Registration";
            Load += Registration_Load;
            ((System.ComponentModel.ISupportInitialize)pbxHomepage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private CheckBox cboxShowPwd;
        private TextBox txtPwd;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pbxHomepage;
    }
}