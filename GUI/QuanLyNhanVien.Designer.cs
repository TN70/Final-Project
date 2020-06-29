namespace GUI
{
    partial class QuanLyNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Tiltle = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.iD1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayVaoLam1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnh1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVu1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienDTOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbNgayVaoLam = new System.Windows.Forms.Label();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.nhanVienDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDTOBindingSource2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.lb_Tiltle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 57);
            this.panel1.TabIndex = 11;
            // 
            // lb_Tiltle
            // 
            this.lb_Tiltle.AutoSize = true;
            this.lb_Tiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tiltle.ForeColor = System.Drawing.Color.Black;
            this.lb_Tiltle.Location = new System.Drawing.Point(515, 13);
            this.lb_Tiltle.Name = "lb_Tiltle";
            this.lb_Tiltle.Size = new System.Drawing.Size(244, 26);
            this.lb_Tiltle.TabIndex = 0;
            this.lb_Tiltle.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(203, 35);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem.Multiline = true;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(276, 25);
            this.txt_TimKiem.TabIndex = 2;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iD1DataGridViewTextBoxColumn,
            this.tenNV1DataGridViewTextBoxColumn,
            this.ngayVaoLam1DataGridViewTextBoxColumn,
            this.sDT1DataGridViewTextBoxColumn,
            this.diachi1DataGridViewTextBoxColumn,
            this.hinhAnh1DataGridViewTextBoxColumn,
            this.chucVu1DataGridViewTextBoxColumn});
            this.dgvNhanVien.DataSource = this.nhanVienDTOBindingSource2;
            this.dgvNhanVien.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvNhanVien.Location = new System.Drawing.Point(15, 72);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(581, 427);
            this.dgvNhanVien.TabIndex = 5;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // iD1DataGridViewTextBoxColumn
            // 
            this.iD1DataGridViewTextBoxColumn.DataPropertyName = "ID1";
            this.iD1DataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.iD1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iD1DataGridViewTextBoxColumn.Name = "iD1DataGridViewTextBoxColumn";
            // 
            // tenNV1DataGridViewTextBoxColumn
            // 
            this.tenNV1DataGridViewTextBoxColumn.DataPropertyName = "TenNV1";
            this.tenNV1DataGridViewTextBoxColumn.HeaderText = "Tên NV";
            this.tenNV1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNV1DataGridViewTextBoxColumn.Name = "tenNV1DataGridViewTextBoxColumn";
            // 
            // ngayVaoLam1DataGridViewTextBoxColumn
            // 
            this.ngayVaoLam1DataGridViewTextBoxColumn.DataPropertyName = "NgayVaoLam1";
            this.ngayVaoLam1DataGridViewTextBoxColumn.HeaderText = "Ngày vào làm";
            this.ngayVaoLam1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayVaoLam1DataGridViewTextBoxColumn.Name = "ngayVaoLam1DataGridViewTextBoxColumn";
            // 
            // sDT1DataGridViewTextBoxColumn
            // 
            this.sDT1DataGridViewTextBoxColumn.DataPropertyName = "SDT1";
            this.sDT1DataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDT1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDT1DataGridViewTextBoxColumn.Name = "sDT1DataGridViewTextBoxColumn";
            // 
            // diachi1DataGridViewTextBoxColumn
            // 
            this.diachi1DataGridViewTextBoxColumn.DataPropertyName = "Diachi1";
            this.diachi1DataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diachi1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diachi1DataGridViewTextBoxColumn.Name = "diachi1DataGridViewTextBoxColumn";
            // 
            // hinhAnh1DataGridViewTextBoxColumn
            // 
            this.hinhAnh1DataGridViewTextBoxColumn.DataPropertyName = "HinhAnh1";
            this.hinhAnh1DataGridViewTextBoxColumn.HeaderText = "Hình ảnh";
            this.hinhAnh1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hinhAnh1DataGridViewTextBoxColumn.Name = "hinhAnh1DataGridViewTextBoxColumn";
            // 
            // chucVu1DataGridViewTextBoxColumn
            // 
            this.chucVu1DataGridViewTextBoxColumn.DataPropertyName = "ChucVu1";
            this.chucVu1DataGridViewTextBoxColumn.HeaderText = "Chức vụ";
            this.chucVu1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chucVu1DataGridViewTextBoxColumn.Name = "chucVu1DataGridViewTextBoxColumn";
            // 
            // nhanVienDTOBindingSource2
            // 
            this.nhanVienDTOBindingSource2.DataSource = typeof(DTO.NhanVienDTO);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(239, 77);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(83, 20);
            this.lbTenNV.TabIndex = 44;
            this.lbTenNV.Text = "Tên NV :";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(239, 117);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(57, 20);
            this.lbSDT.TabIndex = 46;
            this.lbSDT.Text = "SĐT :";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(390, 77);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(162, 22);
            this.txtTenNV.TabIndex = 48;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(390, 117);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(162, 22);
            this.txtSDT.TabIndex = 49;
            // 
            // lbNgayVaoLam
            // 
            this.lbNgayVaoLam.AutoSize = true;
            this.lbNgayVaoLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayVaoLam.Location = new System.Drawing.Point(239, 165);
            this.lbNgayVaoLam.Name = "lbNgayVaoLam";
            this.lbNgayVaoLam.Size = new System.Drawing.Size(134, 20);
            this.lbNgayVaoLam.TabIndex = 50;
            this.lbNgayVaoLam.Text = "Ngày vào làm :";
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.Enabled = false;
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(390, 163);
            this.dtpNgayVaoLam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(162, 22);
            this.dtpNgayVaoLam.TabIndex = 52;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 16;
            this.comboBox1.Location = new System.Drawing.Point(15, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnThemNV);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.dgvNhanVien);
            this.panel2.Controls.Add(this.btn_TimKiem);
            this.panel2.Controls.Add(this.txt_TimKiem);
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 529);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::GUI.Properties.Resources.icons8_update_left_rotation_50;
            this.button1.Location = new System.Drawing.Point(993, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 58);
            this.button1.TabIndex = 65;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 11);
            this.button2.TabIndex = 64;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.Image = global::GUI.Properties.Resources.icons8_delete_bin_50;
            this.btnXoa.Location = new System.Drawing.Point(812, 422);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 56);
            this.btnXoa.TabIndex = 63;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI.Properties.Resources.icons8_save_64;
            this.btnLuu.Location = new System.Drawing.Point(900, 420);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(74, 58);
            this.btnLuu.TabIndex = 62;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.Image = global::GUI.Properties.Resources.icons8_add_64;
            this.btnThemNV.Location = new System.Drawing.Point(714, 422);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(78, 56);
            this.btnThemNV.TabIndex = 59;
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboChucVu);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnBrowser);
            this.panel3.Controls.Add(this.txtDiaChi);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtMaNV);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTenNV);
            this.panel3.Controls.Add(this.lbSDT);
            this.panel3.Controls.Add(this.pic);
            this.panel3.Controls.Add(this.txtSDT);
            this.panel3.Controls.Add(this.lbNgayVaoLam);
            this.panel3.Controls.Add(this.lbTenNV);
            this.panel3.Controls.Add(this.dtpNgayVaoLam);
            this.panel3.Location = new System.Drawing.Point(620, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 375);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Items.AddRange(new object[] {
            "Chủ",
            "Bán hàng",
            "Admin"});
            this.cboChucVu.Location = new System.Drawing.Point(390, 300);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(162, 24);
            this.cboChucVu.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Chức vụ:";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(64, 300);
            this.btnBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(120, 39);
            this.btnBrowser.TabIndex = 2;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(390, 195);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(162, 87);
            this.txtDiaChi.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Địa chỉ:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(390, 45);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(162, 22);
            this.txtMaNV.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Mã NV:";
            // 
            // pic
            // 
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic.Location = new System.Drawing.Point(34, 45);
            this.pic.Margin = new System.Windows.Forms.Padding(4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(178, 237);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 56;
            this.pic.TabStop = false;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.MistyRose;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TimKiem.Image = global::GUI.Properties.Resources.icons8_search_30;
            this.btn_TimKiem.Location = new System.Drawing.Point(485, 29);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(87, 39);
            this.btn_TimKiem.TabIndex = 3;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // nhanVienDTOBindingSource1
            // 
            this.nhanVienDTOBindingSource1.DataSource = typeof(DTO.NhanVienDTO);
            // 
            // nhanVienDTOBindingSource
            // 
            this.nhanVienDTOBindingSource.DataSource = typeof(DTO.NhanVienDTO);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyNhanVien";
            this.Size = new System.Drawing.Size(1261, 618);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDTOBindingSource2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Tiltle;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lbNgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource nhanVienDTOBindingSource;
        private System.Windows.Forms.BindingSource nhanVienDTOBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iD1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayVaoLam1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhAnh1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVu1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nhanVienDTOBindingSource2;
    }
}
