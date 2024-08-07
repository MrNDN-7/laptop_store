namespace CNPM10_Laptop.UserForm
{
    partial class CTHD_User
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
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.dgvLSMH = new System.Windows.Forms.DataGridView();
            this.lb_giohang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSMH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.Location = new System.Drawing.Point(944, 437);
            this.lblHoaDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(103, 27);
            this.lblHoaDon.TabIndex = 57;
            this.lblHoaDon.Text = "Hóa đơn";
            this.lblHoaDon.Click += new System.EventHandler(this.lblHoaDon_Click);
            // 
            // dgvLSMH
            // 
            this.dgvLSMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSMH.Location = new System.Drawing.Point(36, 33);
            this.dgvLSMH.Name = "dgvLSMH";
            this.dgvLSMH.RowHeadersWidth = 51;
            this.dgvLSMH.RowTemplate.Height = 24;
            this.dgvLSMH.Size = new System.Drawing.Size(997, 391);
            this.dgvLSMH.TabIndex = 56;
            // 
            // lb_giohang
            // 
            this.lb_giohang.AutoSize = true;
            this.lb_giohang.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_giohang.Location = new System.Drawing.Point(42, 437);
            this.lb_giohang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_giohang.Name = "lb_giohang";
            this.lb_giohang.Size = new System.Drawing.Size(116, 27);
            this.lb_giohang.TabIndex = 55;
            this.lb_giohang.Text = "Giỏ hàng";
            this.lb_giohang.Click += new System.EventHandler(this.lb_giohang_Click);
            // 
            // CTHD_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 490);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.dgvLSMH);
            this.Controls.Add(this.lb_giohang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CTHD_User";
            this.Text = "CTHD_User";
            this.Load += new System.EventHandler(this.CTHD_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.DataGridView dgvLSMH;
        private System.Windows.Forms.Label lb_giohang;
    }
}