﻿namespace dbms
{
    partial class phanCa
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_maCa1 = new System.Windows.Forms.TextBox();
            this.lbl_GioBD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date_gioBD = new System.Windows.Forms.DateTimePicker();
            this.date_GioKT = new System.Windows.Forms.DateTimePicker();
            this.pdg_CaLamViec = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_xoaCa = new System.Windows.Forms.Button();
            this.btn_SuaCa = new System.Windows.Forms.Button();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_maNV = new System.Windows.Forms.Label();
            this.lbl_MaCa = new System.Windows.Forms.Label();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.txt_maCa = new System.Windows.Forms.TextBox();
            this.lbl_NgayLV = new System.Windows.Forms.Label();
            this.date_ngayLV = new System.Windows.Forms.DateTimePicker();
            this.lbl_Luong = new System.Windows.Forms.Label();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.lbl_maLoaiNV = new System.Windows.Forms.Label();
            this.txt_loaiNhanVien = new System.Windows.Forms.TextBox();
            this.dgv_dsPhanCa = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdg_CaLamViec)).BeginInit();
            this.tabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsPhanCa)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_SuaCa);
            this.tabPage2.Controls.Add(this.btn_xoaCa);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.pdg_CaLamViec);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1146, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ca làm việc";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.date_GioKT);
            this.panel2.Controls.Add(this.date_gioBD);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbl_GioBD);
            this.panel2.Controls.Add(this.txt_maCa1);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 116);
            this.panel2.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Mã Ca";
            // 
            // txt_maCa1
            // 
            this.txt_maCa1.Location = new System.Drawing.Point(158, 20);
            this.txt_maCa1.Name = "txt_maCa1";
            this.txt_maCa1.Size = new System.Drawing.Size(309, 22);
            this.txt_maCa1.TabIndex = 10;
            // 
            // lbl_GioBD
            // 
            this.lbl_GioBD.AutoSize = true;
            this.lbl_GioBD.Location = new System.Drawing.Point(606, 23);
            this.lbl_GioBD.Name = "lbl_GioBD";
            this.lbl_GioBD.Size = new System.Drawing.Size(76, 16);
            this.lbl_GioBD.TabIndex = 38;
            this.lbl_GioBD.Text = "Giờ bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Giờ kết thúc";
            // 
            // date_gioBD
            // 
            this.date_gioBD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date_gioBD.Location = new System.Drawing.Point(726, 16);
            this.date_gioBD.Name = "date_gioBD";
            this.date_gioBD.Size = new System.Drawing.Size(292, 22);
            this.date_gioBD.TabIndex = 40;
            // 
            // date_GioKT
            // 
            this.date_GioKT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date_GioKT.Location = new System.Drawing.Point(726, 62);
            this.date_GioKT.Name = "date_GioKT";
            this.date_GioKT.Size = new System.Drawing.Size(292, 22);
            this.date_GioKT.TabIndex = 41;
            // 
            // pdg_CaLamViec
            // 
            this.pdg_CaLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pdg_CaLamViec.Location = new System.Drawing.Point(5, 158);
            this.pdg_CaLamViec.Name = "pdg_CaLamViec";
            this.pdg_CaLamViec.RowHeadersWidth = 51;
            this.pdg_CaLamViec.RowTemplate.Height = 24;
            this.pdg_CaLamViec.Size = new System.Drawing.Size(1134, 312);
            this.pdg_CaLamViec.TabIndex = 17;
            this.pdg_CaLamViec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pdg_CaLamViec_CellContentClick);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(279, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 43);
            this.button3.TabIndex = 20;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_xoaCa
            // 
            this.btn_xoaCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaCa.Location = new System.Drawing.Point(499, 518);
            this.btn_xoaCa.Name = "btn_xoaCa";
            this.btn_xoaCa.Size = new System.Drawing.Size(130, 43);
            this.btn_xoaCa.TabIndex = 21;
            this.btn_xoaCa.Text = "Xóa";
            this.btn_xoaCa.UseVisualStyleBackColor = true;
            this.btn_xoaCa.Click += new System.EventHandler(this.btn_xoaCa_Click);
            // 
            // btn_SuaCa
            // 
            this.btn_SuaCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuaCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaCa.Location = new System.Drawing.Point(714, 518);
            this.btn_SuaCa.Name = "btn_SuaCa";
            this.btn_SuaCa.Size = new System.Drawing.Size(130, 43);
            this.btn_SuaCa.TabIndex = 22;
            this.btn_SuaCa.Text = "Sửa";
            this.btn_SuaCa.UseVisualStyleBackColor = true;
            this.btn_SuaCa.Click += new System.EventHandler(this.btn_SuaCa_Click);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPage1);
            this.tabPage.Controls.Add(this.tabPage2);
            this.tabPage.Location = new System.Drawing.Point(3, 3);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(1154, 618);
            this.tabPage.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_loaiNhanVien);
            this.panel1.Controls.Add(this.lbl_maLoaiNV);
            this.panel1.Controls.Add(this.txt_luong);
            this.panel1.Controls.Add(this.lbl_Luong);
            this.panel1.Controls.Add(this.date_ngayLV);
            this.panel1.Controls.Add(this.lbl_NgayLV);
            this.panel1.Controls.Add(this.txt_maCa);
            this.panel1.Controls.Add(this.txt_maNV);
            this.panel1.Controls.Add(this.lbl_MaCa);
            this.panel1.Controls.Add(this.lbl_maNV);
            this.panel1.Location = new System.Drawing.Point(6, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 145);
            this.panel1.TabIndex = 15;
            // 
            // lbl_maNV
            // 
            this.lbl_maNV.AutoSize = true;
            this.lbl_maNV.Location = new System.Drawing.Point(25, 22);
            this.lbl_maNV.Name = "lbl_maNV";
            this.lbl_maNV.Size = new System.Drawing.Size(86, 16);
            this.lbl_maNV.TabIndex = 0;
            this.lbl_maNV.Text = "Mã nhân viên";
            // 
            // lbl_MaCa
            // 
            this.lbl_MaCa.AutoSize = true;
            this.lbl_MaCa.Location = new System.Drawing.Point(25, 65);
            this.lbl_MaCa.Name = "lbl_MaCa";
            this.lbl_MaCa.Size = new System.Drawing.Size(46, 16);
            this.lbl_MaCa.TabIndex = 1;
            this.lbl_MaCa.Text = "Mã Ca";
            // 
            // txt_maNV
            // 
            this.txt_maNV.Location = new System.Drawing.Point(156, 14);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(309, 22);
            this.txt_maNV.TabIndex = 8;
            // 
            // txt_maCa
            // 
            this.txt_maCa.Location = new System.Drawing.Point(156, 58);
            this.txt_maCa.Name = "txt_maCa";
            this.txt_maCa.Size = new System.Drawing.Size(309, 22);
            this.txt_maCa.TabIndex = 10;
            // 
            // lbl_NgayLV
            // 
            this.lbl_NgayLV.AutoSize = true;
            this.lbl_NgayLV.Location = new System.Drawing.Point(573, 21);
            this.lbl_NgayLV.Name = "lbl_NgayLV";
            this.lbl_NgayLV.Size = new System.Drawing.Size(93, 16);
            this.lbl_NgayLV.TabIndex = 13;
            this.lbl_NgayLV.Text = "Ngày làm việc";
            // 
            // date_ngayLV
            // 
            this.date_ngayLV.Location = new System.Drawing.Point(706, 16);
            this.date_ngayLV.Name = "date_ngayLV";
            this.date_ngayLV.Size = new System.Drawing.Size(309, 22);
            this.date_ngayLV.TabIndex = 14;
            // 
            // lbl_Luong
            // 
            this.lbl_Luong.AutoSize = true;
            this.lbl_Luong.Location = new System.Drawing.Point(573, 64);
            this.lbl_Luong.Name = "lbl_Luong";
            this.lbl_Luong.Size = new System.Drawing.Size(44, 16);
            this.lbl_Luong.TabIndex = 15;
            this.lbl_Luong.Text = "Lương";
            // 
            // txt_luong
            // 
            this.txt_luong.Location = new System.Drawing.Point(706, 59);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(309, 22);
            this.txt_luong.TabIndex = 16;
            // 
            // lbl_maLoaiNV
            // 
            this.lbl_maLoaiNV.AutoSize = true;
            this.lbl_maLoaiNV.Location = new System.Drawing.Point(25, 107);
            this.lbl_maLoaiNV.Name = "lbl_maLoaiNV";
            this.lbl_maLoaiNV.Size = new System.Drawing.Size(111, 16);
            this.lbl_maLoaiNV.TabIndex = 17;
            this.lbl_maLoaiNV.Text = "Mã loại nhân viên";
            // 
            // txt_loaiNhanVien
            // 
            this.txt_loaiNhanVien.Location = new System.Drawing.Point(156, 101);
            this.txt_loaiNhanVien.Name = "txt_loaiNhanVien";
            this.txt_loaiNhanVien.Size = new System.Drawing.Size(309, 22);
            this.txt_loaiNhanVien.TabIndex = 18;
            // 
            // dgv_dsPhanCa
            // 
            this.dgv_dsPhanCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsPhanCa.Location = new System.Drawing.Point(6, 186);
            this.dgv_dsPhanCa.Name = "dgv_dsPhanCa";
            this.dgv_dsPhanCa.RowHeadersWidth = 51;
            this.dgv_dsPhanCa.RowTemplate.Height = 24;
            this.dgv_dsPhanCa.Size = new System.Drawing.Size(1134, 323);
            this.dgv_dsPhanCa.TabIndex = 16;
            this.dgv_dsPhanCa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsPhanCa_CellContentClick);
            // 
            // btn_Them
            // 
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(268, 537);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(130, 43);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(488, 537);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(130, 43);
            this.btn_Xoa.TabIndex = 18;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(703, 537);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(130, 43);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Sua);
            this.tabPage1.Controls.Add(this.btn_Xoa);
            this.tabPage1.Controls.Add(this.btn_Them);
            this.tabPage1.Controls.Add(this.dgv_dsPhanCa);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1146, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phân Ca";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // phanCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 621);
            this.Controls.Add(this.tabPage);
            this.Name = "phanCa";
            this.Text = "phanCa";
            this.Load += new System.EventHandler(this.phanCa_Load);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdg_CaLamViec)).EndInit();
            this.tabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsPhanCa)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_SuaCa;
        private System.Windows.Forms.Button btn_xoaCa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView pdg_CaLamViec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker date_GioKT;
        private System.Windows.Forms.DateTimePicker date_gioBD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_GioBD;
        private System.Windows.Forms.TextBox txt_maCa1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_dsPhanCa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_loaiNhanVien;
        private System.Windows.Forms.Label lbl_maLoaiNV;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.Label lbl_Luong;
        private System.Windows.Forms.DateTimePicker date_ngayLV;
        private System.Windows.Forms.Label lbl_NgayLV;
        private System.Windows.Forms.TextBox txt_maCa;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.Label lbl_MaCa;
        private System.Windows.Forms.Label lbl_maNV;
    }
}