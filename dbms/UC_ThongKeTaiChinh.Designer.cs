namespace dbms
{
    partial class UC_ThongKeTaiChinh
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
            this.dgv_ThongKeTaiChinh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeTaiChinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ThongKeTaiChinh
            // 
            this.dgv_ThongKeTaiChinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKeTaiChinh.Location = new System.Drawing.Point(3, 3);
            this.dgv_ThongKeTaiChinh.Name = "dgv_ThongKeTaiChinh";
            this.dgv_ThongKeTaiChinh.RowHeadersWidth = 51;
            this.dgv_ThongKeTaiChinh.RowTemplate.Height = 24;
            this.dgv_ThongKeTaiChinh.Size = new System.Drawing.Size(1095, 522);
            this.dgv_ThongKeTaiChinh.TabIndex = 0;
            // 
            // UC_ThongKeTaiChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_ThongKeTaiChinh);
            this.Name = "UC_ThongKeTaiChinh";
            this.Size = new System.Drawing.Size(1098, 528);
            this.Load += new System.EventHandler(this.UC_ThongKeTaiChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeTaiChinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ThongKeTaiChinh;
    }
}
