using System.Windows.Forms;

namespace FinFormMagazine
{
    partial class CasirForm
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
            this.lstChek = new System.Windows.Forms.ListView();
            this.OpenChek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.GetProduct = new System.Windows.Forms.Button();
            this.Sell = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.IdProd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstChek
            // 
            this.lstChek.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstChek.ForeColor = System.Drawing.Color.CadetBlue;
            this.lstChek.FullRowSelect = true;
            this.lstChek.GridLines = true;
            this.lstChek.Location = new System.Drawing.Point(3, 2);
            this.lstChek.Name = "lstChek";
            this.lstChek.Size = new System.Drawing.Size(386, 121);
            this.lstChek.TabIndex = 2;
            this.lstChek.UseCompatibleStateImageBehavior = false;
            this.lstChek.SelectedIndexChanged += new System.EventHandler(this.lstChek_SelectedIndexChanged);
            // 
            // OpenChek
            // 
            this.OpenChek.BackColor = System.Drawing.Color.Chartreuse;
            this.OpenChek.ForeColor = System.Drawing.Color.Blue;
            this.OpenChek.Location = new System.Drawing.Point(110, 129);
            this.OpenChek.Name = "OpenChek";
            this.OpenChek.Size = new System.Drawing.Size(159, 23);
            this.OpenChek.TabIndex = 3;
            this.OpenChek.Text = "Отчет";
            this.OpenChek.UseVisualStyleBackColor = false;
            this.OpenChek.Click += new System.EventHandler(this.OpenChek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(13, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(13, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Цeна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Location = new System.Drawing.Point(13, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(123, 255);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(75, 20);
            this.tbPrice.TabIndex = 8;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(123, 285);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(75, 20);
            this.tbQuantity.TabIndex = 8;
            // 
            // GetProduct
            // 
            this.GetProduct.BackColor = System.Drawing.Color.BurlyWood;
            this.GetProduct.ForeColor = System.Drawing.Color.DarkBlue;
            this.GetProduct.Location = new System.Drawing.Point(197, 322);
            this.GetProduct.Name = "GetProduct";
            this.GetProduct.Size = new System.Drawing.Size(131, 23);
            this.GetProduct.TabIndex = 9;
            this.GetProduct.Text = "Показать продукты";
            this.GetProduct.UseVisualStyleBackColor = false;
            this.GetProduct.Click += new System.EventHandler(this.GetProduct_Click);
            // 
            // Sell
            // 
            this.Sell.BackColor = System.Drawing.Color.BurlyWood;
            this.Sell.ForeColor = System.Drawing.Color.DarkBlue;
            this.Sell.Location = new System.Drawing.Point(16, 322);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(131, 23);
            this.Sell.TabIndex = 9;
            this.Sell.Text = "Продать";
            this.Sell.UseVisualStyleBackColor = false;
            this.Sell.Click += new System.EventHandler(this.Sell_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Aqua;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(140, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Продаж";
            // 
            // IdProd
            // 
            this.IdProd.Location = new System.Drawing.Point(123, 224);
            this.IdProd.Name = "IdProd";
            this.IdProd.Size = new System.Drawing.Size(75, 20);
            this.IdProd.TabIndex = 11;
            // 
            // CasirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(383, 360);
            this.Controls.Add(this.IdProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.GetProduct);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenChek);
            this.Controls.Add(this.lstChek);
            this.Name = "CasirForm";
            this.Text = "CasirForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseCasir);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstChek;
        private System.Windows.Forms.Button OpenChek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private string IdProduct;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button GetProduct;
        private System.Windows.Forms.Button Sell;
        private System.Windows.Forms.Label label5;
        private ListView.ListViewItemCollection tbIdProduct;
        private TextBox IdProd;
    }
}