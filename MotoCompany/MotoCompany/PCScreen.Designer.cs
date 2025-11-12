namespace MotoCompany
{
    partial class PCScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCScreen));
            this.pcbBackground = new System.Windows.Forms.PictureBox();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnComCoin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBackPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbBackground
            // 
            this.pcbBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbBackground.BackgroundImage")));
            this.pcbBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbBackground.Location = new System.Drawing.Point(0, 0);
            this.pcbBackground.Name = "pcbBackground";
            this.pcbBackground.Size = new System.Drawing.Size(1280, 720);
            this.pcbBackground.TabIndex = 0;
            this.pcbBackground.TabStop = false;
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(26, 14);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(100, 100);
            this.btnShop.TabIndex = 1;
            this.btnShop.Text = "Market";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnComCoin
            // 
            this.btnComCoin.Location = new System.Drawing.Point(26, 138);
            this.btnComCoin.Name = "btnComCoin";
            this.btnComCoin.Size = new System.Drawing.Size(100, 100);
            this.btnComCoin.TabIndex = 2;
            this.btnComCoin.Text = "ComCoin";
            this.btnComCoin.UseVisualStyleBackColor = true;
            this.btnComCoin.Click += new System.EventHandler(this.btnComCoin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 670);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnBackPage
            // 
            this.btnBackPage.Location = new System.Drawing.Point(26, 670);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(75, 50);
            this.btnBackPage.TabIndex = 4;
            this.btnBackPage.Text = "Geri Dön";
            this.btnBackPage.UseVisualStyleBackColor = true;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // PCScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBackPage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnComCoin);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.pcbBackground);
            this.Name = "PCScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.PCScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbBackground;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnComCoin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBackPage;
    }
}
