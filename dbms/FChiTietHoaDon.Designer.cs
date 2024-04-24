namespace dbms
{
    partial class FChiTietHoaDon
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
            this.dgv_chiTietHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_chiTietHoaDon
            // 
            this.dgv_chiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chiTietHoaDon.Location = new System.Drawing.Point(0, -1);
            this.dgv_chiTietHoaDon.Name = "dgv_chiTietHoaDon";
            this.dgv_chiTietHoaDon.RowHeadersWidth = 51;
            this.dgv_chiTietHoaDon.RowTemplate.Height = 24;
            this.dgv_chiTietHoaDon.Size = new System.Drawing.Size(669, 620);
            this.dgv_chiTietHoaDon.TabIndex = 0;
            // 
            // FChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 613);
            this.Controls.Add(this.dgv_chiTietHoaDon);
            this.Name = "FChiTietHoaDon";
            this.Text = "UChiTietHoaDon";
            this.Load += new System.EventHandler(this.FChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chiTietHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_chiTietHoaDon;
    }
}