
namespace dbms
{
    partial class UC_LoaiHH
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
            this.lbl_tenHH = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_SL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tenHH
            // 
            this.lbl_tenHH.AutoSize = true;
            this.lbl_tenHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenHH.Location = new System.Drawing.Point(15, 180);
            this.lbl_tenHH.Name = "lbl_tenHH";
            this.lbl_tenHH.Size = new System.Drawing.Size(108, 20);
            this.lbl_tenHH.TabIndex = 0;
            this.lbl_tenHH.Text = "Kem 15.000K";
            this.lbl_tenHH.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dbms.Properties.Resources.pngtree_all_kinds_of_ice_cream_png_image_3210372;
            this.pictureBox1.Location = new System.Drawing.Point(19, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_SL
            // 
            this.lbl_SL.AutoSize = true;
            this.lbl_SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SL.Location = new System.Drawing.Point(72, 213);
            this.lbl_SL.Name = "lbl_SL";
            this.lbl_SL.Size = new System.Drawing.Size(62, 20);
            this.lbl_SL.TabIndex = 2;
            this.lbl_SL.Text = "SL:20c";
            // 
            // UC_LoaiHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_SL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_tenHH);
            this.Name = "UC_LoaiHH";
            this.Size = new System.Drawing.Size(229, 257);
            this.Load += new System.EventHandler(this.UC_LoaiHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tenHH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_SL;
    }
}
