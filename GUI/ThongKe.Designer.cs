namespace GUI
{
    partial class ThongKe
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
<<<<<<< HEAD
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTheoMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Tiltle = new System.Windows.Forms.Label();
=======
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTheoMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Tiltle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thToolStripMenuItem,
            this.thốngKêDoanhThuToolStripMenuItem,
            this.thốngKêTheoMónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1261, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thToolStripMenuItem
            // 
            this.thToolStripMenuItem.Name = "thToolStripMenuItem";
            this.thToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.thToolStripMenuItem.Text = "Thống kê Hóa đơn";
            this.thToolStripMenuItem.Click += new System.EventHandler(this.thToolStripMenuItem_Click);
=======
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêHóaĐơnToolStripMenuItem,
            this.thốngKêDoanhThuToolStripMenuItem,
            this.thốngKêNhậpHàngToolStripMenuItem,
            this.thốngKêTheoMónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêHóaĐơnToolStripMenuItem
            // 
            this.thốngKêHóaĐơnToolStripMenuItem.Name = "thốngKêHóaĐơnToolStripMenuItem";
            this.thốngKêHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.thốngKêHóaĐơnToolStripMenuItem.Text = "Thống kê Hóa Đơn";
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
            // 
            // thốngKêDoanhThuToolStripMenuItem
            // 
            this.thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
<<<<<<< HEAD
            this.thốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.thốngKêDoanhThuToolStripMenuItem.Text = "Thống kê Doanh Thu";
=======
            this.thốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.thốngKêDoanhThuToolStripMenuItem.Text = "Thống Kê Doanh Thu";
            // 
            // thốngKêNhậpHàngToolStripMenuItem
            // 
            this.thốngKêNhậpHàngToolStripMenuItem.Name = "thốngKêNhậpHàngToolStripMenuItem";
            this.thốngKêNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.thốngKêNhậpHàngToolStripMenuItem.Text = "Thống kê Nhập Hàng";
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
            // 
            // thốngKêTheoMónToolStripMenuItem
            // 
            this.thốngKêTheoMónToolStripMenuItem.Name = "thốngKêTheoMónToolStripMenuItem";
<<<<<<< HEAD
            this.thốngKêTheoMónToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
=======
            this.thốngKêTheoMónToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
            this.thốngKêTheoMónToolStripMenuItem.Text = "Thống kê Theo Món";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.lb_Tiltle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
<<<<<<< HEAD
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 57);
            this.panel1.TabIndex = 11;
=======
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 48);
            this.panel1.TabIndex = 17;
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
            // 
            // lb_Tiltle
            // 
            this.lb_Tiltle.AutoSize = true;
            this.lb_Tiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tiltle.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.lb_Tiltle.Location = new System.Drawing.Point(539, 15);
            this.lb_Tiltle.Name = "lb_Tiltle";
            this.lb_Tiltle.Size = new System.Drawing.Size(251, 26);
            this.lb_Tiltle.TabIndex = 8;
            this.lb_Tiltle.Text = "THỐNG KÊ HÓA ĐƠN";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(1261, 723);
=======
            this.lb_Tiltle.Location = new System.Drawing.Point(404, 12);
            this.lb_Tiltle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Tiltle.Name = "lb_Tiltle";
            this.lb_Tiltle.Size = new System.Drawing.Size(210, 22);
            this.lb_Tiltle.TabIndex = 8;
            this.lb_Tiltle.Text = "THỐNG KÊ HÓA ĐƠN";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 430);
            this.panel2.TabIndex = 18;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(946, 502);
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTheoMónToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Tiltle;
=======
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTheoMónToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Tiltle;
        private System.Windows.Forms.Panel panel2;
>>>>>>> 3559d59891222dee2850978d2a175a0865918ce2
    }
}
