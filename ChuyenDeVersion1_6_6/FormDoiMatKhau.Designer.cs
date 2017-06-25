namespace ChuyenDeVersion1_6_6
{
    partial class FormDoiMatKhau
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMauKhauMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMauKhauCu = new System.Windows.Forms.TextBox();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(316, 97);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(207, 21);
            this.textBoxUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // buttonLuu
            // 
            this.buttonLuu.Location = new System.Drawing.Point(201, 239);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(124, 55);
            this.buttonLuu.TabIndex = 2;
            this.buttonLuu.Text = "Đổi Mật Khẩu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu Mới";
            // 
            // textBoxMauKhauMoi
            // 
            this.textBoxMauKhauMoi.Location = new System.Drawing.Point(316, 177);
            this.textBoxMauKhauMoi.Name = "textBoxMauKhauMoi";
            this.textBoxMauKhauMoi.Size = new System.Drawing.Size(207, 21);
            this.textBoxMauKhauMoi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật Khẩu Cũ";
            // 
            // textBoxMauKhauCu
            // 
            this.textBoxMauKhauCu.Location = new System.Drawing.Point(316, 136);
            this.textBoxMauKhauCu.Name = "textBoxMauKhauCu";
            this.textBoxMauKhauCu.Size = new System.Drawing.Size(207, 21);
            this.textBoxMauKhauCu.TabIndex = 5;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(379, 239);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(133, 55);
            this.buttonHuy.TabIndex = 7;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 392);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMauKhauCu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMauKhauMoi);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.FormDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMauKhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMauKhauCu;
        private System.Windows.Forms.Button buttonHuy;
    }
}