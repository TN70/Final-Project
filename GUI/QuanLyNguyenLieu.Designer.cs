namespace GUI
{
    partial class QuanLyNguyenLieu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboBan = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_NguyenLieu = new System.Windows.Forms.DataGridView();
            this.tenNL1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLTon1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguyenLieuDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieuDTOBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 10;
            // 
            // lb_Tiltle
            // 
            this.lb_Tiltle.AutoSize = true;
            this.lb_Tiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tiltle.ForeColor = System.Drawing.Color.Black;
            this.lb_Tiltle.Location = new System.Drawing.Point(539, 15);
            this.lb_Tiltle.Name = "lb_Tiltle";
            this.lb_Tiltle.Size = new System.Drawing.Size(276, 26);
            this.lb_Tiltle.TabIndex = 8;
            this.lb_Tiltle.Text = "QUẢN LÍ NGUYÊN LIỆU";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.cboBan);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgv_NguyenLieu);
            this.panel2.Controls.Add(this.btn_TimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 561);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 22);
            this.textBox1.TabIndex = 13;
            // 
            // cboBan
            // 
            this.cboBan.FormattingEnabled = true;
            this.cboBan.Location = new System.Drawing.Point(138, 21);
            this.cboBan.Name = "cboBan";
            this.cboBan.Size = new System.Drawing.Size(121, 24);
            this.cboBan.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCapNhat);
            this.panel3.Controls.Add(this.btn_Xoa);
            this.panel3.Controls.Add(this.btn_Them);
            this.panel3.Controls.Add(this.txtDonGia);
            this.panel3.Controls.Add(this.txtDonViTinh);
            this.panel3.Controls.Add(this.txtTenNL);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtMaNL);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(656, 68);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 464);
            this.panel3.TabIndex = 11;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCapNhat.Image = global::GUI.Properties.Resources.icons8_update_left_rotation_50;
            this.btnCapNhat.Location = new System.Drawing.Point(222, 310);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(87, 61);
            this.btnCapNhat.TabIndex = 32;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Image = global::GUI.Properties.Resources.icons8_delete_bin_50;
            this.btn_Xoa.Location = new System.Drawing.Point(339, 310);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(84, 61);
            this.btn_Xoa.TabIndex = 31;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Goldenrod;
            this.btn_Them.Image = global::GUI.Properties.Resources.icons8_add_64;
            this.btn_Them.Location = new System.Drawing.Point(94, 310);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(88, 61);
            this.btn_Them.TabIndex = 30;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_LuuLai_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(177, 235);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(181, 37);
            this.txtDonGia.TabIndex = 29;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(177, 172);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonViTinh.Multiline = true;
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(181, 37);
            this.txtDonViTinh.TabIndex = 28;
            // 
            // txtTenNL
            // 
            this.txtTenNL.Location = new System.Drawing.Point(177, 116);
            this.txtTenNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNL.Multiline = true;
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(181, 37);
            this.txtTenNL.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Đơn giá :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Đơn vị tính :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên NL :";
            // 
            // txtMaNL
            // 
            this.txtMaNL.Location = new System.Drawing.Point(177, 71);
            this.txtMaNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNL.Multiline = true;
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(181, 30);
            this.txtMaNL.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã NL :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Thông tin nguyên liệu";
            // 
            // dgv_NguyenLieu
            // 
            this.dgv_NguyenLieu.AutoGenerateColumns = false;
            this.dgv_NguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NguyenLieu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_NguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNL1DataGridViewTextBoxColumn,
            this.dVT1DataGridViewTextBoxColumn,
            this.donGia1DataGridViewTextBoxColumn,
            this.sLTon1DataGridViewTextBoxColumn});
            this.dgv_NguyenLieu.DataSource = this.nguyenLieuDTOBindingSource;
            this.dgv_NguyenLieu.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_NguyenLieu.Location = new System.Drawing.Point(21, 68);
            this.dgv_NguyenLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_NguyenLieu.Name = "dgv_NguyenLieu";
            this.dgv_NguyenLieu.RowHeadersWidth = 51;
            this.dgv_NguyenLieu.RowTemplate.Height = 24;
            this.dgv_NguyenLieu.Size = new System.Drawing.Size(627, 464);
            this.dgv_NguyenLieu.TabIndex = 10;
            this.dgv_NguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NguyenLieu_CellClick);
            // 
            // tenNL1DataGridViewTextBoxColumn
            // 
            this.tenNL1DataGridViewTextBoxColumn.DataPropertyName = "TenNL1";
            this.tenNL1DataGridViewTextBoxColumn.HeaderText = "Tên Nguyên liệu";
            this.tenNL1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNL1DataGridViewTextBoxColumn.Name = "tenNL1DataGridViewTextBoxColumn";
            // 
            // dVT1DataGridViewTextBoxColumn
            // 
            this.dVT1DataGridViewTextBoxColumn.DataPropertyName = "DVT1";
            this.dVT1DataGridViewTextBoxColumn.FillWeight = 30F;
            this.dVT1DataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.dVT1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dVT1DataGridViewTextBoxColumn.Name = "dVT1DataGridViewTextBoxColumn";
            // 
            // donGia1DataGridViewTextBoxColumn
            // 
            this.donGia1DataGridViewTextBoxColumn.DataPropertyName = "DonGia1";
            this.donGia1DataGridViewTextBoxColumn.FillWeight = 30.0241F;
            this.donGia1DataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGia1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGia1DataGridViewTextBoxColumn.Name = "donGia1DataGridViewTextBoxColumn";
            // 
            // sLTon1DataGridViewTextBoxColumn
            // 
            this.sLTon1DataGridViewTextBoxColumn.DataPropertyName = "SLTon1";
            this.sLTon1DataGridViewTextBoxColumn.FillWeight = 40F;
            this.sLTon1DataGridViewTextBoxColumn.HeaderText = "Số lượng tồn";
            this.sLTon1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sLTon1DataGridViewTextBoxColumn.Name = "sLTon1DataGridViewTextBoxColumn";
            // 
            // nguyenLieuDTOBindingSource
            // 
            this.nguyenLieuDTOBindingSource.DataSource = typeof(DTO.NguyenLieuDTO);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TimKiem.Image = global::GUI.Properties.Resources.icons8_search_30;
            this.btn_TimKiem.Location = new System.Drawing.Point(544, 21);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(87, 43);
            this.btn_TimKiem.TabIndex = 9;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // QuanLyNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyNguyenLieu";
            this.Size = new System.Drawing.Size(1261, 618);
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieuDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Tiltle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_NguyenLieu;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNL1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLTon1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nguyenLieuDTOBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboBan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
