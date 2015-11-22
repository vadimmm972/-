namespace FinFormMagazine
{
    partial class AdminForm
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
            this.lstAdmin = new System.Windows.Forms.ListView();
            this.btnManeger = new System.Windows.Forms.Button();
            this.btnCasirs = new System.Windows.Forms.Button();
            this.btnWorker = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSET = new System.Windows.Forms.Button();
            this.rbManeger = new System.Windows.Forms.RadioButton();
            this.rbCasir = new System.Windows.Forms.RadioButton();
            this.rbWorker = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstAdmin
            // 
            this.lstAdmin.FullRowSelect = true;
            this.lstAdmin.GridLines = true;
            this.lstAdmin.Location = new System.Drawing.Point(0, 5);
            this.lstAdmin.Name = "lstAdmin";
            this.lstAdmin.Size = new System.Drawing.Size(500, 150);
            this.lstAdmin.TabIndex = 0;
            this.lstAdmin.UseCompatibleStateImageBehavior = false;
            this.lstAdmin.SelectedIndexChanged += new System.EventHandler(this.lstAdmin_SelectedIndexChanged);
            // 
            // btnManeger
            // 
            this.btnManeger.Location = new System.Drawing.Point(12, 176);
            this.btnManeger.Name = "btnManeger";
            this.btnManeger.Size = new System.Drawing.Size(75, 23);
            this.btnManeger.TabIndex = 1;
            this.btnManeger.Text = "Менеджери";
            this.btnManeger.UseVisualStyleBackColor = true;
            this.btnManeger.Click += new System.EventHandler(this.btnManeger_Click);
            // 
            // btnCasirs
            // 
            this.btnCasirs.Location = new System.Drawing.Point(184, 176);
            this.btnCasirs.Name = "btnCasirs";
            this.btnCasirs.Size = new System.Drawing.Size(75, 23);
            this.btnCasirs.TabIndex = 1;
            this.btnCasirs.Text = "Касиры";
            this.btnCasirs.UseVisualStyleBackColor = true;
            this.btnCasirs.Click += new System.EventHandler(this.btnCasirs_Click);
            // 
            // btnWorker
            // 
            this.btnWorker.Location = new System.Drawing.Point(412, 176);
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Size = new System.Drawing.Size(75, 23);
            this.btnWorker.TabIndex = 1;
            this.btnWorker.Text = "Робочие";
            this.btnWorker.UseVisualStyleBackColor = true;
            this.btnWorker.Click += new System.EventHandler(this.btnWorker_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(184, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Изменение";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(215, 272);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(120, 20);
            this.tbId.TabIndex = 3;
            // 
            // tbPasswd
            // 
            this.tbPasswd.Location = new System.Drawing.Point(215, 298);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.PasswordChar = '*';
            this.tbPasswd.Size = new System.Drawing.Size(120, 20);
            this.tbPasswd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(157, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(89, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Новый пароль";
            // 
            // btnSET
            // 
            this.btnSET.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSET.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSET.Location = new System.Drawing.Point(249, 370);
            this.btnSET.Name = "btnSET";
            this.btnSET.Size = new System.Drawing.Size(75, 23);
            this.btnSET.TabIndex = 5;
            this.btnSET.Text = "Изменить";
            this.btnSET.UseVisualStyleBackColor = false;
            this.btnSET.Click += new System.EventHandler(this.btnSET_Click);
            // 
            // rbManeger
            // 
            this.rbManeger.AutoSize = true;
            this.rbManeger.Location = new System.Drawing.Point(158, 330);
            this.rbManeger.Name = "rbManeger";
            this.rbManeger.Size = new System.Drawing.Size(78, 17);
            this.rbManeger.TabIndex = 6;
            this.rbManeger.TabStop = true;
            this.rbManeger.Text = "Менеджер";
            this.rbManeger.UseVisualStyleBackColor = true;
            // 
            // rbCasir
            // 
            this.rbCasir.AutoSize = true;
            this.rbCasir.Location = new System.Drawing.Point(158, 353);
            this.rbCasir.Name = "rbCasir";
            this.rbCasir.Size = new System.Drawing.Size(56, 17);
            this.rbCasir.TabIndex = 6;
            this.rbCasir.TabStop = true;
            this.rbCasir.Text = "Касир";
            this.rbCasir.UseVisualStyleBackColor = true;
            // 
            // rbWorker
            // 
            this.rbWorker.AutoSize = true;
            this.rbWorker.Location = new System.Drawing.Point(158, 376);
            this.rbWorker.Name = "rbWorker";
            this.rbWorker.Size = new System.Drawing.Size(67, 17);
            this.rbWorker.TabIndex = 6;
            this.rbWorker.TabStop = true;
            this.rbWorker.Text = "Робочий";
            this.rbWorker.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(499, 243);
            this.Controls.Add(this.rbWorker);
            this.Controls.Add(this.rbCasir);
            this.Controls.Add(this.rbManeger);
            this.Controls.Add(this.btnSET);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPasswd);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnWorker);
            this.Controls.Add(this.btnCasirs);
            this.Controls.Add(this.btnManeger);
            this.Controls.Add(this.lstAdmin);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstAdmin;
        private System.Windows.Forms.Button btnManeger;
        private System.Windows.Forms.Button btnCasirs;
        private System.Windows.Forms.Button btnWorker;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbPasswd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSET;
        private System.Windows.Forms.RadioButton rbManeger;
        private System.Windows.Forms.RadioButton rbCasir;
        private System.Windows.Forms.RadioButton rbWorker;
    }
}