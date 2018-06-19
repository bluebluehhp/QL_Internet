namespace QL_Internet
{
    partial class BanggiaDichvu
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
            this.listViewThucdon = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBangGia_Tendoan = new System.Windows.Forms.TextBox();
            this.btnBangGia_Them = new System.Windows.Forms.Button();
            this.btnBangGia_Xoa = new System.Windows.Forms.Button();
            this.btnBangGia_Sua = new System.Windows.Forms.Button();
            this.txtBangGia_Dongia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewThucdon
            // 
            this.listViewThucdon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.listViewThucdon.GridLines = true;
            this.listViewThucdon.Location = new System.Drawing.Point(12, 91);
            this.listViewThucdon.Name = "listViewThucdon";
            this.listViewThucdon.Size = new System.Drawing.Size(538, 284);
            this.listViewThucdon.TabIndex = 0;
            this.listViewThucdon.UseCompatibleStateImageBehavior = false;
            this.listViewThucdon.View = System.Windows.Forms.View.Details;
            this.listViewThucdon.SelectedIndexChanged += new System.EventHandler(this.listViewThucdon_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã TD";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên thực đơn";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn giá";
            this.columnHeader2.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ghi chú";
            this.columnHeader4.Width = 151;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng giá dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thực đơn";
            // 
            // txtBangGia_Tendoan
            // 
            this.txtBangGia_Tendoan.Location = new System.Drawing.Point(108, 36);
            this.txtBangGia_Tendoan.Name = "txtBangGia_Tendoan";
            this.txtBangGia_Tendoan.Size = new System.Drawing.Size(99, 20);
            this.txtBangGia_Tendoan.TabIndex = 3;
            // 
            // btnBangGia_Them
            // 
            this.btnBangGia_Them.Location = new System.Drawing.Point(234, 39);
            this.btnBangGia_Them.Name = "btnBangGia_Them";
            this.btnBangGia_Them.Size = new System.Drawing.Size(75, 40);
            this.btnBangGia_Them.TabIndex = 4;
            this.btnBangGia_Them.Text = "Thêm";
            this.btnBangGia_Them.UseVisualStyleBackColor = true;
            this.btnBangGia_Them.Click += new System.EventHandler(this.btnBangGia_Them_Click);
            // 
            // btnBangGia_Xoa
            // 
            this.btnBangGia_Xoa.Location = new System.Drawing.Point(315, 38);
            this.btnBangGia_Xoa.Name = "btnBangGia_Xoa";
            this.btnBangGia_Xoa.Size = new System.Drawing.Size(75, 40);
            this.btnBangGia_Xoa.TabIndex = 5;
            this.btnBangGia_Xoa.Text = "Xóa";
            this.btnBangGia_Xoa.UseVisualStyleBackColor = true;
            this.btnBangGia_Xoa.Click += new System.EventHandler(this.btnBangGia_Xoa_Click);
            // 
            // btnBangGia_Sua
            // 
            this.btnBangGia_Sua.Location = new System.Drawing.Point(396, 38);
            this.btnBangGia_Sua.Name = "btnBangGia_Sua";
            this.btnBangGia_Sua.Size = new System.Drawing.Size(75, 40);
            this.btnBangGia_Sua.TabIndex = 6;
            this.btnBangGia_Sua.Text = "Sửa";
            this.btnBangGia_Sua.UseVisualStyleBackColor = true;
            this.btnBangGia_Sua.Click += new System.EventHandler(this.btnBangGia_Sua_Click);
            // 
            // txtBangGia_Dongia
            // 
            this.txtBangGia_Dongia.Location = new System.Drawing.Point(108, 62);
            this.txtBangGia_Dongia.Name = "txtBangGia_Dongia";
            this.txtBangGia_Dongia.Size = new System.Drawing.Size(99, 20);
            this.txtBangGia_Dongia.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đơn giá (VND)";
            // 
            // BanggiaDichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 387);
            this.Controls.Add(this.txtBangGia_Dongia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBangGia_Sua);
            this.Controls.Add(this.btnBangGia_Xoa);
            this.Controls.Add(this.btnBangGia_Them);
            this.Controls.Add(this.txtBangGia_Tendoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewThucdon);
            this.Name = "BanggiaDichvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng giá dịch vụ";
            this.Load += new System.EventHandler(this.BanggiaDichvu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewThucdon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBangGia_Tendoan;
        private System.Windows.Forms.Button btnBangGia_Them;
        private System.Windows.Forms.Button btnBangGia_Xoa;
        private System.Windows.Forms.Button btnBangGia_Sua;
        private System.Windows.Forms.TextBox txtBangGia_Dongia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}