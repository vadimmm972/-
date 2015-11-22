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
using FinFormMagazine.DAL;

namespace FinFormMagazine
{
    public partial class CasirForm : Form
    {
        NewImplementation imp = new NewImplementation();
        private Form login;
        public CasirForm( Form loginForm )
        {
            InitializeComponent();
            login = loginForm;
        }

        private void OpenChek_Click(object sender, EventArgs e)
        {
            lstChek.Clear();
            lstChek.View = View.Details;
            lstChek.Columns.Add("Name");
            lstChek.Columns.Add("DateSale");
            lstChek.Columns.Add("Price");
            lstChek.Columns.Add("Quantity");

            List<string[]> lst = imp.GetSale();
            for (int i = 0; i < lst.Count; i++)
            {
                lstChek.Items.Add(new ListViewItem(lst[i]));
            }
        }

        private void GetProduct_Click(object sender, EventArgs e)
        {
            lstChek.Clear();
            lstChek.View = View.Details;
            lstChek.Columns.Add("Номер");
            lstChek.Columns.Add("Имя");
            lstChek.Columns.Add("Номер категории");
            lstChek.Columns.Add("Цена");
            lstChek.Columns.Add("Количество");
            lstChek.Columns.Add("Номер продукта");
            lstChek.Columns.Add("Номер измерение");
            lstChek.Columns.Add("номер наценки");
            //LoginForm f = new LoginForm(); f.Show();


            List<string[]> lst = imp.GetProduct();
            for (int i = 0; i < lst.Count; i++)
            {
                lstChek.Items.Add(new ListViewItem(lst[i]));
            }
        }

        private void Sell_Click(object sender, EventArgs e)
        {
              lstChek.Clear();
              tbPrice.Text = tbPrice.Text.Trim();
              tbQuantity.Text = tbQuantity.Text.Trim();
              //tbDate.Text = tbDate.Text.Trim();
            
            imp.SellProduct(IdProd.Text, tbPrice.Text, tbQuantity.Text);
        }

        private void lstChek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstChek.SelectedIndices.Count == 0)
            {
                return;
            }
            this.IdProd.Text = lstChek.Items[lstChek.SelectedIndices[0]].SubItems[0].Text;
            this.tbPrice.Text = lstChek.Items[lstChek.SelectedIndices[0]].SubItems[3].Text;
            this.Text = lstChek.Items[lstChek.SelectedIndices[0]].SubItems[1].Text;

            
        }

        private void CloseCasir(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

  
    }
}
