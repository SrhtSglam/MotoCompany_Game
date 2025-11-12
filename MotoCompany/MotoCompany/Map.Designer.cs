namespace MotoCompany
{
    partial class Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.btnRegionTr = new System.Windows.Forms.Button();
            this.btnRegionFr = new System.Windows.Forms.Button();
            this.btnRegionDu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegionTr
            // 
            this.btnRegionTr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegionTr.Location = new System.Drawing.Point(901, 411);
            this.btnRegionTr.Name = "btnRegionTr";
            this.btnRegionTr.Size = new System.Drawing.Size(48, 47);
            this.btnRegionTr.TabIndex = 1;
            this.btnRegionTr.UseVisualStyleBackColor = false;
            this.btnRegionTr.Click += new System.EventHandler(this.btnRegionTr_Click);
            // 
            // btnRegionFr
            // 
            this.btnRegionFr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegionFr.Location = new System.Drawing.Point(378, 221);
            this.btnRegionFr.Name = "btnRegionFr";
            this.btnRegionFr.Size = new System.Drawing.Size(48, 47);
            this.btnRegionFr.TabIndex = 2;
            this.btnRegionFr.UseVisualStyleBackColor = false;
            this.btnRegionFr.Click += new System.EventHandler(this.btnRegionFr_Click);
            // 
            // btnRegionDu
            // 
            this.btnRegionDu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegionDu.Location = new System.Drawing.Point(527, 117);
            this.btnRegionDu.Name = "btnRegionDu";
            this.btnRegionDu.Size = new System.Drawing.Size(48, 47);
            this.btnRegionDu.TabIndex = 3;
            this.btnRegionDu.UseVisualStyleBackColor = false;
            this.btnRegionDu.Click += new System.EventHandler(this.btnRegionDu_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1151, 619);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 39);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegionDu);
            this.Controls.Add(this.btnRegionFr);
            this.Controls.Add(this.btnRegionTr);
            this.DoubleBuffered = true;
            this.Name = "Map";
            this.Size = new System.Drawing.Size(1280, 661);
            this.Load += new System.EventHandler(this.Map_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegionTr;
        private System.Windows.Forms.Button btnRegionFr;
        private System.Windows.Forms.Button btnRegionDu;
        private System.Windows.Forms.Button btnBack;
    }
}
