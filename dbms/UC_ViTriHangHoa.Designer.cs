namespace dbms
{
    partial class UC_ViTriHangHoa
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
            this.dgv_ViTriHangHoa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViTriHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ViTriHangHoa
            // 
            this.dgv_ViTriHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViTriHangHoa.Location = new System.Drawing.Point(3, 3);
            this.dgv_ViTriHangHoa.Name = "dgv_ViTriHangHoa";
            this.dgv_ViTriHangHoa.RowHeadersWidth = 51;
            this.dgv_ViTriHangHoa.RowTemplate.Height = 24;
            this.dgv_ViTriHangHoa.Size = new System.Drawing.Size(1092, 522);
            this.dgv_ViTriHangHoa.TabIndex = 0;
            // 
            // UC_ViTriHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_ViTriHangHoa);
            this.Name = "UC_ViTriHangHoa";
            this.Size = new System.Drawing.Size(1098, 528);
            this.Load += new System.EventHandler(this.UC_ViTriHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViTriHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ViTriHangHoa;
    }
}
