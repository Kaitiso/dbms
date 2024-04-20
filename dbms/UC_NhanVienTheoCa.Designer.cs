namespace dbms
{
    partial class UC_NhanVienTheoCa
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
            this.dgv_NhanVienTheoCa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVienTheoCa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_NhanVienTheoCa
            // 
            this.dgv_NhanVienTheoCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVienTheoCa.Location = new System.Drawing.Point(3, 3);
            this.dgv_NhanVienTheoCa.Name = "dgv_NhanVienTheoCa";
            this.dgv_NhanVienTheoCa.RowHeadersWidth = 51;
            this.dgv_NhanVienTheoCa.RowTemplate.Height = 24;
            this.dgv_NhanVienTheoCa.Size = new System.Drawing.Size(1092, 522);
            this.dgv_NhanVienTheoCa.TabIndex = 0;
            // 
            // UC_NhanVienTheoCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_NhanVienTheoCa);
            this.Name = "UC_NhanVienTheoCa";
            this.Size = new System.Drawing.Size(1098, 528);
            this.Load += new System.EventHandler(this.UC_NhanVienTheoCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVienTheoCa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_NhanVienTheoCa;
    }
}
