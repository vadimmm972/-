namespace FinFormMagazine
{
    partial class ManegerForm
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
            this.Hire = new System.Windows.Forms.Button();
            this.Dismiss = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbDimiss = new System.Windows.Forms.TextBox();
            this.lstMngTable = new System.Windows.Forms.ListView();
            this.btnCasir = new System.Windows.Forms.Button();
            this.btnWorker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labMngTable = new System.Windows.Forms.Label();
            this.tbNumPhone = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbAddCasir = new System.Windows.Forms.RadioButton();
            this.rbAddWorker = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstNewProdPrice = new System.Windows.Forms.ListView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbIdProd = new System.Windows.Forms.TextBox();
            this.tbNewPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnProd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hire
            // 
            this.Hire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Hire.Location = new System.Drawing.Point(12, 465);
            this.Hire.Name = "Hire";
            this.Hire.Size = new System.Drawing.Size(121, 23);
            this.Hire.TabIndex = 0;
            this.Hire.Text = "Нанять на роботу";
            this.Hire.UseVisualStyleBackColor = false;
            this.Hire.Click += new System.EventHandler(this.Hire_Click);
            // 
            // Dismiss
            // 
            this.Dismiss.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Dismiss.ForeColor = System.Drawing.Color.Crimson;
            this.Dismiss.Location = new System.Drawing.Point(320, 477);
            this.Dismiss.Name = "Dismiss";
            this.Dismiss.Size = new System.Drawing.Size(148, 23);
            this.Dismiss.TabIndex = 1;
            this.Dismiss.Text = "Уволить с роботы";
            this.Dismiss.UseVisualStyleBackColor = false;
            this.Dismiss.Click += new System.EventHandler(this.Dismiss_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 173);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(12, 217);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(100, 20);
            this.tbSurname.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(12, 259);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 2;
            // 
            // tbDimiss
            // 
            this.tbDimiss.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbDimiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDimiss.ForeColor = System.Drawing.Color.YellowGreen;
            this.tbDimiss.Location = new System.Drawing.Point(340, 437);
            this.tbDimiss.Name = "tbDimiss";
            this.tbDimiss.Size = new System.Drawing.Size(100, 21);
            this.tbDimiss.TabIndex = 2;
            // 
            // lstMngTable
            // 
            this.lstMngTable.BackColor = System.Drawing.Color.Wheat;
            this.lstMngTable.ForeColor = System.Drawing.Color.Black;
            this.lstMngTable.FullRowSelect = true;
            this.lstMngTable.GridLines = true;
            this.lstMngTable.Location = new System.Drawing.Point(-6, 12);
            this.lstMngTable.Name = "lstMngTable";
            this.lstMngTable.RightToLeftLayout = true;
            this.lstMngTable.Size = new System.Drawing.Size(498, 136);
            this.lstMngTable.TabIndex = 3;
            this.lstMngTable.UseCompatibleStateImageBehavior = false;
            this.lstMngTable.SelectedIndexChanged += new System.EventHandler(this.lstMngTable_SelectedIndexChanged);
            // 
            // btnCasir
            // 
            this.btnCasir.BackColor = System.Drawing.Color.Silver;
            this.btnCasir.Location = new System.Drawing.Point(340, 173);
            this.btnCasir.Name = "btnCasir";
            this.btnCasir.Size = new System.Drawing.Size(92, 23);
            this.btnCasir.TabIndex = 4;
            this.btnCasir.Text = "Касиры";
            this.btnCasir.UseVisualStyleBackColor = false;
            this.btnCasir.Click += new System.EventHandler(this.btnCasir_Click);
            // 
            // btnWorker
            // 
            this.btnWorker.BackColor = System.Drawing.Color.Silver;
            this.btnWorker.Location = new System.Drawing.Point(341, 205);
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Size = new System.Drawing.Size(151, 23);
            this.btnWorker.TabIndex = 5;
            this.btnWorker.Text = "Роботники склада";
            this.btnWorker.UseVisualStyleBackColor = false;
            this.btnWorker.Click += new System.EventHandler(this.btnWorker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(273, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "IdDimiss";
            // 
            // labMngTable
            // 
            this.labMngTable.AutoSize = true;
            this.labMngTable.Location = new System.Drawing.Point(371, 413);
            this.labMngTable.Name = "labMngTable";
            this.labMngTable.Size = new System.Drawing.Size(43, 13);
            this.labMngTable.TabIndex = 7;
            this.labMngTable.Text = "______";
            // 
            // tbNumPhone
            // 
            this.tbNumPhone.Location = new System.Drawing.Point(12, 303);
            this.tbNumPhone.Name = "tbNumPhone";
            this.tbNumPhone.Size = new System.Drawing.Size(100, 20);
            this.tbNumPhone.TabIndex = 2;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(12, 347);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(12, 392);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(13, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Segoe Marker", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(9, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Segoe Marker", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(9, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Номер телефона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Segoe Marker", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(12, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Логин";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Segoe Marker", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(9, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Пароль";
            // 
            // rbAddCasir
            // 
            this.rbAddCasir.AutoSize = true;
            this.rbAddCasir.Location = new System.Drawing.Point(12, 418);
            this.rbAddCasir.Name = "rbAddCasir";
            this.rbAddCasir.Size = new System.Drawing.Size(114, 17);
            this.rbAddCasir.TabIndex = 9;
            this.rbAddCasir.TabStop = true;
            this.rbAddCasir.Text = "Добавить касира";
            this.rbAddCasir.UseVisualStyleBackColor = true;
            // 
            // rbAddWorker
            // 
            this.rbAddWorker.AutoSize = true;
            this.rbAddWorker.Location = new System.Drawing.Point(12, 442);
            this.rbAddWorker.Name = "rbAddWorker";
            this.rbAddWorker.Size = new System.Drawing.Size(163, 17);
            this.rbAddWorker.TabIndex = 9;
            this.rbAddWorker.TabStop = true;
            this.rbAddWorker.Text = "Добавить робочого склада";
            this.rbAddWorker.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Segoe Marker", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(165, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "просмотр робочих";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Segoe Marker", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(165, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Просмотр касиров";
            // 
            // lstNewProdPrice
            // 
            this.lstNewProdPrice.FullRowSelect = true;
            this.lstNewProdPrice.GridLines = true;
            this.lstNewProdPrice.Location = new System.Drawing.Point(565, 8);
            this.lstNewProdPrice.Name = "lstNewProdPrice";
            this.lstNewProdPrice.Size = new System.Drawing.Size(245, 229);
            this.lstNewProdPrice.TabIndex = 10;
            this.lstNewProdPrice.UseCompatibleStateImageBehavior = false;
            this.lstNewProdPrice.SelectedIndexChanged += new System.EventHandler(this.lstNewProdPrice_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(735, 347);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Применить";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbIdProd
            // 
            this.tbIdProd.Location = new System.Drawing.Point(777, 285);
            this.tbIdProd.Name = "tbIdProd";
            this.tbIdProd.Size = new System.Drawing.Size(53, 20);
            this.tbIdProd.TabIndex = 12;
            // 
            // tbNewPrice
            // 
            this.tbNewPrice.Location = new System.Drawing.Point(777, 311);
            this.tbNewPrice.Name = "tbNewPrice";
            this.tbNewPrice.Size = new System.Drawing.Size(53, 20);
            this.tbNewPrice.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SpringGreen;
            this.label10.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(635, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Номер продукта";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SpringGreen;
            this.label11.Font = new System.Drawing.Font("Segoe Marker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(635, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Новая цена";
            // 
            // btnProd
            // 
            this.btnProd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnProd.Location = new System.Drawing.Point(735, 240);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(75, 23);
            this.btnProd.TabIndex = 14;
            this.btnProd.Text = "Продукти";
            this.btnProd.UseVisualStyleBackColor = false;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(597, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Просмотр продуктов";
            // 
            // btnForm
            // 
            this.btnForm.Font = new System.Drawing.Font("SketchFlow Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm.ForeColor = System.Drawing.Color.Cyan;
            this.btnForm.Location = new System.Drawing.Point(299, 326);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(169, 23);
            this.btnForm.TabIndex = 16;
            this.btnForm.Text = "Дополнительно окно";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // ManegerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(842, 512);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbNewPrice);
            this.Controls.Add(this.tbIdProd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lstNewProdPrice);
            this.Controls.Add(this.rbAddWorker);
            this.Controls.Add(this.rbAddCasir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labMngTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWorker);
            this.Controls.Add(this.btnCasir);
            this.Controls.Add(this.lstMngTable);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbNumPhone);
            this.Controls.Add(this.tbDimiss);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.Dismiss);
            this.Controls.Add(this.Hire);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "ManegerForm";
            this.Text = "Maneger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseManegeer);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hire;
        private System.Windows.Forms.Button Dismiss;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbDimiss;
        private System.Windows.Forms.ListView lstMngTable;
        private System.Windows.Forms.Button btnCasir;
        private System.Windows.Forms.Button btnWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labMngTable;
        private System.Windows.Forms.TextBox tbNumPhone;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbAddCasir;
        private System.Windows.Forms.RadioButton rbAddWorker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lstNewProdPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbIdProd;
        private System.Windows.Forms.TextBox tbNewPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnForm;
    }
}