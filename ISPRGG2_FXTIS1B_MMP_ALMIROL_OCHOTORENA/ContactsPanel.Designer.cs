namespace ISPRGG2_FXTIS1B_MMP_ALMIROL_OCHOTORENA
{
    partial class ContactsPanel
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
            label1 = new Label();
            txtContactID = new TextBox();
            txtContactName = new TextBox();
            label2 = new Label();
            txtContactNo = new TextBox();
            label3 = new Label();
            btnView = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgv = new DataGridView();
            pbxHomepage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxHomepage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Aileron Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(94, 64);
            label1.Name = "label1";
            label1.Size = new Size(70, 14);
            label1.TabIndex = 0;
            label1.Text = "Contact ID";
            // 
            // txtContactID
            // 
            txtContactID.Location = new Point(94, 81);
            txtContactID.Name = "txtContactID";
            txtContactID.Size = new Size(140, 23);
            txtContactID.TabIndex = 1;
            txtContactID.TextChanged += txtContactID_TextChanged;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(240, 81);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(140, 23);
            txtContactName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Aileron Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(240, 63);
            label2.Name = "label2";
            label2.Size = new Size(91, 14);
            label2.TabIndex = 2;
            label2.Text = "Contact Name";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(386, 81);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(140, 23);
            txtContactNo.TabIndex = 5;
            txtContactNo.TextChanged += txtContactNo_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Aileron Heavy", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(386, 63);
            label3.Name = "label3";
            label3.Size = new Size(105, 14);
            label3.TabIndex = 4;
            label3.Text = "Contact Number";
            // 
            // btnView
            // 
            btnView.Font = new Font("Aileron Heavy", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.Location = new Point(26, 136);
            btnView.Name = "btnView";
            btnView.Size = new Size(140, 29);
            btnView.TabIndex = 7;
            btnView.Text = "VIEW ALL";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Aileron Heavy", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(172, 136);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Aileron Heavy", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(318, 136);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 29);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Aileron Heavy", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(464, 135);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 171);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 25;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(612, 296);
            dgv.TabIndex = 11;
            dgv.CellClick += dgv_CellClick;
            // 
            // pbxHomepage
            // 
            pbxHomepage.BackgroundImage = Properties.Resources.hicon;
            pbxHomepage.BackgroundImageLayout = ImageLayout.Zoom;
            pbxHomepage.Location = new Point(583, 12);
            pbxHomepage.Name = "pbxHomepage";
            pbxHomepage.Size = new Size(41, 29);
            pbxHomepage.SizeMode = PictureBoxSizeMode.CenterImage;
            pbxHomepage.TabIndex = 12;
            pbxHomepage.TabStop = false;
            pbxHomepage.Click += pbxHomepage_Click;
            // 
            // ContactsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(636, 479);
            Controls.Add(pbxHomepage);
            Controls.Add(dgv);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnView);
            Controls.Add(txtContactNo);
            Controls.Add(label3);
            Controls.Add(txtContactName);
            Controls.Add(label2);
            Controls.Add(txtContactID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ContactsPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Whisk Away Bakery - ContactsPanel";
            Load += ContactsPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxHomepage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtContactID;
        private TextBox txtContactName;
        private Label label2;
        private TextBox txtContactNo;
        private Label label3;
        private Button btnView;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgv;
        private PictureBox pbxHomepage;
    }
}