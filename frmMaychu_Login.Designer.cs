namespace QL_Internet
{
    partial class frmMaychu_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaychu_Tk = new System.Windows.Forms.TextBox();
            this.txtMaychu_Mk = new System.Windows.Forms.TextBox();
            this.btnMaychu_Dangnhap = new System.Windows.Forms.Button();
            this.btnMaychu_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // txtMaychu_Tk
            // 
            this.txtMaychu_Tk.Location = new System.Drawing.Point(107, 28);
            this.txtMaychu_Tk.Name = "txtMaychu_Tk";
            this.txtMaychu_Tk.Size = new System.Drawing.Size(176, 20);
            this.txtMaychu_Tk.TabIndex = 2;
            this.txtMaychu_Tk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaychu_Tk_KeyPress);
            // 
            // txtMaychu_Mk
            // 
            this.txtMaychu_Mk.Location = new System.Drawing.Point(107, 67);
            this.txtMaychu_Mk.Name = "txtMaychu_Mk";
            this.txtMaychu_Mk.Size = new System.Drawing.Size(176, 20);
            this.txtMaychu_Mk.TabIndex = 3;
            this.txtMaychu_Mk.UseSystemPasswordChar = true;
            this.txtMaychu_Mk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaychu_Mk_KeyPress);
            // 
            // btnMaychu_Dangnhap
            // 
            this.btnMaychu_Dangnhap.Location = new System.Drawing.Point(107, 114);
            this.btnMaychu_Dangnhap.Name = "btnMaychu_Dangnhap";
            this.btnMaychu_Dangnhap.Size = new System.Drawing.Size(82, 23);
            this.btnMaychu_Dangnhap.TabIndex = 4;
            this.btnMaychu_Dangnhap.Text = "Đăng nhập";
            this.btnMaychu_Dangnhap.UseVisualStyleBackColor = true;
            this.btnMaychu_Dangnhap.Click += new System.EventHandler(this.btnMaychu_Dangnhap_Click);
            // 
            // btnMaychu_Thoat
            // 
            this.btnMaychu_Thoat.Location = new System.Drawing.Point(208, 114);
            this.btnMaychu_Thoat.Name = "btnMaychu_Thoat";
            this.btnMaychu_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btnMaychu_Thoat.TabIndex = 5;
            this.btnMaychu_Thoat.Text = "Thoát";
            this.btnMaychu_Thoat.UseVisualStyleBackColor = true;
            this.btnMaychu_Thoat.Click += new System.EventHandler(this.btnMaychu_Thoat_Click);
            // 
            // frmMaychu_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 155);
            this.Controls.Add(this.btnMaychu_Thoat);
            this.Controls.Add(this.btnMaychu_Dangnhap);
            this.Controls.Add(this.txtMaychu_Mk);
            this.Controls.Add(this.txtMaychu_Tk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMaychu_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập máy chủ";
            this.Load += new System.EventHandler(this.frmMaychu_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaychu_Tk;
        private System.Windows.Forms.TextBox txtMaychu_Mk;
        private System.Windows.Forms.Button btnMaychu_Dangnhap;
        private System.Windows.Forms.Button btnMaychu_Thoat;
    }
}