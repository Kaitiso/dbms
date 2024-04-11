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
            //this.dgv_DanhMucHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            //this.dgv_DanhMucHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            //this.dgv_DanhMucHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            //this.dgv_DanhMucHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            //this.dgv_DanhMucHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            //this.dgv_DanhMucHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            //this.dgv_DanhMucHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            //this.dgv_DanhMucHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            //this.dgv_DanhMucHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            //this.dgv_DanhMucHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.dgv_DanhMucHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            //this.dgv_DanhMucHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            //this.dgv_DanhMucHang.ThemeStyle.HeaderStyle.Height = 4;
            //this.dgv_DanhMucHang.ThemeStyle.ReadOnly = false;
            //this.dgv_DanhMucHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            //this.dgv_DanhMucHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            //this.dgv_DanhMucHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.dgv_DanhMucHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //this.dgv_DanhMucHang.ThemeStyle.RowsStyle.Height = 24;
            //this.dgv_DanhMucHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            //this.dgv_DanhMucHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DanhMucHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhMucHang_CellContentClick);
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
