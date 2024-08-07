namespace CNPM10_Laptop.UserForm
{
    partial class ThanhToan_User
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
            this.btnCTHD = new System.Windows.Forms.Button();
            this.dgvThanhToan = new System.Windows.Forms.DataGridView();
            this.quayLai_lb = new System.Windows.Forms.Label();
            this.LSMH_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCTHD
            // 
            this.btnCTHD.Location = new System.Drawing.Point(1501, 135);
            this.btnCTHD.Name = "btnCTHD";
            this.btnCTHD.Size = new System.Drawing.Size(293, 56);
            this.btnCTHD.TabIndex = 84;
            this.btnCTHD.Text = "Chi Tiết Hóa Đơn";
            this.btnCTHD.UseVisualStyleBackColor = true;
            // 
            // dgvThanhToan
            // 
            this.dgvThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhToan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhToan.Location = new System.Drawing.Point(25, 135);
            this.dgvThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvThanhToan.Name = "dgvThanhToan";
            this.dgvThanhToan.RowHeadersWidth = 51;
            this.dgvThanhToan.RowTemplate.Height = 24;
            this.dgvThanhToan.Size = new System.Drawing.Size(1444, 696);
            this.dgvThanhToan.TabIndex = 83;
            // 
            // quayLai_lb
            // 
            this.quayLai_lb.AutoSize = true;
            this.quayLai_lb.Font = new System.Drawing.Font("Consolas", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quayLai_lb.Location = new System.Drawing.Point(1495, 780);
            this.quayLai_lb.Name = "quayLai_lb";
            this.quayLai_lb.Size = new System.Drawing.Size(269, 32);
            this.quayLai_lb.TabIndex = 82;
            this.quayLai_lb.Text = "Quay lại giỏ hàng";
            // 
            // LSMH_lb
            // 
            this.LSMH_lb.AutoSize = true;
            this.LSMH_lb.Font = new System.Drawing.Font("Consolas", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSMH_lb.Location = new System.Drawing.Point(19, 59);
            this.LSMH_lb.Name = "LSMH_lb";
            this.LSMH_lb.Size = new System.Drawing.Size(254, 32);
            this.LSMH_lb.TabIndex = 81;
            this.LSMH_lb.Text = "Lịch sử mua hàng";
            // 
            // ThanhToan_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 896);
            this.Controls.Add(this.btnCTHD);
            this.Controls.Add(this.dgvThanhToan);
            this.Controls.Add(this.quayLai_lb);
            this.Controls.Add(this.LSMH_lb);
            this.Name = "ThanhToan_User";
            this.Text = "ThanhToan_User";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCTHD;
        private System.Windows.Forms.DataGridView dgvThanhToan;
        private System.Windows.Forms.Label quayLai_lb;
        private System.Windows.Forms.Label LSMH_lb;
    }
}