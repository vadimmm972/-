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

        }
    }
}
