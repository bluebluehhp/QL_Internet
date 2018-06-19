namespace QL_Internet
{
    partial class frmMayKhach_Login
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
            this.btnMaykhach_Thoat = new System.Windows.Forms.Button();
            this.btnMaykhach_Dangnhap = new System.Windows.Forms.Button();
            this.txtMaykhach_Mk = new System.Windows.Forms.TextBox();
            this.txtMaykhach_Tk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMaykhach_Thoat
            // 
            this.btnMaykhach_Thoat.Location = new System.Drawing.Point(201, 116);
            this.btnMaykhach_Thoat.Name = "btnMaykhach_Thoat";
            this.btnMaykhach_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btnMaykhach_Thoat.TabIndex = 11;
            this.btnMaykhach_Thoat.Text = "Thoát";
            this.btnMaykhach_Thoat.UseVisualStyleBackColor = true;
            this.btnMaykhach_Thoat.Click += new System.EventHandler(this.btnMaykhach_Thoat_Click);
            // 
            // btnMaykhach_Dangnhap
            // 
            this.btnMaykhach_Dangnhap.Location = new System.Drawing.Point(100, 116);
            this.btnMaykhach_Dangnhap.Name = "btnMaykhach_Dangnhap";
            this.btnMaykhach_Dangnhap.Size = new System.Drawing.Size(82, 23);
            this.btnMaykhach_Dangnhap.TabIndex = 10;
            this.btnMaykhach_Dangnhap.Text = "Đăng nhập";
            this.btnMaykhach_Dangnhap.UseVisualStyleBackColor = true;
            this.btnMaykhach_Dangnhap.Click += new System.EventHandler(this.btnMaykhach_Dangnhap_Click);
            // 
            // txtMaykhach_Mk
            // 
            this.txtMaykhach_Mk.Location = new System.Drawing.Point(100, 69);
            this.txtMaykhach_Mk.Name = "txtMaykhach_Mk";
            this.txtMaykhach_Mk.Size = new System.Drawing.Size(176, 20);
            this.txtMaykhach_Mk.TabIndex = 9;
            this.txtMaykhach_Mk.UseSystemPasswordChar = true;
            this.txtMaykhach_Mk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaykhach_Mk_KeyPress);
            // 
            // txtMaykhach_Tk
            // 
            this.txtMaykhach_Tk.Location = new System.Drawing.Point(100, 30);
            this.txtMaykhach_Tk.Name = "txtMaykhach_Tk";
            this.txtMaykhach_Tk.Size = new System.Drawing.Size(176, 20);
            this.txtMaykhach_Tk.TabIndex = 8;
            this.txtMaykhach_Tk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaykhach_Tk_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tài khoản";
            // 
            // frmMayKhach_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 154);
            this.Controls.Add(this.btnMaykhach_Thoat);
            this.Controls.Add(this.btnMaykhach_Dangnhap);
            this.Controls.Add(this.txtMaykhach_Mk);
            this.Controls.Add(this.txtMaykhach_Tk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMayKhach_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập thành viên";
            this.Load += new System.EventHandler(this.frmMayKhach_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaykhach_Thoat;
        private System.Windows.Forms.Button btnMaykhach_Dangnhap;
        private System.Windows.Forms.TextBox txtMaykhach_Mk;
        private System.Windows.Forms.TextBox txtMaykhach_Tk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}