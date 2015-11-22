namespace FinFormMagazine
{
    partial class LoginForm
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbAdmins = new System.Windows.Forms.RadioButton();
            this.rbWorker = new System.Windows.Forms.RadioButton();
            this.rbManeger = new System.Windows.Forms.RadioButton();
            this.rbCasir = new System.Windows.Forms.RadioButton();
            this.Enter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(115, 135);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(51, 20);
            this.tbId.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(-3, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ваш номер";
            // 
            // rbAdmins
            // 
            this.rbAdmins.AutoSize = true;
            this.rbAdmins.Font = new System.Drawing.Font("Segoe Marker", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmins.Location = new System.Drawing.Point(115, 242);
            this.rbAdmins.Name = "rbAdmins";
            this.rbAdmins.Size = new System.Drawing.Size(147, 22);
            this.rbAdmins.TabIndex = 18;
            this.rbAdmins.TabStop = true;
            this.rbAdmins.Text = "Администратор";
            this.rbAdmins.UseVisualStyleBackColor = true;
            // 
            // rbWorker
            // 
            this.rbWorker.AutoSize = true;
            this.rbWorker.Font = new System.Drawing.Font("Segoe Marker", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWorker.Location = new System.Drawing.Point(115, 218);
            this.rbWorker.Name = "rbWorker";
            this.rbWorker.Size = new System.Drawing.Size(154, 22);
            this.rbWorker.TabIndex = 19;
            this.rbWorker.TabStop = true;
            this.rbWorker.Text = "Робочий склада";
            this.rbWorker.UseVisualStyleBackColor = true;
            // 
            // rbManeger
            // 
            this.rbManeger.AutoSize = true;
            this.rbManeger.Font = new System.Drawing.Font("Segoe Marker", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManeger.Location = new System.Drawing.Point(115, 190);
            this.rbManeger.Name = "rbManeger";
            this.rbManeger.Size = new System.Drawing.Size(107, 22);
            this.rbManeger.TabIndex = 17;
            this.rbManeger.TabStop = true;
            this.rbManeger.Text = "Менеджер";
            this.rbManeger.UseVisualStyleBackColor = true;
            // 
            // rbCasir
            // 
            this.rbCasir.AutoSize = true;
            this.rbCasir.Font = new System.Drawing.Font("Segoe Marker", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCasir.Location = new System.Drawing.Point(115, 161);
            this.rbCasir.Name = "rbCasir";
            this.rbCasir.Size = new System.Drawing.Size(67, 23);
            this.rbCasir.TabIndex = 16;
            this.rbCasir.TabStop = true;
            this.rbCasir.Text = "Касир";
            this.rbCasir.UseVisualStyleBackColor = true;
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.DarkOrange;
            this.Enter.Location = new System.Drawing.Point(107, 280);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 15;
            this.Enter.Text = "Войти";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(108, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "Вход";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Логин";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(115, 96);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(166, 20);
            this.tbPassword.TabIndex = 10;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(115, 57);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(166, 20);
            this.tbLogin.TabIndex = 11;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(322, 351);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbAdmins);
            this.Controls.Add(this.rbWorker);
            this.Controls.Add(this.rbManeger);
            this.Controls.Add(this.rbCasir);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbAdmins;
        private System.Windows.Forms.RadioButton rbWorker;
        private System.Windows.Forms.RadioButton rbManeger;
        private System.Windows.Forms.RadioButton rbCasir;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;


    }
}

