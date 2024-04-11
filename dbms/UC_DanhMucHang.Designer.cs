namespace dbms
{
    partial class UC_DanhMucHang
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
            this.dgv_DanhMucHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMucHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DanhMucHang
            // 
            this.dgv_DanhMucHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhMucHang.Location = new System.Drawing.Point(3, 3);
            this.dgv_DanhMucHang.Name = "dgv_DanhMucHang";
            this.dgv_DanhMucHang.RowHeadersWidth = 51;
            this.dgv_DanhMucHang.RowTemplate.Height = 24;
            this.dgv_DanhMucHang.Size = new System.Drawing.Size(1092, 522);
            this.dgv_DanhMucHang.TabIndex = 0;
            // 
            // UC_DanhMucHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_DanhMucHang);
            this.Name = "UC_DanhMucHang";
            this.Size = new System.Drawing.Size(1098, 528);
            this.Load += new System.EventHandler(this.UC_DanhMucHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMucHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DanhMucHang;
    }
}
