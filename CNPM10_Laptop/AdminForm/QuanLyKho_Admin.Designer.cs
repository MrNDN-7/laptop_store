namespace CNPM10_Laptop.AdminForm
{
    partial class QuanLyKho_Admin
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
            this.btnThemDN = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.DataKho = new System.Windows.Forms.DataGridView();
            this.cbKhoSele = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataKho)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemDN
            // 
            this.btnThemDN.BackColor = System.Drawing.Color.Orange;
            this.btnThemDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemDN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDN.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnThemDN.Location = new System.Drawing.Point(874, 23);
            this.btnThemDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemDN.Name = "btnThemDN";
            this.btnThemDN.Size = new System.Drawing.Size(266, 67);
            this.btnThemDN.TabIndex = 6;
            this.btnThemDN.Text = "Thêm Đơn Nhập";
            this.btnThemDN.UseVisualStyleBackColor = false;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.Orange;
            this.btnChiTiet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnChiTiet.Location = new System.Drawing.Point(1149, 100);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(220, 67);
            this.btnChiTiet.TabIndex = 7;
            this.btnChiTiet.Text = "XEM CHI TIẾT";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Visible = false;
            // 
            // DataKho
            // 
            this.DataKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataKho.Location = new System.Drawing.Point(30, 100);
            this.DataKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataKho.Name = "DataKho";
            this.DataKho.RowHeadersWidth = 51;
            this.DataKho.RowTemplate.Height = 24;
            this.DataKho.Size = new System.Drawing.Size(1110, 717);
            this.DataKho.TabIndex = 5;
            // 
            // cbKhoSele
            // 
            this.cbKhoSele.DisplayMember = "Sản Phẩm";
            this.cbKhoSele.FormattingEnabled = true;
            this.cbKhoSele.Items.AddRange(new object[] {
            "Sản Phẩm",
            "Đơn Nhập Hàng"});
            this.cbKhoSele.Location = new System.Drawing.Point(30, 33);
            this.cbKhoSele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbKhoSele.Name = "cbKhoSele";
            this.cbKhoSele.Size = new System.Drawing.Size(181, 33);
            this.cbKhoSele.TabIndex = 4;
            // 
            // QuanLyKho_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 866);
            this.Controls.Add(this.btnThemDN);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.DataKho);
            this.Controls.Add(this.cbKhoSele);
            this.Name = "QuanLyKho_Admin";
            this.Text = "QuanLyKho_Admin";
            ((System.ComponentModel.ISupportInitialize)(this.DataKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemDN;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.DataGridView DataKho;
        private System.Windows.Forms.ComboBox cbKhoSele;
    }
}