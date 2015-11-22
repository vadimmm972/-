namespace FinFormMagazine
{
    partial class FormWorker
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
            this.lstDelivery = new System.Windows.Forms.ListView();
            this.btnOPen = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.tbIdSupp = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.tbIdProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.bntMesserment = new System.Windows.Forms.Button();
            this.btnMarkap = new System.Windows.Forms.Button();
            this.tbNameProd = new System.Windows.Forms.TextBox();
            this.tbCategoryProd = new System.Windows.Forms.TextBox();
            this.tbPeiceProd = new System.Windows.Forms.TextBox();
            this.tbQuantityProd = new System.Windows.Forms.TextBox();
            this.tbIdProducerProd = new System.Windows.Forms.TextBox();
            this.tbIdMasurmentProd = new System.Windows.Forms.TextBox();
            this.tbMarkup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCategory = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDelivery
            // 
            this.lstDelivery.FullRowSelect = true;
            this.lstDelivery.GridLines = true;
            this.lstDelivery.Location = new System.Drawing.Point(1, 2);
            this.lstDelivery.Name = "lstDelivery";
            this.lstDelivery.Size = new System.Drawing.Size(466, 126);
            this.lstDelivery.TabIndex = 0;
            this.lstDelivery.UseCompatibleStateImageBehavior = false;
            this.lstDelivery.SelectedIndexChanged += new System.EventHandler(this.lstDelivery_SelectedIndexChanged);
            // 
            // btnOPen
            // 
            this.btnOPen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOPen.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnOPen.Location = new System.Drawing.Point(1, 134);
            this.btnOPen.Name = "btnOPen";
            this.btnOPen.Size = new System.Drawing.Size(121, 23);
            this.btnOPen.TabIndex = 1;
            this.btnOPen.Text = "Промотр товаров";
            this.btnOPen.UseVisualStyleBackColor = false;
            this.btnOPen.Click += new System.EventHandler(this.btnOPen_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Chartreuse;
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPurchase.ForeColor = System.Drawing.Color.Crimson;
            this.btnPurchase.Location = new System.Drawing.Point(1, 180);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(76, 33);
            this.btnPurchase.TabIndex = 2;
            this.btnPurchase.Text = "Закупка";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // tbIdSupp
            // 
            this.tbIdSupp.Location = new System.Drawing.Point(5, 302);
            this.tbIdSupp.Name = "tbIdSupp";
            this.tbIdSupp.Size = new System.Drawing.Size(100, 20);
            this.tbIdSupp.TabIndex = 3;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(5, 343);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 3;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(5, 387);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(100, 20);
            this.Quantity.TabIndex = 3;
            // 
            // tbIdProd
            // 
            this.tbIdProd.Location = new System.Drawing.Point(5, 258);
            this.tbIdProd.Name = "tbIdProd";
            this.tbIdProd.Size = new System.Drawing.Size(100, 20);
            this.tbIdProd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(2, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер поставшчика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(2, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(2, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cyan;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(2, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Номер продукта";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Купить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProd
            // 
            this.btnProd.Location = new System.Drawing.Point(226, 134);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(75, 23);
            this.btnProd.TabIndex = 6;
            this.btnProd.Text = "Продукти";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(128, 134);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(92, 23);
            this.btnSupp.TabIndex = 7;
            this.btnSupp.Text = "Поставщики";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // bntMesserment
            // 
            this.bntMesserment.Location = new System.Drawing.Point(307, 134);
            this.bntMesserment.Name = "bntMesserment";
            this.bntMesserment.Size = new System.Drawing.Size(75, 23);
            this.bntMesserment.TabIndex = 8;
            this.bntMesserment.Text = "Измерения";
            this.bntMesserment.UseVisualStyleBackColor = true;
            this.bntMesserment.Click += new System.EventHandler(this.bntMesserment_Click);
            // 
            // btnMarkap
            // 
            this.btnMarkap.Location = new System.Drawing.Point(388, 134);
            this.btnMarkap.Name = "btnMarkap";
            this.btnMarkap.Size = new System.Drawing.Size(75, 23);
            this.btnMarkap.TabIndex = 9;
            this.btnMarkap.Text = "Наценка";
            this.btnMarkap.UseVisualStyleBackColor = true;
            this.btnMarkap.Click += new System.EventHandler(this.btnMarkap_Click);
            // 
            // tbNameProd
            // 
            this.tbNameProd.Location = new System.Drawing.Point(338, 261);
            this.tbNameProd.Name = "tbNameProd";
            this.tbNameProd.Size = new System.Drawing.Size(100, 20);
            this.tbNameProd.TabIndex = 10;
            // 
            // tbCategoryProd
            // 
            this.tbCategoryProd.Location = new System.Drawing.Point(338, 287);
            this.tbCategoryProd.Name = "tbCategoryProd";
            this.tbCategoryProd.Size = new System.Drawing.Size(100, 20);
            this.tbCategoryProd.TabIndex = 10;
            // 
            // tbPeiceProd
            // 
            this.tbPeiceProd.Location = new System.Drawing.Point(338, 313);
            this.tbPeiceProd.Name = "tbPeiceProd";
            this.tbPeiceProd.Size = new System.Drawing.Size(100, 20);
            this.tbPeiceProd.TabIndex = 10;
            // 
            // tbQuantityProd
            // 
            this.tbQuantityProd.Location = new System.Drawing.Point(338, 339);
            this.tbQuantityProd.Name = "tbQuantityProd";
            this.tbQuantityProd.Size = new System.Drawing.Size(100, 20);
            this.tbQuantityProd.TabIndex = 10;
            // 
            // tbIdProducerProd
            // 
            this.tbIdProducerProd.Location = new System.Drawing.Point(338, 364);
            this.tbIdProducerProd.Name = "tbIdProducerProd";
            this.tbIdProducerProd.Size = new System.Drawing.Size(100, 20);
            this.tbIdProducerProd.TabIndex = 10;
            // 
            // tbIdMasurmentProd
            // 
            this.tbIdMasurmentProd.Location = new System.Drawing.Point(338, 387);
            this.tbIdMasurmentProd.Name = "tbIdMasurmentProd";
            this.tbIdMasurmentProd.Size = new System.Drawing.Size(100, 20);
            this.tbIdMasurmentProd.TabIndex = 10;
            // 
            // tbMarkup
            // 
            this.tbMarkup.Location = new System.Drawing.Point(338, 413);
            this.tbMarkup.Name = "tbMarkup";
            this.tbMarkup.Size = new System.Drawing.Size(100, 20);
            this.tbMarkup.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(160, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(160, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Категория";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(160, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Цена";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(160, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Количество";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(160, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Номер Изготовителя";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(160, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Номер измерения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(160, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "Номер акции";
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(388, 163);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(75, 23);
            this.btnCategory.TabIndex = 12;
            this.btnCategory.Text = "Категория";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Добавить продукт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 226);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMarkup);
            this.Controls.Add(this.tbIdMasurmentProd);
            this.Controls.Add(this.tbIdProducerProd);
            this.Controls.Add(this.tbQuantityProd);
            this.Controls.Add(this.tbPeiceProd);
            this.Controls.Add(this.tbCategoryProd);
            this.Controls.Add(this.tbNameProd);
            this.Controls.Add(this.btnMarkap);
            this.Controls.Add(this.bntMesserment);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIdProd);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbIdSupp);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnOPen);
            this.Controls.Add(this.lstDelivery);
            this.Name = "FormWorker";
            this.Text = "FormWorker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWorker_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstDelivery;
        private System.Windows.Forms.Button btnOPen;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.TextBox tbIdSupp;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox tbIdProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button bntMesserment;
        private System.Windows.Forms.Button btnMarkap;
        private System.Windows.Forms.TextBox tbNameProd;
        private System.Windows.Forms.TextBox tbCategoryProd;
        private System.Windows.Forms.TextBox tbPeiceProd;
        private System.Windows.Forms.TextBox tbQuantityProd;
        private System.Windows.Forms.TextBox tbIdProducerProd;
        private System.Windows.Forms.TextBox tbIdMasurmentProd;
        private System.Windows.Forms.TextBox tbMarkup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button button2;
    }
}