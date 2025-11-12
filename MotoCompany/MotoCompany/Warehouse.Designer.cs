namespace MotoCompany
{
    partial class Warehouse
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
            this.lblParts = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstParts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMotorcycles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParts.Location = new System.Drawing.Point(3, 12);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(72, 20);
            this.lblParts.TabIndex = 0;
            this.lblParts.Text = "Parçalar";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1151, 619);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 39);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstParts
            // 
            this.lstParts.FormattingEnabled = true;
            this.lstParts.ItemHeight = 16;
            this.lstParts.Location = new System.Drawing.Point(7, 35);
            this.lstParts.Name = "lstParts";
            this.lstParts.Size = new System.Drawing.Size(189, 180);
            this.lstParts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(247, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Motorlar";
            // 
            // lstMotorcycles
            // 
            this.lstMotorcycles.FormattingEnabled = true;
            this.lstMotorcycles.ItemHeight = 16;
            this.lstMotorcycles.Location = new System.Drawing.Point(251, 35);
            this.lstMotorcycles.Name = "lstMotorcycles";
            this.lstMotorcycles.Size = new System.Drawing.Size(189, 180);
            this.lstMotorcycles.TabIndex = 4;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstMotorcycles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstParts);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblParts);
            this.Name = "Warehouse";
            this.Size = new System.Drawing.Size(1280, 661);
            this.Load += new System.EventHandler(this.Warehouse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMotorcycles;
    }
}
