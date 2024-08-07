namespace CNPM10_Laptop.UserForm
{
    partial class sp_user
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
            this.btnLoadMore = new System.Windows.Forms.Button();
            this.pnl_showsp = new System.Windows.Forms.Panel();
            this.btnThanhToanLuon = new System.Windows.Forms.Button();
            this.btnTang1 = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnGiam1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGioHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadMore
            // 
            this.btnLoadMore.Location = new System.Drawing.Point(1722, 814);
            this.btnLoadMore.Name = "btnLoadMore";
            this.btnLoadMore.Size = new System.Drawing.Size(90, 51);
            this.btnLoadMore.TabIndex = 93;
            this.btnLoadMore.Text = "More";
            this.btnLoadMore.UseVisualStyleBackColor = true;
            // 
            // pnl_showsp
            // 
            this.pnl_showsp.AutoScroll = true;
            this.pnl_showsp.Location = new System.Drawing.Point(12, 12);
            this.pnl_showsp.Name = "pnl_showsp";
            this.pnl_showsp.Size = new System.Drawing.Size(1668, 855);
            this.pnl_showsp.TabIndex = 92;
            // 
            // btnThanhToanLuon
            // 
            this.btnThanhToanLuon.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToanLuon.Location = new System.Drawing.Point(672, 799);
            this.btnThanhToanLuon.Name = "btnThanhToanLuon";
            this.btnThanhToanLuon.Size = new System.Drawing.Size(430, 67);
            this.btnThanhToanLuon.TabIndex = 91;
            this.btnThanhToanLuon.Text = "Thanh Toán";
            this.btnThanhToanLuon.UseVisualStyleBackColor = true;
            // 
            // btnTang1
            // 
            this.btnTang1.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTang1.Location = new System.Drawing.Point(564, 809);
            this.btnTang1.Name = "btnTang1";
            this.btnTang1.Size = new System.Drawing.Size(48, 56);
            this.btnTang1.TabIndex = 90;
            this.btnTang1.Text = "+";
            this.btnTang1.UseVisualStyleBackColor = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(408, 802);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(124, 56);
            this.txtSoLuong.TabIndex = 89;
            this.txtSoLuong.Text = "1";
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGiam1
            // 
            this.btnGiam1.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiam1.Location = new System.Drawing.Point(330, 804);
            this.btnGiam1.Name = "btnGiam1";
            this.btnGiam1.Size = new System.Drawing.Size(48, 56);
            this.btnGiam1.TabIndex = 88;
            this.btnGiam1.Text = "-";
            this.btnGiam1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 815);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 42);
            this.label7.TabIndex = 87;
            this.label7.Text = "Chọn số lượng:";
            // 
            // btnGioHang
            // 
            this.btnGioHang.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioHang.Location = new System.Drawing.Point(1162, 798);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(518, 69);
            this.btnGioHang.TabIndex = 86;
            this.btnGioHang.Text = "Thêm Vào Giỏ Hàng";
            this.btnGioHang.UseVisualStyleBackColor = true;
            // 
            // sp_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1841, 925);
            this.Controls.Add(this.btnLoadMore);
            this.Controls.Add(this.pnl_showsp);
            this.Controls.Add(this.btnThanhToanLuon);
            this.Controls.Add(this.btnTang1);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnGiam1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGioHang);
            this.Name = "sp_user";
            this.Text = "sp_user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadMore;
        private System.Windows.Forms.Panel pnl_showsp;
        private System.Windows.Forms.Button btnThanhToanLuon;
        private System.Windows.Forms.Button btnTang1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnGiam1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGioHang;
    }
}