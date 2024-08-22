namespace ISPRGG2_FXTIS1B_MMP_ALMIROL_OCHOTORENA
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtPwd = new TextBox();
            cboxShowPwd = new CheckBox();
            btnSignUp = new Button();
            btnLogIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 97);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(484, 61);
            label1.TabIndex = 0;
            label1.Text = "WELCOME BACK!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(153, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(475, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter your credentials to sign in to your account.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(206, 273);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 2;
            label3.Text = "USERNAME:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(206, 385);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 3;
            label4.Text = "PASSWORD:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(206, 305);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(335, 31);
            txtUsername.TabIndex = 4;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(206, 417);
            txtPwd.Margin = new Padding(4, 5, 4, 5);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(335, 31);
            txtPwd.TabIndex = 5;
            // 
            // cboxShowPwd
            // 
            cboxShowPwd.AutoSize = true;
            cboxShowPwd.Checked = true;
            cboxShowPwd.CheckState = CheckState.Checked;
            cboxShowPwd.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            cboxShowPwd.Location = new Point(389, 465);
            cboxShowPwd.Margin = new Padding(4, 5, 4, 5);
            cboxShowPwd.Name = "cboxShowPwd";
            cboxShowPwd.Size = new Size(168, 24);
            cboxShowPwd.TabIndex = 6;
            cboxShowPwd.Text = "Show Password";
            cboxShowPwd.UseVisualStyleBackColor = true;
            cboxShowPwd.CheckedChanged += cboxShowPwd_CheckedChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignUp.Location = new Point(204, 585);
            btnSignUp.Margin = new Padding(4, 5, 4, 5);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(151, 63);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "NEW ADMIN";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.Location = new Point(393, 585);
            btnLogIn.Margin = new Padding(4, 5, 4, 5);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(151, 63);
            btnLogIn.TabIndex = 9;
            btnLogIn.Text = "LOG IN";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(736, 750);
            Controls.Add(btnLogIn);
            Controls.Add(btnSignUp);
            Controls.Add(cboxShowPwd);
            Controls.Add(txtPwd);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Whisk Away Bakery - Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtPwd;
        private CheckBox cboxShowPwd;
        private Button btnSignUp;
        private Button btnLogIn;
    }
}