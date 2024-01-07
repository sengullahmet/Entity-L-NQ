namespace entity
{
    partial class FrmAnaForm
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
            this.btnCategorıes = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnStatics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategorıes
            // 
            this.btnCategorıes.Location = new System.Drawing.Point(12, 31);
            this.btnCategorıes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCategorıes.Name = "btnCategorıes";
            this.btnCategorıes.Size = new System.Drawing.Size(255, 132);
            this.btnCategorıes.TabIndex = 0;
            this.btnCategorıes.Text = "KATEGORİ İŞLEMLERİ";
            this.btnCategorıes.UseVisualStyleBackColor = true;
            this.btnCategorıes.Click += new System.EventHandler(this.btnCategorıes_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(273, 31);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(255, 132);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "ÜRÜN İŞLEMLERİ";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnStatics
            // 
            this.btnStatics.Location = new System.Drawing.Point(534, 31);
            this.btnStatics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStatics.Name = "btnStatics";
            this.btnStatics.Size = new System.Drawing.Size(255, 132);
            this.btnStatics.TabIndex = 2;
            this.btnStatics.Text = "İSTATİSTİK";
            this.btnStatics.UseVisualStyleBackColor = true;
            this.btnStatics.Click += new System.EventHandler(this.btnStatics_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(824, 198);
            this.Controls.Add(this.btnStatics);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnCategorıes);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategorıes;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnStatics;
    }
}