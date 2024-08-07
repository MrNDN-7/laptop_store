namespace CNPM10_Laptop.UserForm
{
    partial class ChangePassword_User
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword_User));
            this.matkhautrung = new System.Windows.Forms.Label();
            this.quayLai_lb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nhapmatkhau = new System.Windows.Forms.Label();
            this.seenpass_old = new System.Windows.Forms.PictureBox();
            this.seenpass_new = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSavePass = new System.Windows.Forms.Button();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.txtPassOld = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seenpass_hint = new System.Windows.Forms.PictureBox();
            this.txtPassHint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seenpass_old)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seenpass_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seenpass_hint)).BeginInit();
            this.SuspendLayout();
            // 
            // matkhautrung
            // 
            this.matkhautrung.AutoSize = true;
            this.matkhautrung.BackColor = System.Drawing.Color.Transparent;
            this.matkhautrung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhautrung.ForeColor = System.Drawing.Color.IndianRed;
            this.matkhautrung.Location = new System.Drawing.Point(567, 304);
            this.matkhautrung.Name = "matkhautrung";
            this.matkhautrung.Size = new System.Drawing.Size(237, 20);
            this.matkhautrung.TabIndex = 84;
            this.matkhautrung.Text = "Nhập mật khẩu mới trùng nhau";
            // 
            // quayLai_lb
            // 
            this.quayLai_lb.AutoSize = true;
            this.quayLai_lb.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quayLai_lb.Location = new System.Drawing.Point(959, 9);
            this.quayLai_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quayLai_lb.Name = "quayLai_lb";
            this.quayLai_lb.Size = new System.Drawing.Size(116, 27);
            this.quayLai_lb.TabIndex = 82;
            this.quayLai_lb.Text = "Quay lại";
            this.quayLai_lb.Click += new System.EventHandler(this.quayLai_lb_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nhapmatkhau
            // 
            this.nhapmatkhau.AutoSize = true;
            this.nhapmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.nhapmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapmatkhau.ForeColor = System.Drawing.Color.IndianRed;
            this.nhapmatkhau.Location = new System.Drawing.Point(567, 153);
            this.nhapmatkhau.Name = "nhapmatkhau";
            this.nhapmatkhau.Size = new System.Drawing.Size(224, 20);
            this.nhapmatkhau.TabIndex = 83;
            this.nhapmatkhau.Text = "Vui lòng nhập đúng mật khẩu";
            // 
            // seenpass_old
            // 
            this.seenpass_old.BackColor = System.Drawing.Color.White;
            this.seenpass_old.Image = ((System.Drawing.Image)(resources.GetObject("seenpass_old.Image")));
            this.seenpass_old.Location = new System.Drawing.Point(778, 103);
            this.seenpass_old.Margin = new System.Windows.Forms.Padding(2);
            this.seenpass_old.Name = "seenpass_old";
            this.seenpass_old.Size = new System.Drawing.Size(46, 34);
            this.seenpass_old.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seenpass_old.TabIndex = 78;
            this.seenpass_old.TabStop = false;
            this.seenpass_old.Visible = false;
            this.seenpass_old.Click += new System.EventHandler(this.seenpass_old_Click);
            // 
            // seenpass_new
            // 
            this.seenpass_new.BackColor = System.Drawing.Color.White;
            this.seenpass_new.Image = ((System.Drawing.Image)(resources.GetObject("seenpass_new.Image")));
            this.seenpass_new.Location = new System.Drawing.Point(778, 179);
            this.seenpass_new.Margin = new System.Windows.Forms.Padding(2);
            this.seenpass_new.Name = "seenpass_new";
            this.seenpass_new.Size = new System.Drawing.Size(46, 34);
            this.seenpass_new.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seenpass_new.TabIndex = 77;
            this.seenpass_new.TabStop = false;
            this.seenpass_new.Visible = false;
            this.seenpass_new.Click += new System.EventHandler(this.seenpass_new_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(567, 40);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(197, 34);
            this.txtUserName.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 74;
            this.label3.Text = "UserName:";
            // 
            // btnSavePass
            // 
            this.btnSavePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePass.Location = new System.Drawing.Point(321, 331);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.Size = new System.Drawing.Size(150, 45);
            this.btnSavePass.TabIndex = 73;
            this.btnSavePass.Text = "Save";
            this.btnSavePass.UseVisualStyleBackColor = true;
            this.btnSavePass.Click += new System.EventHandler(this.btnSavePass_Click);
            // 
            // txtPassNew
            // 
            this.txtPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNew.Location = new System.Drawing.Point(567, 179);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Size = new System.Drawing.Size(197, 34);
            this.txtPassNew.TabIndex = 72;
            this.txtPassNew.Click += new System.EventHandler(this.txtPassNew_Click);
            this.txtPassNew.TextChanged += new System.EventHandler(this.txtPassNew_TextChanged);
            // 
            // txtPassOld
            // 
            this.txtPassOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassOld.Location = new System.Drawing.Point(567, 103);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.Size = new System.Drawing.Size(197, 34);
            this.txtPassOld.TabIndex = 71;
            this.txtPassOld.Click += new System.EventHandler(this.txtPassOld_Click);
            this.txtPassOld.TextChanged += new System.EventHandler(this.txtPassOld_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 70;
            this.label2.Text = "Mật Khẩu Mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 69;
            this.label1.Text = "Mật Khẩu Cũ:";
            // 
            // seenpass_hint
            // 
            this.seenpass_hint.BackColor = System.Drawing.Color.White;
            this.seenpass_hint.Image = ((System.Drawing.Image)(resources.GetObject("seenpass_hint.Image")));
            this.seenpass_hint.Location = new System.Drawing.Point(778, 246);
            this.seenpass_hint.Margin = new System.Windows.Forms.Padding(2);
            this.seenpass_hint.Name = "seenpass_hint";
            this.seenpass_hint.Size = new System.Drawing.Size(46, 34);
            this.seenpass_hint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seenpass_hint.TabIndex = 81;
            this.seenpass_hint.TabStop = false;
            this.seenpass_hint.Visible = false;
            this.seenpass_hint.Click += new System.EventHandler(this.seenpass_hint_Click);
            // 
            // txtPassHint
            // 
            this.txtPassHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassHint.Location = new System.Drawing.Point(571, 246);
            this.txtPassHint.Name = "txtPassHint";
            this.txtPassHint.Size = new System.Drawing.Size(197, 34);
            this.txtPassHint.TabIndex = 80;
            this.txtPassHint.Click += new System.EventHandler(this.txtPassHint_Click);
            this.txtPassHint.TextChanged += new System.EventHandler(this.txtPassHint_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 29);
            this.label4.TabIndex = 79;
            this.label4.Text = "Nhập Lại Mật Khẩu:";
            // 
            // ChangePassword_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 414);
            this.Controls.Add(this.matkhautrung);
            this.Controls.Add(this.quayLai_lb);
            this.Controls.Add(this.nhapmatkhau);
            this.Controls.Add(this.seenpass_old);
            this.Controls.Add(this.seenpass_new);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSavePass);
            this.Controls.Add(this.txtPassNew);
            this.Controls.Add(this.txtPassOld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seenpass_hint);
            this.Controls.Add(this.txtPassHint);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangePassword_User";
            this.Text = "ChangePassword_User";
            this.Load += new System.EventHandler(this.ChangePassword_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seenpass_old)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seenpass_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seenpass_hint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matkhautrung;
        private System.Windows.Forms.Label quayLai_lb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label nhapmatkhau;
        private System.Windows.Forms.PictureBox seenpass_old;
        private System.Windows.Forms.PictureBox seenpass_new;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSavePass;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.TextBox txtPassOld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox seenpass_hint;
        private System.Windows.Forms.TextBox txtPassHint;
        private System.Windows.Forms.Label label4;
    }
}