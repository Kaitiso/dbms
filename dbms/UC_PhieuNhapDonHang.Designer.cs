namespace dbms
{
    partial class UC_PhieuNhapDonHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_PhieuNhapDonHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhapDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PhieuNhapDonHang
            // 
            this.dgv_PhieuNhapDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuNhapDonHang.Location = new System.Drawing.Point(3, 3);
            this.dgv_PhieuNhapDonHang.Name = "dgv_PhieuNhapDonHang";
            this.dgv_PhieuNhapDonHang.RowHeadersWidth = 51;
            this.dgv_PhieuNhapDonHang.RowTemplate.Height = 24;
            this.dgv_PhieuNhapDonHang.Size = new System.Drawing.Size(1092, 522);
            this.dgv_PhieuNhapDonHang.TabIndex = 0;
            // 
            // UC_PhieuNhapDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_PhieuNhapDonHang);
            this.Name = "UC_PhieuNhapDonHang";
            this.Size = new System.Drawing.Size(1098, 528);
            this.Load += new System.EventHandler(this.UC_PhieuNhapDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhapDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PhieuNhapDonHang;
    }
}
