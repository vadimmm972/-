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
    public partial class FormWorker : Form
    {
        private Form worker;
        private bool Shop = true;
        private bool flag = true;
        private bool sup = true;
        private bool IdMesurment = true;
        private bool IdMarkup = true;
        private bool idCategory = true;
        private bool IdMessurment = true;
        private bool IdProducer= true;
        NewImplementation imp = new NewImplementation();
        public FormWorker(Form loginForm)
        {
            InitializeComponent();
            worker = loginForm;
        }

        private void btnOPen_Click(object sender, EventArgs e)
        {
           
            sup = true;
            flag = true;
            sup = true;
            IdMesurment = true;
            IdMarkup = true;
            idCategory = true;
            IdMessurment = true;
            IdProducer = true;
            lstDelivery.Clear();
            lstDelivery.View = View.Details;
            lstDelivery.Columns.Add("Номер товара");
            lstDelivery.Columns.Add("Товар");
            lstDelivery.Columns.Add("Номер постачалника");
            lstDelivery.Columns.Add("Цена");
            lstDelivery.Columns.Add("Количество");
            lstDelivery.Columns.Add("Дата поставки");

            List<string[]> lst = imp.GetDelivery();
            for (int i = 0; i < lst.Count; i++)
            {
                lstDelivery.Items.Add(new ListViewItem(lst[i]));
            }
        }

        private void FormWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            worker.Show();
        }

        private void lstDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstDelivery.SelectedIndices.Count == 0)
            {
                return;
            }
             if (flag == false)
            {
                this.tbIdProd.Text = lstDelivery.Items[lstDelivery.SelectedIndices[0]].SubItems[0].Text;
                this.tbPrice.Text = lstDelivery.Items[lstDelivery.SelectedIndices[0]].SubItems[3].Text;
                this.Quantity.Text = lstDelivery.Items[lstDelivery.SelectedIndices[0]].SubItems[4].Text;
                //sup = true;
                 
            }
            else if (sup == false)
            {
                tbIdProducerProd.Text = tbIdSupp.Text = lstDelivery.Items[lstDelivery.SelectedIndices[0]].SubItems[0].Text;
              //  flag = true;
            }

            else  if (idCategory == false)
            {
                tbCategoryProd.Text = lstDelivery.Items[lstDelivery.SelectedIndices[0]].SubItems[0].Text;
            }
             //else if (IdProducer == false)
             //{
             //    tbIdProducerProd.Text = lstDelivery.Items[lstDelivery.SelectedIndices[0]].SubItems[0].Text;
             //}
             else if (IdMessurment == false)
             {
                 tbIdMasurmentProd.Text = lstDelivery.Items[lstDelivery.SelectedIndices[0]].SubItems[0].Text;
             }

             else if (IdMarkup == false)
             {
                 tbMarkup.Text = lstDelivery.Items[lstDelivery.SelectedIndices[0]].SubItems[0].Text;
             }

        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            flag = false;
            sup = true;
            IdMesurment = true;
            IdMarkup = true;
            idCategory = true;
            IdMessurment = true;
            IdProducer = true;
            lstDelivery.Clear();
            lstDelivery.View = View.Details;
            lstDelivery.Columns.Add("Номер");
            lstDelivery.Columns.Add("Имя");
            lstDelivery.Columns.Add("Номер категории");
            lstDelivery.Columns.Add("Цена");
            lstDelivery.Columns.Add("Количество");
            lstDelivery.Columns.Add("Номер продукта");
            lstDelivery.Columns.Add("Номер измерение");
            lstDelivery.Columns.Add("номер наценки");
            //LoginForm f = new LoginForm(); f.Show();


            List<string[]> lst = imp.GetProduct();
            for (int i = 0; i < lst.Count; i++)
            {
                lstDelivery.Items.Add(new ListViewItem(lst[i]));
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            sup = false;
            flag = true;
            IdMesurment = true;
            IdMarkup = true;
            idCategory = true;
            IdMessurment = true;
            IdProducer = true;


            lstDelivery.Clear();
            lstDelivery.View = View.Details;
            lstDelivery.Columns.Add("Номер");
            lstDelivery.Columns.Add("Имя");
            lstDelivery.Columns.Add("Номер адреси");

            List<string[]> lst = imp.GetSupplier();
            for (int i = 0; i < lst.Count; i++)
            {
                lstDelivery.Items.Add(new ListViewItem(lst[i]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbIdProd.Text = tbIdProd.Text.Trim();
            tbIdSupp.Text = tbIdSupp.Text.Trim();
            tbPrice.Text = tbPrice.Text.Trim();
            Quantity.Text = Quantity.Text.Trim();

            imp.AddDelivery(tbIdProd.Text, tbIdSupp.Text, tbPrice.Text, Quantity.Text);

            tbIdProd.Text = null;
            tbIdSupp.Text =null;
            tbPrice.Text  =null;
            Quantity.Text =null;
        }

        private void bntMesserment_Click(object sender, EventArgs e)
        {
            flag = true;
            sup = true;
            IdMesurment = true;
            IdMarkup = true;
            idCategory = true;
            IdMessurment = false;
            IdProducer = true;
            lstDelivery.Clear();
            lstDelivery.View = View.Details;
            lstDelivery.Columns.Add("Номер");
            lstDelivery.Columns.Add("Имя");
            lstDelivery.Columns.Add("Одиниця вимірювання");

            List<string[]> lst = imp.GetMessument();
            for (int i = 0; i < lst.Count; i++)
            {
                lstDelivery.Items.Add(new ListViewItem(lst[i]));
            }
        }

        private void btnMarkap_Click(object sender, EventArgs e)
        {
            flag = true;
            sup = true;
            IdMesurment = true;
            IdMarkup = false;
            idCategory = true;
            IdMessurment = true;
            IdProducer = true;
            lstDelivery.Clear();
            lstDelivery.View = View.Details;
            lstDelivery.Columns.Add("Номер");
            lstDelivery.Columns.Add("Имя");
            lstDelivery.Columns.Add("Скидка");

            List<string[]> lst = imp.GetMarkap();
            for (int i = 0; i < lst.Count; i++)
            {
                lstDelivery.Items.Add(new ListViewItem(lst[i]));
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            idCategory = false;
            sup = true;
            flag = true;
            IdMesurment = true;
            IdMarkup = true;
            IdMessurment = true;
            IdProducer = true;
            lstDelivery.Clear();
            lstDelivery.View = View.Details;
            lstDelivery.Columns.Add("Номер");
            lstDelivery.Columns.Add("Имя");

            List<string[]> lst = imp.GetCategory();
            for (int i = 0; i < lst.Count; i++)
            {
                lstDelivery.Items.Add(new ListViewItem(lst[i]));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbNameProd.Text = tbNameProd.Text.Trim();
            tbCategoryProd.Text = tbCategoryProd.Text.Trim();
            tbPeiceProd.Text = tbPeiceProd.Text.Trim();
            tbQuantityProd.Text = tbQuantityProd.Text.Trim();
            tbIdProducerProd.Text = tbIdProducerProd.Text.Trim();
            tbIdMasurmentProd.Text = tbIdMasurmentProd.Text.Trim();
            tbMarkup.Text = tbMarkup.Text.Trim();

            imp.SetProducteds(tbNameProd.Text, tbCategoryProd.Text, tbPeiceProd.Text, tbQuantityProd.Text, tbIdProducerProd.Text, tbIdMasurmentProd.Text, tbMarkup.Text);

            tbNameProd.Text =           null;
            tbCategoryProd.Text =       null;
            tbPeiceProd.Text = null;
            tbQuantityProd.Text = null;
            tbIdProducerProd.Text = null;
            tbIdMasurmentProd.Text =    null;
            tbMarkup.Text = null;

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (!Shop)
            {
                Height = 253;
                Shop = true;
            }
            else
            {
                Height = 505;
                Shop = false;
            }
        }
    }
}
