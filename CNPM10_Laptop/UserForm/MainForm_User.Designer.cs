namespace CNPM10_Laptop.UserForm
{
    partial class MainForm_User
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
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Logo_Pic = new System.Windows.Forms.PictureBox();
            this.logOut_btn = new System.Windows.Forms.Label();
            this.NavBar = new System.Windows.Forms.Panel();
            this.Role = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.GioHang_Pic = new System.Windows.Forms.PictureBox();
            this.IconTimKiem_Pic = new System.Windows.Forms.PictureBox();
            this.TimKiem_Text = new System.Windows.Forms.TextBox();
            this.lblDangXuat = new System.Windows.Forms.Label();
            this.IconDanhMuc_Pic = new System.Windows.Forms.PictureBox();
            this.DanhMuc_lb = new System.Windows.Forms.Label();
            this.TrangChu_btn = new System.Windows.Forms.Button();
            this.TaiKhoan_btn = new System.Windows.Forms.Button();
            this.SanPham_btn = new System.Windows.Forms.Button();
            this.GioHang_btn = new System.Windows.Forms.Button();
            this.vanChuyen_btn = new System.Windows.Forms.Button();
            this.TroGiup_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Pic)).BeginInit();
            this.NavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GioHang_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTimKiem_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconDanhMuc_Pic)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Main_Panel.Location = new System.Drawing.Point(256, 144);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1814, 873);
            this.Main_Panel.TabIndex = 7;
            // 
            // Logo_Pic
            // 
            this.Logo_Pic.BackColor = System.Drawing.Color.SteelBlue;
            this.Logo_Pic.Location = new System.Drawing.Point(44, 9);
            this.Logo_Pic.Name = "Logo_Pic";
            this.Logo_Pic.Size = new System.Drawing.Size(138, 98);
            this.Logo_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_Pic.TabIndex = 13;
            this.Logo_Pic.TabStop = false;
            this.Logo_Pic.Click += new System.EventHandler(this.Logo_Pic_Click);
            // 
            // logOut_btn
            // 
            this.logOut_btn.AutoSize = true;
            this.logOut_btn.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_btn.Location = new System.Drawing.Point(1639, 93);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(149, 32);
            this.logOut_btn.TabIndex = 7;
            this.logOut_btn.Text = "Đăng xuất";
            this.logOut_btn.Click += new System.EventHandler(this.logOut_btn_Click);
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NavBar.Controls.Add(this.Logo_Pic);
            this.NavBar.Controls.Add(this.logOut_btn);
            this.NavBar.Controls.Add(this.Role);
            this.NavBar.Controls.Add(this.Username);
            this.NavBar.Controls.Add(this.GioHang_Pic);
            this.NavBar.Controls.Add(this.IconTimKiem_Pic);
            this.NavBar.Controls.Add(this.TimKiem_Text);
            this.NavBar.Controls.Add(this.lblDangXuat);
            this.NavBar.Location = new System.Drawing.Point(12, 12);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(2068, 125);
            this.NavBar.TabIndex = 5;
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.Location = new System.Drawing.Point(1638, 45);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(74, 32);
            this.Role.TabIndex = 5;
            this.Role.Text = "Role";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(1638, 9);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(161, 37);
            this.Username.TabIndex = 4;
            this.Username.Text = "Username";
            // 
            // GioHang_Pic
            // 
            this.GioHang_Pic.BackColor = System.Drawing.Color.Transparent;
            this.GioHang_Pic.Location = new System.Drawing.Point(1944, 9);
            this.GioHang_Pic.Name = "GioHang_Pic";
            this.GioHang_Pic.Size = new System.Drawing.Size(98, 100);
            this.GioHang_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GioHang_Pic.TabIndex = 3;
            this.GioHang_Pic.TabStop = false;
            this.GioHang_Pic.Click += new System.EventHandler(this.GioHang_Pic_Click);
            // 
            // IconTimKiem_Pic
            // 
            this.IconTimKiem_Pic.BackColor = System.Drawing.Color.Transparent;
            this.IconTimKiem_Pic.Location = new System.Drawing.Point(1522, 33);
            this.IconTimKiem_Pic.Name = "IconTimKiem_Pic";
            this.IconTimKiem_Pic.Size = new System.Drawing.Size(76, 64);
            this.IconTimKiem_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconTimKiem_Pic.TabIndex = 2;
            this.IconTimKiem_Pic.TabStop = false;
            // 
            // TimKiem_Text
            // 
            this.TimKiem_Text.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem_Text.Location = new System.Drawing.Point(452, 33);
            this.TimKiem_Text.Multiline = true;
            this.TimKiem_Text.Name = "TimKiem_Text";
            this.TimKiem_Text.Size = new System.Drawing.Size(1033, 63);
            this.TimKiem_Text.TabIndex = 1;
            // 
            // lblDangXuat
            // 
            this.lblDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangXuat.Location = new System.Drawing.Point(2422, 131);
            this.lblDangXuat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDangXuat.Name = "lblDangXuat";
            this.lblDangXuat.Size = new System.Drawing.Size(399, 69);
            this.lblDangXuat.TabIndex = 12;
            this.lblDangXuat.Text = "Đăng Xuất";
            // 
            // IconDanhMuc_Pic
            // 
            this.IconDanhMuc_Pic.BackColor = System.Drawing.Color.Transparent;
            this.IconDanhMuc_Pic.Location = new System.Drawing.Point(3, 3);
            this.IconDanhMuc_Pic.Name = "IconDanhMuc_Pic";
            this.IconDanhMuc_Pic.Size = new System.Drawing.Size(58, 56);
            this.IconDanhMuc_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconDanhMuc_Pic.TabIndex = 6;
            this.IconDanhMuc_Pic.TabStop = false;
            // 
            // DanhMuc_lb
            // 
            this.DanhMuc_lb.AutoSize = true;
            this.DanhMuc_lb.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhMuc_lb.Location = new System.Drawing.Point(67, 0);
            this.DanhMuc_lb.Name = "DanhMuc_lb";
            this.DanhMuc_lb.Size = new System.Drawing.Size(161, 37);
            this.DanhMuc_lb.TabIndex = 6;
            this.DanhMuc_lb.Text = "Danh Mục";
            // 
            // TrangChu_btn
            // 
            this.TrangChu_btn.Location = new System.Drawing.Point(3, 65);
            this.TrangChu_btn.Name = "TrangChu_btn";
            this.TrangChu_btn.Size = new System.Drawing.Size(236, 64);
            this.TrangChu_btn.TabIndex = 12;
            this.TrangChu_btn.Text = "Trang chủ";
            this.TrangChu_btn.UseVisualStyleBackColor = true;
            this.TrangChu_btn.Click += new System.EventHandler(this.TrangChu_btn_Click);
            // 
            // TaiKhoan_btn
            // 
            this.TaiKhoan_btn.Location = new System.Drawing.Point(3, 135);
            this.TaiKhoan_btn.Name = "TaiKhoan_btn";
            this.TaiKhoan_btn.Size = new System.Drawing.Size(236, 64);
            this.TaiKhoan_btn.TabIndex = 7;
            this.TaiKhoan_btn.Text = "Tài khoản";
            this.TaiKhoan_btn.UseVisualStyleBackColor = true;
            this.TaiKhoan_btn.Click += new System.EventHandler(this.TaiKhoan_btn_Click);
            // 
            // SanPham_btn
            // 
            this.SanPham_btn.Location = new System.Drawing.Point(3, 205);
            this.SanPham_btn.Name = "SanPham_btn";
            this.SanPham_btn.Size = new System.Drawing.Size(236, 64);
            this.SanPham_btn.TabIndex = 8;
            this.SanPham_btn.Text = "Sản phẩm";
            this.SanPham_btn.UseVisualStyleBackColor = true;
            this.SanPham_btn.Click += new System.EventHandler(this.SanPham_btn_Click);
            // 
            // GioHang_btn
            // 
            this.GioHang_btn.Location = new System.Drawing.Point(3, 275);
            this.GioHang_btn.Name = "GioHang_btn";
            this.GioHang_btn.Size = new System.Drawing.Size(236, 64);
            this.GioHang_btn.TabIndex = 9;
            this.GioHang_btn.Text = "Giỏ hàng";
            this.GioHang_btn.UseVisualStyleBackColor = true;
            this.GioHang_btn.Click += new System.EventHandler(this.GioHang_btn_Click);
            // 
            // vanChuyen_btn
            // 
            this.vanChuyen_btn.Location = new System.Drawing.Point(3, 345);
            this.vanChuyen_btn.Name = "vanChuyen_btn";
            this.vanChuyen_btn.Size = new System.Drawing.Size(236, 64);
            this.vanChuyen_btn.TabIndex = 10;
            this.vanChuyen_btn.Text = "Vận chuyển";
            this.vanChuyen_btn.UseVisualStyleBackColor = true;
            this.vanChuyen_btn.Click += new System.EventHandler(this.vanChuyen_btn_Click);
            // 
            // TroGiup_btn
            // 
            this.TroGiup_btn.Location = new System.Drawing.Point(3, 415);
            this.TroGiup_btn.Name = "TroGiup_btn";
            this.TroGiup_btn.Size = new System.Drawing.Size(236, 64);
            this.TroGiup_btn.TabIndex = 11;
            this.TroGiup_btn.Text = "Trợ giúp";
            this.TroGiup_btn.UseVisualStyleBackColor = true;
            this.TroGiup_btn.Click += new System.EventHandler(this.TroGiup_btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel1.Controls.Add(this.IconDanhMuc_Pic);
            this.flowLayoutPanel1.Controls.Add(this.DanhMuc_lb);
            this.flowLayoutPanel1.Controls.Add(this.TrangChu_btn);
            this.flowLayoutPanel1.Controls.Add(this.TaiKhoan_btn);
            this.flowLayoutPanel1.Controls.Add(this.SanPham_btn);
            this.flowLayoutPanel1.Controls.Add(this.GioHang_btn);
            this.flowLayoutPanel1.Controls.Add(this.vanChuyen_btn);
            this.flowLayoutPanel1.Controls.Add(this.TroGiup_btn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 144);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(238, 895);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // MainForm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2082, 1036);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.NavBar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm_User";
            this.Text = "MainForm_User";
            this.Load += new System.EventHandler(this.MainForm_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Pic)).EndInit();
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GioHang_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconTimKiem_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconDanhMuc_Pic)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.PictureBox Logo_Pic;
        private System.Windows.Forms.Label logOut_btn;
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox GioHang_Pic;
        private System.Windows.Forms.PictureBox IconTimKiem_Pic;
        private System.Windows.Forms.TextBox TimKiem_Text;
        private System.Windows.Forms.Label lblDangXuat;
        private System.Windows.Forms.PictureBox IconDanhMuc_Pic;
        private System.Windows.Forms.Label DanhMuc_lb;
        private System.Windows.Forms.Button TrangChu_btn;
        private System.Windows.Forms.Button TaiKhoan_btn;
        private System.Windows.Forms.Button SanPham_btn;
        private System.Windows.Forms.Button GioHang_btn;
        private System.Windows.Forms.Button vanChuyen_btn;
        private System.Windows.Forms.Button TroGiup_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}