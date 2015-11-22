using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinFormMagazine.BLL;

namespace FinFormMagazine
{
    public partial class AdminForm : Form
    {
        NewImplementation imp = new NewImplementation();
        private Form Admin;
        private bool flag = true;
        private int res = 0;
        public AdminForm(Form loginForm)
        {
            InitializeComponent();
            Admin = loginForm;
        }

        private void btnManeger_Click(object sender, EventArgs e)
        {
            lstAdmin.Clear();
            lstAdmin.View = View.Details;
            lstAdmin.Columns.Add("Номер");
            lstAdmin.Columns.Add("Имя");
            lstAdmin.Columns.Add("Фамилия");
            lstAdmin.Columns.Add("Отчество");
            lstAdmin.Columns.Add("Номер Т.");
            lstAdmin.Columns.Add("Логин");
            lstAdmin.Columns.Add("Пароль");

            List<string[]> lst = imp.Manneger();
            for (int i = 0; i < lst.Count; i++)
            {
                lstAdmin.Items.Add(new ListViewItem(lst[i]));
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Admin.Show();
        }

        private void btnCasirs_Click(object sender, EventArgs e)
        {
            lstAdmin.Clear();
            lstAdmin.View = View.Details;
            lstAdmin.Columns.Add("Номер");
            lstAdmin.Columns.Add("Имя");
            lstAdmin.Columns.Add("Фамилия");
            lstAdmin.Columns.Add("Отчество");
            lstAdmin.Columns.Add("Номер Т.");
            lstAdmin.Columns.Add("Логин");
            lstAdmin.Columns.Add("Пароль");

            List<string[]> lst = imp.GetCasir();
            for (int i = 0; i < lst.Count; i++)
            {
                lstAdmin.Items.Add(new ListViewItem(lst[i]));
            }
        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            lstAdmin.Clear();
            lstAdmin.View = View.Details;
            lstAdmin.Columns.Add("Номер");
            lstAdmin.Columns.Add("Имя");
            lstAdmin.Columns.Add("Фамилия");
            lstAdmin.Columns.Add("Отчество");
            lstAdmin.Columns.Add("Номер Т.");
            lstAdmin.Columns.Add("Логин");
            lstAdmin.Columns.Add("Пароль");

            List<string[]> lst = imp.GetWorker();
            for (int i = 0; i < lst.Count; i++)
            {
                lstAdmin.Items.Add(new ListViewItem(lst[i]));
            }
        }

        private void lstAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAdmin.SelectedIndices.Count == 0)
            {
                return;
            }
            tbId.Text = lstAdmin.Items[lstAdmin.SelectedIndices[0]].SubItems[0].Text;
        }

        private void btnSET_Click(object sender, EventArgs e)
        {
            tbId.Text = tbId.Text.Trim();
            tbPasswd.Text = tbPasswd.Text.Trim();

            if (rbManeger.Checked)
            {
                res = 1;
            }
            else if (rbCasir.Checked)
            {
                res = 2;
            }
            else if(rbWorker.Checked)
            {
                res = 3;
            }
            else
            {
                MessageBox.Show("Сдуeайте выбор");
                return;
                ;
            }

            imp.InsertAdmins(res, tbId.Text, tbPasswd.Text);

            tbId.Text = null;
            tbPasswd.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                Height = 450;
                flag = true;
            }
            else
            {
                Height = 270;
                flag = false;
            }
        }
    }
}
