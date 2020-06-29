namespace GUI
{
    partial class QuanLyDoanhThu
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongQuyHienTai = new System.Windows.Forms.TextBox();
            this.txtDoanhThuThangNay = new System.Windows.Forms.TextBox();
            this.txtDoanhThuHomNay = new System.Windows.Forms.TextBox();
            this.lbTongQuy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDoanhThuHomNay = new System.Windows.Forms.Label();
            this.dgvNguyenLieuTrongKho = new System.Windows.Forms.DataGridView();
            this.tenNL1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguyenLieuDTOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSanPhamBanDuoc = new System.Windows.Forms.DataGridView();
            this.tenSP1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamGia1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanhThuDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panDanhThuContent = new System.Windows.Forms.Panel();
            this.nguyenLieuDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguyenLieuDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuTrongKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieuDTOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamBanDuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanhThuDTOBindingSource)).BeginInit();
            this.panDanhThuContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieuDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieuDTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.lb_Tiltle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 48);
            this.panel1.TabIndex = 12;
            // 
            // lb_Tiltle
            // 
            this.lb_Tiltle.AutoSize = true;
            this.lb_Tiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tiltle.ForeColor = System.Drawing.Color.Black;
            this.lb_Tiltle.Location = new System.Drawing.Point(409, 10);
            this.lb_Tiltle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Tiltle.Name = "lb_Tiltle";
            this.lb_Tiltle.Size = new System.Drawing.Size(211, 22);
            this.lb_Tiltle.TabIndex = 8;
            this.lb_Tiltle.Text = "QUẢN LÍ DOANH THU";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.txtChi);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTongQuyHienTai);
            this.panel3.Controls.Add(this.txtDoanhThuThangNay);
            this.panel3.Controls.Add(this.txtDoanhThuHomNay);
            this.panel3.Controls.Add(this.lbTongQuy);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblDoanhThuHomNay);
            this.panel3.Location = new System.Drawing.Point(634, 52);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 370);
            this.panel3.TabIndex = 22;
            // 
            // txtChi
            // 
            this.txtChi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChi.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtChi.Location = new System.Drawing.Point(59, 217);
            this.txtChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChi.Multiline = true;
            this.txtChi.Name = "txtChi";
            this.txtChi.ReadOnly = true;
            this.txtChi.Size = new System.Drawing.Size(169, 25);
            this.txtChi.TabIndex = 18;
            this.txtChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(98, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Chi hôm nay";
            // 
            // txtTongQuyHienTai
            // 
            this.txtTongQuyHienTai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTongQuyHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongQuyHienTai.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTongQuyHienTai.Location = new System.Drawing.Point(40, 306);
            this.txtTongQuyHienTai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTongQuyHienTai.Multiline = true;
            this.txtTongQuyHienTai.Name = "txtTongQuyHienTai";
            this.txtTongQuyHienTai.ReadOnly = true;
            this.txtTongQuyHienTai.Size = new System.Drawing.Size(200, 36);
            this.txtTongQuyHienTai.TabIndex = 16;
            this.txtTongQuyHienTai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoanhThuThangNay
            // 
            this.txtDoanhThuThangNay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDoanhThuThangNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThuThangNay.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtDoanhThuThangNay.Location = new System.Drawing.Point(59, 132);
            this.txtDoanhThuThangNay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDoanhThuThangNay.Multiline = true;
            this.txtDoanhThuThangNay.Name = "txtDoanhThuThangNay";
            this.txtDoanhThuThangNay.ReadOnly = true;
            this.txtDoanhThuThangNay.Size = new System.Drawing.Size(169, 24);
            this.txtDoanhThuThangNay.TabIndex = 15;
            this.txtDoanhThuThangNay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoanhThuHomNay
            // 
            this.txtDoanhThuHomNay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDoanhThuHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThuHomNay.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtDoanhThuHomNay.Location = new System.Drawing.Point(59, 46);
            this.txtDoanhThuHomNay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDoanhThuHomNay.Multiline = true;
            this.txtDoanhThuHomNay.Name = "txtDoanhThuHomNay";
            this.txtDoanhThuHomNay.ReadOnly = true;
            this.txtDoanhThuHomNay.Size = new System.Drawing.Size(169, 23);
            this.txtDoanhThuHomNay.TabIndex = 13;
            this.txtDoanhThuHomNay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTongQuy
            // 
            this.lbTongQuy.AutoSize = true;
            this.lbTongQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongQuy.ForeColor = System.Drawing.Color.Black;
            this.lbTongQuy.Location = new System.Drawing.Point(67, 273);
            this.lbTongQuy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTongQuy.Name = "lbTongQuy";
            this.lbTongQuy.Size = new System.Drawing.Size(173, 24);
            this.lbTongQuy.TabIndex = 12;
            this.lbTongQuy.Text = "Tổng quỹ hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Doanh thu tháng này";
            // 
            // lblDoanhThuHomNay
            // 
            this.lblDoanhThuHomNay.AutoSize = true;
            this.lblDoanhThuHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuHomNay.Location = new System.Drawing.Point(68, 16);
            this.lblDoanhThuHomNay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoanhThuHomNay.Name = "lblDoanhThuHomNay";
            this.lblDoanhThuHomNay.Size = new System.Drawing.Size(165, 20);
            this.lblDoanhThuHomNay.TabIndex = 9;
            this.lblDoanhThuHomNay.Text = "Doanh thu hôm nay";
            // 
            // dgvNguyenLieuTrongKho
            // 
            this.dgvNguyenLieuTrongKho.AutoGenerateColumns = false;
            this.dgvNguyenLieuTrongKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguyenLieuTrongKho.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNguyenLieuTrongKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieuTrongKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNL1DataGridViewTextBoxColumn,
            this.dVT1DataGridViewTextBoxColumn,
            this.donGia1DataGridViewTextBoxColumn});
            this.dgvNguyenLieuTrongKho.DataSource = this.nguyenLieuDTOBindingSource2;
            this.dgvNguyenLieuTrongKho.Location = new System.Drawing.Point(354, 52);
            this.dgvNguyenLieuTrongKho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNguyenLieuTrongKho.Name = "dgvNguyenLieuTrongKho";
            this.dgvNguyenLieuTrongKho.RowHeadersWidth = 51;
            this.dgvNguyenLieuTrongKho.RowTemplate.Height = 24;
            this.dgvNguyenLieuTrongKho.Size = new System.Drawing.Size(275, 370);
            this.dgvNguyenLieuTrongKho.TabIndex = 20;
            // 
            // tenNL1DataGridViewTextBoxColumn
            // 
            this.tenNL1DataGridViewTextBoxColumn.DataPropertyName = "TenNL1";
            this.tenNL1DataGridViewTextBoxColumn.HeaderText = "Tên NL";
            this.tenNL1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNL1DataGridViewTextBoxColumn.Name = "tenNL1DataGridViewTextBoxColumn";
            // 
            // dVT1DataGridViewTextBoxColumn
            // 
            this.dVT1DataGridViewTextBoxColumn.DataPropertyName = "DVT1";
            this.dVT1DataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.dVT1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dVT1DataGridViewTextBoxColumn.Name = "dVT1DataGridViewTextBoxColumn";
            // 
            // donGia1DataGridViewTextBoxColumn
            // 
            this.donGia1DataGridViewTextBoxColumn.DataPropertyName = "DonGia1";
            this.donGia1DataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGia1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGia1DataGridViewTextBoxColumn.Name = "donGia1DataGridViewTextBoxColumn";
            // 
            // nguyenLieuDTOBindingSource2
            // 
            this.nguyenLieuDTOBindingSource2.DataSource = typeof(DTO.NguyenLieuDTO);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nguyên liệu trong kho";
            // 
            // dgvSanPhamBanDuoc
            // 
            this.dgvSanPhamBanDuoc.AutoGenerateColumns = false;
            this.dgvSanPhamBanDuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPhamBanDuoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSanPhamBanDuoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSanPhamBanDuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPhamBanDuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenSP1DataGridViewTextBoxColumn,
            this.soLuong1DataGridViewTextBoxColumn,
            this.gia1DataGridViewTextBoxColumn,
            this.giamGia1DataGridViewTextBoxColumn,
            this.tongTien1DataGridViewTextBoxColumn});
            this.dgvSanPhamBanDuoc.DataSource = this.doanhThuDTOBindingSource;
            this.dgvSanPhamBanDuoc.Location = new System.Drawing.Point(20, 52);
            this.dgvSanPhamBanDuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSanPhamBanDuoc.Name = "dgvSanPhamBanDuoc";
            this.dgvSanPhamBanDuoc.RowHeadersWidth = 51;
            this.dgvSanPhamBanDuoc.RowTemplate.Height = 24;
            this.dgvSanPhamBanDuoc.Size = new System.Drawing.Size(330, 370);
            this.dgvSanPhamBanDuoc.TabIndex = 18;
            // 
            // tenSP1DataGridViewTextBoxColumn
            // 
            this.tenSP1DataGridViewTextBoxColumn.DataPropertyName = "TenSP1";
            this.tenSP1DataGridViewTextBoxColumn.HeaderText = "Tên Sản Phẩm";
            this.tenSP1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSP1DataGridViewTextBoxColumn.Name = "tenSP1DataGridViewTextBoxColumn";
            // 
            // soLuong1DataGridViewTextBoxColumn
            // 
            this.soLuong1DataGridViewTextBoxColumn.DataPropertyName = "SoLuong1";
            this.soLuong1DataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuong1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuong1DataGridViewTextBoxColumn.Name = "soLuong1DataGridViewTextBoxColumn";
            // 
            // gia1DataGridViewTextBoxColumn
            // 
            this.gia1DataGridViewTextBoxColumn.DataPropertyName = "Gia1";
            this.gia1DataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.gia1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gia1DataGridViewTextBoxColumn.Name = "gia1DataGridViewTextBoxColumn";
            // 
            // giamGia1DataGridViewTextBoxColumn
            // 
            this.giamGia1DataGridViewTextBoxColumn.DataPropertyName = "GiamGia1";
            this.giamGia1DataGridViewTextBoxColumn.HeaderText = "Giảm giá";
            this.giamGia1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giamGia1DataGridViewTextBoxColumn.Name = "giamGia1DataGridViewTextBoxColumn";
            // 
            // tongTien1DataGridViewTextBoxColumn
            // 
            this.tongTien1DataGridViewTextBoxColumn.DataPropertyName = "TongTien1";
            this.tongTien1DataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tongTien1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongTien1DataGridViewTextBoxColumn.Name = "tongTien1DataGridViewTextBoxColumn";
            // 
            // doanhThuDTOBindingSource
            // 
            this.doanhThuDTOBindingSource.DataSource = typeof(DTO.DoanhThuDTO);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sản phẩm bán được";
            // 
            // panDanhThuContent
            // 
            this.panDanhThuContent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panDanhThuContent.Controls.Add(this.label5);
            this.panDanhThuContent.Controls.Add(this.panel3);
            this.panDanhThuContent.Controls.Add(this.dgvSanPhamBanDuoc);
            this.panDanhThuContent.Controls.Add(this.label6);
            this.panDanhThuContent.Controls.Add(this.dgvNguyenLieuTrongKho);
            this.panDanhThuContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDanhThuContent.Location = new System.Drawing.Point(0, 48);
            this.panDanhThuContent.Name = "panDanhThuContent";
            this.panDanhThuContent.Size = new System.Drawing.Size(946, 454);
            this.panDanhThuContent.TabIndex = 13;
            this.panDanhThuContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panDanhThuContent_Paint);
            // 
            // nguyenLieuDTOBindingSource
            // 
            this.nguyenLieuDTOBindingSource.DataSource = typeof(DTO.NguyenLieuDTO);
            // 
            // nguyenLieuDTOBindingSource1
            // 
            this.nguyenLieuDTOBindingSource1.DataSource = typeof(DTO.NguyenLieuDTO);
            // 
            // QuanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panDanhThuContent);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyDoanhThu";
            this.Size = new System.Drawing.Size(946, 502);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuTrongKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieuDTOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamBanDuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanhThuDTOBindingSource)).EndInit();
            this.panDanhThuContent.ResumeLayout(false);
            this.panDanhThuContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieuDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieuDTOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Tiltle;
        private System.Windows.Forms.BindingSource doanhThuDTOBindingSource;
        private System.Windows.Forms.BindingSource nguyenLieuDTOBindingSource;
        private System.Windows.Forms.BindingSource nguyenLieuDTOBindingSource1;
        private System.Windows.Forms.BindingSource nguyenLieuDTOBindingSource2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongQuyHienTai;
        private System.Windows.Forms.TextBox txtDoanhThuThangNay;
        private System.Windows.Forms.TextBox txtDoanhThuHomNay;
        private System.Windows.Forms.Label lbTongQuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDoanhThuHomNay;
        private System.Windows.Forms.DataGridView dgvNguyenLieuTrongKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNL1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSanPhamBanDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamGia1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panDanhThuContent;
    }
}
