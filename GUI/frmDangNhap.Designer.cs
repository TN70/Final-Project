namespace GUI
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.grb_DangNhap = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.lb_TenDangNhap = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grb_DangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_DangNhap
            // 
            this.grb_DangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.grb_DangNhap.Controls.Add(this.btn_Thoat);
            this.grb_DangNhap.Controls.Add(this.btn_DangNhap);
            this.grb_DangNhap.Controls.Add(this.txtPassWord);
            this.grb_DangNhap.Controls.Add(this.txtName);
            this.grb_DangNhap.Controls.Add(this.lb_MatKhau);
            this.grb_DangNhap.Controls.Add(this.lb_TenDangNhap);
            this.grb_DangNhap.Location = new System.Drawing.Point(1, 192);
            this.grb_DangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_DangNhap.Name = "grb_DangNhap";
            this.grb_DangNhap.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_DangNhap.Size = new System.Drawing.Size(424, 158);
            this.grb_DangNhap.TabIndex = 5;
            this.grb_DangNhap.TabStop = false;
            this.grb_DangNhap.Enter += new System.EventHandler(this.grb_DangNhap_Enter);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Thoat.Location = new System.Drawing.Point(304, 115);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(68, 28);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_DangNhap.Location = new System.Drawing.Point(197, 115);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(76, 28);
            this.btn_DangNhap.TabIndex = 4;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(174, 75);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(135, 20);
            this.txtPassWord.TabIndex = 3;
            this.txtPassWord.Text = "123456";
            this.txtPassWord.UseWaitCursor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 35);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "minhhai";
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.AutoSize = true;
            this.lb_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhau.Location = new System.Drawing.Point(73, 72);
            this.lb_MatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(79, 20);
            this.lb_MatKhau.TabIndex = 1;
            this.lb_MatKhau.Text = "Mật khẩu:";
            // 
            // lb_TenDangNhap
            // 
            this.lb_TenDangNhap.AutoSize = true;
            this.lb_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDangNhap.Location = new System.Drawing.Point(34, 35);
            this.lb_TenDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TenDangNhap.Name = "lb_TenDangNhap";
            this.lb_TenDangNhap.Size = new System.Drawing.Size(120, 20);
            this.lb_TenDangNhap.TabIndex = 0;
            this.lb_TenDangNhap.Text = "Tên đăng nhập:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 187);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 348);
            this.Controls.Add(this.grb_DangNhap);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.grb_DangNhap.ResumeLayout(false);
            this.grb_DangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_DangNhap;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lb_MatKhau;
        private System.Windows.Forms.Label lb_TenDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}