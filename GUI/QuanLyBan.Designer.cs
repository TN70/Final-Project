namespace GUI
{
    partial class QuanLyBan
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
            this.tableDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Tiltle = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoGhe = new System.Windows.Forms.TextBox();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBan = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tableDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableDTOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cboBan = new System.Windows.Forms.ComboBox();
            this.tableDTOBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.iTinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTrangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoGheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvQLBan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableDTOBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.cboTrangThai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDTOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDTOBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLBan)).BeginInit();
            this.SuspendLayout();
            // 
            // tableDTOBindingSource1
            // 
            this.tableDTOBindingSource1.DataSource = typeof(DTO.TableDTO);
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
            this.panel1.TabIndex = 12;
            // 
            // lb_Tiltle
            // 
            this.lb_Tiltle.AutoSize = true;
            this.lb_Tiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tiltle.ForeColor = System.Drawing.Color.Black;
            this.lb_Tiltle.Location = new System.Drawing.Point(515, 13);
            this.lb_Tiltle.Name = "lb_Tiltle";
            this.lb_Tiltle.Size = new System.Drawing.Size(173, 26);
            this.lb_Tiltle.TabIndex = 0;
            this.lb_Tiltle.Text = "QUẢN LÝ BÀN";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Controls.Add(this.btnLamMoi);
            this.cboTrangThai.Controls.Add(this.comboBox2);
            this.cboTrangThai.Controls.Add(this.cboTinhTrang);
            this.cboTrangThai.Controls.Add(this.label4);
            this.cboTrangThai.Controls.Add(this.btnCapNhat);
            this.cboTrangThai.Controls.Add(this.btnThem);
            this.cboTrangThai.Controls.Add(this.txtSoGhe);
            this.cboTrangThai.Controls.Add(this.txtMaBan);
            this.cboTrangThai.Controls.Add(this.label3);
            this.cboTrangThai.Controls.Add(this.label2);
            this.cboTrangThai.Controls.Add(this.label1);
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.Location = new System.Drawing.Point(621, 138);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(626, 464);
            this.cboTrangThai.TabIndex = 13;
            this.cboTrangThai.TabStop = false;
            this.cboTrangThai.Text = "Thông tin bàn";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLamMoi.Image = global::GUI.Properties.Resources.icons8_update_left_rotation_50;
            this.btnLamMoi.Location = new System.Drawing.Point(482, 348);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 70);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Dùng được"});
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Đang phục vụ",
            "Trống"});
            this.comboBox2.Location = new System.Drawing.Point(313, 176);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(244, 37);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.Text = "Trống";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTinhTrang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Dùng được",
            "Không dùng được"});
            this.cboTinhTrang.Location = new System.Drawing.Point(313, 237);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(244, 37);
            this.cboTinhTrang.TabIndex = 10;
            this.cboTinhTrang.Text = "Dùng được";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tình trạng :";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCapNhat.Image = global::GUI.Properties.Resources.icons8_save_64;
            this.btnCapNhat.Location = new System.Drawing.Point(361, 348);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(79, 70);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThem.Image = global::GUI.Properties.Resources.icons8_add_64;
            this.btnThem.Location = new System.Drawing.Point(222, 348);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 70);
            this.btnThem.TabIndex = 6;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoGhe
            // 
            this.txtSoGhe.Location = new System.Drawing.Point(313, 118);
            this.txtSoGhe.Name = "txtSoGhe";
            this.txtSoGhe.Size = new System.Drawing.Size(244, 34);
            this.txtSoGhe.TabIndex = 4;
            // 
            // txtMaBan
            // 
            this.txtMaBan.Location = new System.Drawing.Point(313, 65);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.ReadOnly = true;
            this.txtMaBan.Size = new System.Drawing.Size(244, 34);
            this.txtMaBan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số ghế :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Bàn:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBan
            // 
            this.txtBan.Location = new System.Drawing.Point(283, 95);
            this.txtBan.Name = "txtBan";
            this.txtBan.Size = new System.Drawing.Size(209, 22);
            this.txtBan.TabIndex = 15;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnTimKiem.Image = global::GUI.Properties.Resources.icons8_search_30;
            this.btnTimKiem.Location = new System.Drawing.Point(498, 88);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(87, 37);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tableDTOBindingSource
            // 
            this.tableDTOBindingSource.DataSource = typeof(DTO.TableDTO);
            // 
            // tableDTOBindingSource2
            // 
            this.tableDTOBindingSource2.DataSource = typeof(DTO.TableDTO);
            // 
            // cboBan
            // 
            this.cboBan.FormattingEnabled = true;
            this.cboBan.Items.AddRange(new object[] {
            "Mã bàn",
            "Số ghế",
            " Trạng thái",
            "Tình trạng"});
            this.cboBan.Location = new System.Drawing.Point(123, 95);
            this.cboBan.Name = "cboBan";
            this.cboBan.Size = new System.Drawing.Size(121, 24);
            this.cboBan.TabIndex = 17;
            // 
            // tableDTOBindingSource3
            // 
            this.tableDTOBindingSource3.DataSource = typeof(DTO.TableDTO);
            // 
            // iTinhTrangDataGridViewTextBoxColumn
            // 
            this.iTinhTrangDataGridViewTextBoxColumn.DataPropertyName = "ITinhTrang";
            this.iTinhTrangDataGridViewTextBoxColumn.HeaderText = "Tình trạng";
            this.iTinhTrangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iTinhTrangDataGridViewTextBoxColumn.Name = "iTinhTrangDataGridViewTextBoxColumn";
            this.iTinhTrangDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // iTrangThaiDataGridViewTextBoxColumn
            // 
            this.iTrangThaiDataGridViewTextBoxColumn.DataPropertyName = "ITrangThai";
            this.iTrangThaiDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.iTrangThaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iTrangThaiDataGridViewTextBoxColumn.Name = "iTrangThaiDataGridViewTextBoxColumn";
            this.iTrangThaiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // iSoGheDataGridViewTextBoxColumn
            // 
            this.iSoGheDataGridViewTextBoxColumn.DataPropertyName = "ISoGhe";
            this.iSoGheDataGridViewTextBoxColumn.HeaderText = "Số ghế";
            this.iSoGheDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSoGheDataGridViewTextBoxColumn.Name = "iSoGheDataGridViewTextBoxColumn";
            // 
            // iMaBanDataGridViewTextBoxColumn
            // 
            this.iMaBanDataGridViewTextBoxColumn.DataPropertyName = "IMaBan";
            this.iMaBanDataGridViewTextBoxColumn.HeaderText = "Mã bàn";
            this.iMaBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iMaBanDataGridViewTextBoxColumn.Name = "iMaBanDataGridViewTextBoxColumn";
            // 
            // dtgvQLBan
            // 
            this.dtgvQLBan.AutoGenerateColumns = false;
            this.dtgvQLBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvQLBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iMaBanDataGridViewTextBoxColumn,
            this.iSoGheDataGridViewTextBoxColumn,
            this.iTrangThaiDataGridViewTextBoxColumn,
            this.iTinhTrangDataGridViewTextBoxColumn});
            this.dtgvQLBan.DataSource = this.tableDTOBindingSource;
            this.dtgvQLBan.Location = new System.Drawing.Point(20, 138);
            this.dtgvQLBan.Name = "dtgvQLBan";
            this.dtgvQLBan.RowHeadersWidth = 51;
            this.dtgvQLBan.RowTemplate.Height = 24;
            this.dtgvQLBan.Size = new System.Drawing.Size(565, 464);
            this.dtgvQLBan.TabIndex = 0;
            this.dtgvQLBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQLBan_CellClick);
            // 
            // QuanLyBan
            // 
            this.Controls.Add(this.cboBan);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtBan);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvQLBan);
            this.Name = "QuanLyBan";
            this.Size = new System.Drawing.Size(1261, 618);
            this.Load += new System.EventHandler(this.QuanLyBan_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tableDTOBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cboTrangThai.ResumeLayout(false);
            this.cboTrangThai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDTOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDTOBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Tiltle;
        private System.Windows.Forms.GroupBox cboTrangThai;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoGhe;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.BindingSource tableDTOBindingSource;
        private System.Windows.Forms.BindingSource tableDTOBindingSource1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource tableDTOBindingSource2;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cboBan;
        private System.Windows.Forms.BindingSource tableDTOBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTrangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoGheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dtgvQLBan;
    }
}
