namespace MotoCompany
{
    partial class GameScreen
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
            this.btnMap = new System.Windows.Forms.Button();
            this.btnPC = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.pnlSubScreen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(585, 667);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(119, 50);
            this.btnMap.TabIndex = 0;
            this.btnMap.Text = "Harita";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnPC
            // 
            this.btnPC.Location = new System.Drawing.Point(486, 683);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(93, 34);
            this.btnPC.TabIndex = 1;
            this.btnPC.Text = "Bilgisayar";
            this.btnPC.UseVisualStyleBackColor = true;
            this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Location = new System.Drawing.Point(710, 683);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(93, 34);
            this.btnWarehouse.TabIndex = 2;
            this.btnWarehouse.Text = "Depo";
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // pnlSubScreen
            // 
            this.pnlSubScreen.Location = new System.Drawing.Point(0, 0);
            this.pnlSubScreen.Name = "pnlSubScreen";
            this.pnlSubScreen.Size = new System.Drawing.Size(1280, 661);
            this.pnlSubScreen.TabIndex = 3;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSubScreen);
            this.Controls.Add(this.btnWarehouse);
            this.Controls.Add(this.btnPC);
            this.Controls.Add(this.btnMap);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnPC;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Panel pnlSubScreen;
    }
}
