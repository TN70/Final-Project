namespace GUI
{
    partial class QuanLyTaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.cboLoaiTK = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.lbSDT = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbNgayVaoLam = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_Tiltle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.taiKhoanDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenNV1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoai1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 70;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoGenerateColumns = false;
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNV1DataGridViewTextBoxColumn,
            this.username1DataGridViewTextBoxColumn,
            this.password1DataGridViewTextBoxColumn,
            this.tenLoai1DataGridViewTextBoxColumn,
            this.trangThai1DataGridViewTextBoxColumn});
            this.dgvTaiKhoan.DataSource = this.taiKhoanDTOBindingSource;
            this.dgvTaiKhoan.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(10, 62);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(581, 427);
            this.dgvTaiKhoan.TabIndex = 68;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::GUI.Properties.Resources.icons8_update_left_rotation_50;
            this.button1.Location = new System.Drawing.Point(425, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 58);
            this.button1.TabIndex = 80;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI.Properties.Resources.icons8_save_64;
            this.btnLuu.Location = new System.Drawing.Point(317, 371);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(74, 58);
            this.btnLuu.TabIndex = 79;
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.Image = global::GUI.Properties.Resources.icons8_delete_bin_50;
            this.btnXoa.Location = new System.Drawing.Point(214, 373);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 56);
            this.btnXoa.TabIndex = 78;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.Image = global::GUI.Properties.Resources.icons8_add_64;
            this.btnThemNV.Location = new System.Drawing.Point(100, 373);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(78, 56);
            this.btnThemNV.TabIndex = 77;
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // cboLoaiTK
            // 
            this.cboLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiTK.FormattingEnabled = true;
            this.cboLoaiTK.Items.AddRange(new object[] {
            "Chủ",
            "Bán hàng",
            "Admin"});
            this.cboLoaiTK.Location = new System.Drawing.Point(214, 228);
            this.cboLoaiTK.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiTK.Name = "cboLoaiTK";
            this.cboLoaiTK.Size = new System.Drawing.Size(203, 30);
            this.cboLoaiTK.TabIndex = 76;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Chủ",
            "Bán hàng",
            "Admin"});
            this.cboTrangThai.Location = new System.Drawing.Point(214, 291);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(203, 30);
            this.cboTrangThai.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Trạng thái :";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(214, 51);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(203, 28);
            this.txtTenNV.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tên NV :";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(214, 106);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(203, 28);
            this.txtUsername.TabIndex = 66;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.dgvTaiKhoan);
            this.groupBox2.Controls.Add(this.btn_TimKiem);
            this.groupBox2.Location = new System.Drawing.Point(33, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 510);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.MistyRose;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TimKiem.Image = global::GUI.Properties.Resources.icons8_search_30;
            this.btn_TimKiem.Location = new System.Drawing.Point(504, 18);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(87, 39);
            this.btn_TimKiem.TabIndex = 69;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(92, 169);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(103, 20);
            this.lbSDT.TabIndex = 65;
            this.lbSDT.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(214, 169);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(203, 28);
            this.txtPassword.TabIndex = 67;
            // 
            // lbNgayVaoLam
            // 
            this.lbNgayVaoLam.AutoSize = true;
            this.lbNgayVaoLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayVaoLam.Location = new System.Drawing.Point(109, 228);
            this.lbNgayVaoLam.Name = "lbNgayVaoLam";
            this.lbNgayVaoLam.Size = new System.Drawing.Size(86, 20);
            this.lbNgayVaoLam.TabIndex = 68;
            this.lbNgayVaoLam.Text = "Loại TK :";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(96, 106);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(99, 20);
            this.lbTenNV.TabIndex = 64;
            this.lbTenNV.Text = "Usename :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThemNV);
            this.groupBox1.Controls.Add(this.cboLoaiTK);
            this.groupBox1.Controls.Add(this.cboTrangThai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lbSDT);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lbNgayVaoLam);
            this.groupBox1.Controls.Add(this.lbTenNV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(655, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 502);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(271, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 57);
            this.panel2.TabIndex = 16;
            // 
            // lb_Tiltle
            // 
            this.lb_Tiltle.AutoSize = true;
            this.lb_Tiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tiltle.ForeColor = System.Drawing.Color.Black;
            this.lb_Tiltle.Location = new System.Drawing.Point(515, 13);
            this.lb_Tiltle.Name = "lb_Tiltle";
            this.lb_Tiltle.Size = new System.Drawing.Size(241, 26);
            this.lb_Tiltle.TabIndex = 0;
            this.lb_Tiltle.Text = "QUẢN LÍ TÀI KHOẢN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lb_Tiltle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 57);
            this.panel1.TabIndex = 17;
            // 
            // taiKhoanDTOBindingSource
            // 
            this.taiKhoanDTOBindingSource.DataSource = typeof(DTO.TaiKhoanDTO);
            // 
            // tenNV1DataGridViewTextBoxColumn
            // 
            this.tenNV1DataGridViewTextBoxColumn.DataPropertyName = "TenNV1";
            this.tenNV1DataGridViewTextBoxColumn.HeaderText = "Tên NV";
            this.tenNV1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNV1DataGridViewTextBoxColumn.Name = "tenNV1DataGridViewTextBoxColumn";
            // 
            // username1DataGridViewTextBoxColumn
            // 
            this.username1DataGridViewTextBoxColumn.DataPropertyName = "Username1";
            this.username1DataGridViewTextBoxColumn.HeaderText = "Username";
            this.username1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.username1DataGridViewTextBoxColumn.Name = "username1DataGridViewTextBoxColumn";
            // 
            // password1DataGridViewTextBoxColumn
            // 
            this.password1DataGridViewTextBoxColumn.DataPropertyName = "Password1";
            this.password1DataGridViewTextBoxColumn.HeaderText = "Password";
            this.password1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.password1DataGridViewTextBoxColumn.Name = "password1DataGridViewTextBoxColumn";
            // 
            // tenLoai1DataGridViewTextBoxColumn
            // 
            this.tenLoai1DataGridViewTextBoxColumn.DataPropertyName = "TenLoai1";
            this.tenLoai1DataGridViewTextBoxColumn.HeaderText = "Loại TK";
            this.tenLoai1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLoai1DataGridViewTextBoxColumn.Name = "tenLoai1DataGridViewTextBoxColumn";
            // 
            // trangThai1DataGridViewTextBoxColumn
            // 
            this.trangThai1DataGridViewTextBoxColumn.DataPropertyName = "TrangThai1";
            this.trangThai1DataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.trangThai1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThai1DataGridViewTextBoxColumn.Name = "trangThai1DataGridViewTextBoxColumn";
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyTaiKhoan";
            this.Size = new System.Drawing.Size(1261, 618);
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.ComboBox cboLoaiTK;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbNgayVaoLam;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_Tiltle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn username1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn password1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoai1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource taiKhoanDTOBindingSource;
    }
}
