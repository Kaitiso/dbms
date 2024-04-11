namespace dbms
{
    partial class UC_PhieuTichDiem
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
            this.dgv_PhieuTichDiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuTichDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PhieuTichDiem
            // 
            this.dgv_PhieuTichDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuTichDiem.Location = new System.Drawing.Point(3, 3);
            this.dgv_PhieuTichDiem.Name = "dgv_PhieuTichDiem";
            this.dgv_PhieuTichDiem.RowHeadersWidth = 51;
            this.dgv_PhieuTichDiem.RowTemplate.Height = 24;
            this.dgv_PhieuTichDiem.Size = new System.Drawing.Size(1092, 522);
            this.dgv_PhieuTichDiem.TabIndex = 0;
            // 
            // UC_PhieuTichDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_PhieuTichDiem);
            this.Name = "UC_PhieuTichDiem";
            this.Size = new System.Drawing.Size(1098, 528);
            this.Load += new System.EventHandler(this.UC_PhieuTichDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuTichDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PhieuTichDiem;
    }
}
