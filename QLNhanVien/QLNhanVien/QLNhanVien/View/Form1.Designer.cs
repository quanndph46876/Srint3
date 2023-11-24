namespace QLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtgNhanVien = new DataGridView();
            txtSearch = new TextBox();
            txtName = new TextBox();
            txtYear = new TextBox();
            txtRole = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            cbNam = new CheckBox();
            cbNu = new CheckBox();
            pictureBox1 = new PictureBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnShow = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgNhanVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(317, 41);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 76);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 132);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Họ Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 178);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Giới Tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 268);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 4;
            label5.Text = "SDT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 220);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(356, 268);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 6;
            label7.Text = "Chức vụ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 178);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 7;
            label8.Text = "Năm sinh";
            // 
            // dtgNhanVien
            // 
            dtgNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgNhanVien.Location = new Point(12, 395);
            dtgNhanVien.Name = "dtgNhanVien";
            dtgNhanVien.RowHeadersWidth = 51;
            dtgNhanVien.RowTemplate.Height = 29;
            dtgNhanVien.Size = new Size(871, 274);
            dtgNhanVien.TabIndex = 8;
            dtgNhanVien.CellClick += dtgNhanVien_CellClick;
            dtgNhanVien.CellContentClick += dtgNhanVien_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(135, 73);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(329, 27);
            txtSearch.TabIndex = 9;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(499, 27);
            txtName.TabIndex = 10;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(135, 175);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(173, 27);
            txtYear.TabIndex = 11;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(438, 265);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(195, 27);
            txtRole.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(135, 217);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(498, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(134, 265);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(209, 27);
            txtSDT.TabIndex = 16;
            // 
            // cbNam
            // 
            cbNam.AutoSize = true;
            cbNam.Location = new Point(455, 178);
            cbNam.Name = "cbNam";
            cbNam.Size = new Size(63, 24);
            cbNam.TabIndex = 17;
            cbNam.Text = "Nam";
            cbNam.UseVisualStyleBackColor = true;
            // 
            // cbNu
            // 
            cbNu.AutoSize = true;
            cbNu.Location = new Point(557, 178);
            cbNu.Name = "cbNu";
            cbNu.Size = new Size(51, 24);
            cbNu.TabIndex = 18;
            cbNu.Text = "Nữ";
            cbNu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(720, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 159);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(498, 72);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(44, 329);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 42);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(205, 329);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 42);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(361, 329);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 42);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(532, 329);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 42);
            btnClear.TabIndex = 24;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(20, 12);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 38);
            btnShow.TabIndex = 25;
            btnShow.Text = "Hiển Thị";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 681);
            Controls.Add(btnShow);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(pictureBox1);
            Controls.Add(cbNu);
            Controls.Add(cbNam);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtRole);
            Controls.Add(txtYear);
            Controls.Add(txtName);
            Controls.Add(txtSearch);
            Controls.Add(dtgNhanVien);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgNhanVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dtgNhanVien;
        private TextBox txtSearch;
        private TextBox txtName;
        private TextBox txtYear;
        private TextBox txtRole;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private CheckBox cbNam;
        private CheckBox cbNu;
        private PictureBox pictureBox1;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnShow;
    }
}