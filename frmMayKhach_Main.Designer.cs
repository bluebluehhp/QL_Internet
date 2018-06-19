namespace QL_Internet
{
    partial class frmMayKhach_Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMayKhach_Dichvu = new System.Windows.Forms.Panel();
            this.btnMayKhachMain_Huy = new System.Windows.Forms.Button();
            this.listView_MayKhach_Bill = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMayKhachMain_DatHang = new System.Windows.Forms.Button();
            this.btnMayKhachMain_OK = new System.Windows.Forms.Button();
            this.txtMayKhachMain_Tongtien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMayKhachMain_Soluong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbMayKhachMain_Tendoan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbMainKhach_TienGiochoi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbMainKhach_TienDichvu = new System.Windows.Forms.Label();
            this.lbMainKhach_TimeSudung = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMainKhach_TimeEnd = new System.Windows.Forms.Label();
            this.btnMayKhach_Dangxuat = new System.Windows.Forms.Button();
            this.lbMainKhach_Tentaikhoan = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panelMayKhach_Dichvu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMayKhach_Dichvu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lbMainKhach_TienGiochoi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbMainKhach_TienDichvu);
            this.panel1.Controls.Add(this.lbMainKhach_TimeSudung);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbMainKhach_TimeEnd);
            this.panel1.Controls.Add(this.btnMayKhach_Dangxuat);
            this.panel1.Controls.Add(this.lbMainKhach_Tentaikhoan);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 503);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelMayKhach_Dichvu
            // 
            this.panelMayKhach_Dichvu.Controls.Add(this.btnMayKhachMain_Huy);
            this.panelMayKhach_Dichvu.Controls.Add(this.listView_MayKhach_Bill);
            this.panelMayKhach_Dichvu.Controls.Add(this.btnMayKhachMain_DatHang);
            this.panelMayKhach_Dichvu.Controls.Add(this.btnMayKhachMain_OK);
            this.panelMayKhach_Dichvu.Controls.Add(this.txtMayKhachMain_Tongtien);
            this.panelMayKhach_Dichvu.Controls.Add(this.label9);
            this.panelMayKhach_Dichvu.Controls.Add(this.txtMayKhachMain_Soluong);
            this.panelMayKhach_Dichvu.Controls.Add(this.label8);
            this.panelMayKhach_Dichvu.Controls.Add(this.cbbMayKhachMain_Tendoan);
            this.panelMayKhach_Dichvu.Controls.Add(this.label7);
            this.panelMayKhach_Dichvu.Location = new System.Drawing.Point(3, 248);
            this.panelMayKhach_Dichvu.Name = "panelMayKhach_Dichvu";
            this.panelMayKhach_Dichvu.Size = new System.Drawing.Size(243, 252);
            this.panelMayKhach_Dichvu.TabIndex = 29;
            // 
            // btnMayKhachMain_Huy
            // 
            this.btnMayKhachMain_Huy.Location = new System.Drawing.Point(181, 45);
            this.btnMayKhachMain_Huy.Name = "btnMayKhachMain_Huy";
            this.btnMayKhachMain_Huy.Size = new System.Drawing.Size(50, 20);
            this.btnMayKhachMain_Huy.TabIndex = 31;
            this.btnMayKhachMain_Huy.Text = "Hủy";
            this.btnMayKhachMain_Huy.UseVisualStyleBackColor = true;
            this.btnMayKhachMain_Huy.Click += new System.EventHandler(this.btnMayKhachMain_Huy_Click);
            // 
            // listView_MayKhach_Bill
            // 
            this.listView_MayKhach_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2});
            this.listView_MayKhach_Bill.GridLines = true;
            this.listView_MayKhach_Bill.HideSelection = false;
            this.listView_MayKhach_Bill.Location = new System.Drawing.Point(3, 80);
            this.listView_MayKhach_Bill.Name = "listView_MayKhach_Bill";
            this.listView_MayKhach_Bill.Size = new System.Drawing.Size(237, 116);
            this.listView_MayKhach_Bill.TabIndex = 10;
            this.listView_MayKhach_Bill.UseCompatibleStateImageBehavior = false;
            this.listView_MayKhach_Bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên đồ ăn";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Đơn giá";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SL";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thành tiền";
            this.columnHeader2.Width = 72;
            // 
            // btnMayKhachMain_DatHang
            // 
            this.btnMayKhachMain_DatHang.Location = new System.Drawing.Point(171, 207);
            this.btnMayKhachMain_DatHang.Name = "btnMayKhachMain_DatHang";
            this.btnMayKhachMain_DatHang.Size = new System.Drawing.Size(72, 32);
            this.btnMayKhachMain_DatHang.TabIndex = 30;
            this.btnMayKhachMain_DatHang.Text = "Đặt hàng";
            this.btnMayKhachMain_DatHang.UseVisualStyleBackColor = true;
            this.btnMayKhachMain_DatHang.Click += new System.EventHandler(this.btnMayKhachMain_DatHang_Click);
            // 
            // btnMayKhachMain_OK
            // 
            this.btnMayKhachMain_OK.Location = new System.Drawing.Point(120, 45);
            this.btnMayKhachMain_OK.Name = "btnMayKhachMain_OK";
            this.btnMayKhachMain_OK.Size = new System.Drawing.Size(55, 20);
            this.btnMayKhachMain_OK.TabIndex = 29;
            this.btnMayKhachMain_OK.Text = "OK";
            this.btnMayKhachMain_OK.UseVisualStyleBackColor = true;
            this.btnMayKhachMain_OK.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtMayKhachMain_Tongtien
            // 
            this.txtMayKhachMain_Tongtien.Location = new System.Drawing.Point(58, 215);
            this.txtMayKhachMain_Tongtien.Name = "txtMayKhachMain_Tongtien";
            this.txtMayKhachMain_Tongtien.Size = new System.Drawing.Size(107, 20);
            this.txtMayKhachMain_Tongtien.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tổng tiền";
            // 
            // txtMayKhachMain_Soluong
            // 
            this.txtMayKhachMain_Soluong.Location = new System.Drawing.Point(63, 45);
            this.txtMayKhachMain_Soluong.Name = "txtMayKhachMain_Soluong";
            this.txtMayKhachMain_Soluong.Size = new System.Drawing.Size(51, 20);
            this.txtMayKhachMain_Soluong.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số lượng";
            // 
            // cbbMayKhachMain_Tendoan
            // 
            this.cbbMayKhachMain_Tendoan.FormattingEnabled = true;
            this.cbbMayKhachMain_Tendoan.Location = new System.Drawing.Point(58, 10);
            this.cbbMayKhachMain_Tendoan.Name = "cbbMayKhachMain_Tendoan";
            this.cbbMayKhachMain_Tendoan.Size = new System.Drawing.Size(126, 21);
            this.cbbMayKhachMain_Tendoan.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên đồ ăn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Chi phi giờ chơi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "Dịch vụ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbMainKhach_TienGiochoi
            // 
            this.lbMainKhach_TienGiochoi.AutoSize = true;
            this.lbMainKhach_TienGiochoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainKhach_TienGiochoi.Location = new System.Drawing.Point(116, 109);
            this.lbMainKhach_TienGiochoi.Name = "lbMainKhach_TienGiochoi";
            this.lbMainKhach_TienGiochoi.Size = new System.Drawing.Size(32, 13);
            this.lbMainKhach_TienGiochoi.TabIndex = 24;
            this.lbMainKhach_TienGiochoi.Text = "Tiền";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 44);
            this.button1.TabIndex = 27;
            this.button1.Text = "Mật  Khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbMainKhach_TienDichvu
            // 
            this.lbMainKhach_TienDichvu.AutoSize = true;
            this.lbMainKhach_TienDichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainKhach_TienDichvu.Location = new System.Drawing.Point(116, 145);
            this.lbMainKhach_TienDichvu.Name = "lbMainKhach_TienDichvu";
            this.lbMainKhach_TienDichvu.Size = new System.Drawing.Size(32, 13);
            this.lbMainKhach_TienDichvu.TabIndex = 26;
            this.lbMainKhach_TienDichvu.Text = "Tiền";
            // 
            // lbMainKhach_TimeSudung
            // 
            this.lbMainKhach_TimeSudung.AutoSize = true;
            this.lbMainKhach_TimeSudung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainKhach_TimeSudung.Location = new System.Drawing.Point(116, 36);
            this.lbMainKhach_TimeSudung.Name = "lbMainKhach_TimeSudung";
            this.lbMainKhach_TimeSudung.Size = new System.Drawing.Size(34, 13);
            this.lbMainKhach_TimeSudung.TabIndex = 22;
            this.lbMainKhach_TimeSudung.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Chi phi dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Thời gian sử dụng";
            // 
            // lbMainKhach_TimeEnd
            // 
            this.lbMainKhach_TimeEnd.AutoSize = true;
            this.lbMainKhach_TimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainKhach_TimeEnd.Location = new System.Drawing.Point(116, 71);
            this.lbMainKhach_TimeEnd.Name = "lbMainKhach_TimeEnd";
            this.lbMainKhach_TimeEnd.Size = new System.Drawing.Size(34, 13);
            this.lbMainKhach_TimeEnd.TabIndex = 20;
            this.lbMainKhach_TimeEnd.Text = "Time";
            // 
            // btnMayKhach_Dangxuat
            // 
            this.btnMayKhach_Dangxuat.Location = new System.Drawing.Point(6, 183);
            this.btnMayKhach_Dangxuat.Name = "btnMayKhach_Dangxuat";
            this.btnMayKhach_Dangxuat.Size = new System.Drawing.Size(64, 44);
            this.btnMayKhach_Dangxuat.TabIndex = 19;
            this.btnMayKhach_Dangxuat.Text = "Đăng xuất";
            this.btnMayKhach_Dangxuat.UseVisualStyleBackColor = true;
            this.btnMayKhach_Dangxuat.Click += new System.EventHandler(this.btnMayKhach_Dangxuat_Click);
            // 
            // lbMainKhach_Tentaikhoan
            // 
            this.lbMainKhach_Tentaikhoan.AutoSize = true;
            this.lbMainKhach_Tentaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainKhach_Tentaikhoan.Location = new System.Drawing.Point(116, 2);
            this.lbMainKhach_Tentaikhoan.Name = "lbMainKhach_Tentaikhoan";
            this.lbMainKhach_Tentaikhoan.Size = new System.Drawing.Size(83, 13);
            this.lbMainKhach_Tentaikhoan.TabIndex = 18;
            this.lbMainKhach_Tentaikhoan.Text = "TenTaiKhoan";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Thời gian còn lại";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Xin chào";
            // 
            // frmMayKhach_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 513);
            this.Controls.Add(this.panel1);
            this.Name = "frmMayKhach_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập thành công";
            this.Load += new System.EventHandler(this.frmMayKhach_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMayKhach_Dichvu.ResumeLayout(false);
            this.panelMayKhach_Dichvu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMainKhach_Tentaikhoan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnMayKhach_Dangxuat;
        private System.Windows.Forms.Label lbMainKhach_TimeEnd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbMainKhach_TienDichvu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbMainKhach_TienGiochoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMainKhach_TimeSudung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMayKhach_Dichvu;
        private System.Windows.Forms.Button btnMayKhachMain_DatHang;
        private System.Windows.Forms.Button btnMayKhachMain_OK;
        private System.Windows.Forms.TextBox txtMayKhachMain_Tongtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMayKhachMain_Soluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbMayKhachMain_Tendoan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView_MayKhach_Bill;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnMayKhachMain_Huy;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}