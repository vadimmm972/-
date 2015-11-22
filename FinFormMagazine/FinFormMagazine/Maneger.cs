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
    public partial class ManegerForm : Form
    {
        NewImplementation imp = new NewImplementation();
        private Form login;
        private bool flag = true;
        public ManegerForm(Form loginForm)
        {
            InitializeComponent();
            login = loginForm;
            Width = 500;
        }

        private void btnCasir_Click(object sender, EventArgs e)
        {
            labMngTable.Text = "Касир";
            lstMngTable.Clear();
            lstMngTable.View = View.Details;
            lstMngTable.Columns.Add("Number");
            lstMngTable.Columns.Add("Name");
            lstMngTable.Columns.Add("Surname");
            lstMngTable.Columns.Add("Lastname");
            lstMngTable.Columns.Add("NumberPhone");

            List<string[]> lst = imp.GetCasir();
            for (int i = 0; i < lst.Count; i++)
            {
                lstMngTable.Items.Add(new ListViewItem(lst[i]));
            }
          
        }

        private void CloseManegeer(object sender, FormClosingEventArgs e)
        {

            login.Show();
        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            labMngTable.Text = "Робочий склада";
            lstMngTable.Clear();
            lstMngTable.View = View.Details;
            lstMngTable.Columns.Add("Number");
            lstMngTable.Columns.Add("Name");
            lstMngTable.Columns.Add("Surname");
            lstMngTable.Columns.Add("Lastname");
            lstMngTable.Columns.Add("NumberPhone");

            List<string[]> lst = imp.GetWorker();
            for (int i = 0; i < lst.Count; i++)
            {
                lstMngTable.Items.Add(new ListViewItem(lst[i]));
            }
        }

        private void Dismiss_Click(object sender, EventArgs e)
        {
            int choice = 0;
            if (labMngTable.Text == "Касир")
            {
                choice = 1;
            }
            else if (labMngTable.Text == "Робочий склада")
            {
                choice = 2;
            }
            else
            {
                MessageBox.Show("Невірні дані");
                return;
            }
            tbDimiss.Text = tbDimiss.Text.Trim();
            imp.Dismiss(tbDimiss.Text,choice);
            lstMngTable.Clear();
        }

        private void lstMngTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMngTable.SelectedIndices.Count == 0)
            {
                return;
            }
            tbDimiss.Text=  lstMngTable.Items[lstMngTable.SelectedIndices[0]].SubItems[0].Text;
            

            //this.Text = lstMngTable.Items[lstMngTable.SelectedIndices[0]].SubItems[1].Text;
        }

        private void Hire_Click(object sender, EventArgs e)
        {
            int res = 0;
            if (rbAddCasir.Checked)
            {
                res = 1;
            }
            else if (rbAddWorker.Checked)
            {
                res = 2;
            }
            else
            {
                MessageBox.Show("Зробіть вибір");
                return;
            }
            tbName.Text = tbName.Text.Trim();
            tbSurname.Text = tbSurname.Text.Trim();
            tbLastName.Text = tbLastName.Text.Trim();
            tbNumPhone.Text = tbNumPhone.Text.Trim();
            tbLogin.Text = tbLogin.Text.Trim();
            tbPass.Text = tbPass.Text.Trim();

            imp.Hire(res,tbName.Text,tbSurname.Text,tbLastName.Text,tbNumPhone.Text,tbLogin.Text,tbPass.Text);

            tbName.Text = null;
            tbSurname.Text   = null;
            tbLastName.Text  = null;
            tbNumPhone.Text  = null;
            tbLogin.Text     = null;
            tbPass.Text      = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbIdProd.Text = tbIdProd.Text.Trim();
            tbNewPrice.Text = tbNewPrice.Text.Trim();

            imp.Update(tbIdProd.Text,tbNewPrice.Text);

            tbIdProd.Text = null;
            tbNewPrice.Text = null;
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            lstNewProdPrice.Clear();
            lstNewProdPrice.View = View.Details;
            lstNewProdPrice.Columns.Add("Номер");
            lstNewProdPrice.Columns.Add("Имя");
            lstNewProdPrice.Columns.Add("Номер категории");
            lstNewProdPrice.Columns.Add("Цена");
            lstNewProdPrice.Columns.Add("Количество");
            lstNewProdPrice.Columns.Add("Номер продукта");
            lstNewProdPrice.Columns.Add("Номер измерение");
            lstNewProdPrice.Columns.Add("номер наценки");
            //LoginForm f = new LoginForm(); f.Show();


            List<string[]> lst = imp.GetProduct();
            for (int i = 0; i < lst.Count; i++)
            {
                lstNewProdPrice.Items.Add(new ListViewItem(lst[i]));
            }
        }

        private void lstNewProdPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNewProdPrice.SelectedIndices.Count == 0)
            {
                return;
            }
            this.tbIdProd.Text = lstNewProdPrice.Items[lstNewProdPrice.SelectedIndices[0]].SubItems[0].Text;
            this.tbNewPrice.Text = lstNewProdPrice.Items[lstNewProdPrice.SelectedIndices[0]].SubItems[3].Text;
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                Width = 850;
                btnForm.Text = "Скрить";
                flag = false;
            }
            else
            {
                Width = 500;
                btnForm.Text = "Дополнительно окно";
                flag = true;
            }
           
        }
    }
}
