using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinFormMagazine.BLL;
using FinFormMagazine.DAL;

namespace FinFormMagazine.UI
{
    class Implementation : InterfasceRes
    {
        NewImplementation newClass = new NewImplementation();
        private string GetConnectionString()
        {
            return @"Server=VADIM-PC;Database=MyMagazine; User=VadimLogin;Password=123456;  Integrated Security=false;";
        }
        /// <summary>
        /// CasirForm
        /// </summary>
        /// <returns></returns>

        public List<string[]> GetSale()
        {
            return newClass.GetSale();
            //string query = @"SELECT * from Product";
           
        }

        public List<string[]> GetProduct()
        {
            return newClass.GetProduct();
        }

        //public void SellProduct(string IdProduct, string Price, string Quantity, string Date)
        //{
        //    throw new NotImplementedException();
        //}

      public  void SellProduct(string tbIdProduct, string Price, string Quantity)
      {
          newClass.SellProduct(tbIdProduct, Price, Quantity);
      }

        public void InsertProd(string tbIdProduct, string Price, string Quantity, string Date)
        {
            newClass.InsertProd(tbIdProduct, Price, Quantity, Date);
        }


        /// <summary>
        /// CasirEnd
        /// </summary>
        /// <returns></returns>


        /// <summary>
        /// Maneger
        /// </summary>
        /// <returns></returns>
         public List<string[]> GetCasir()
        {
            return newClass.GetCasir();
        }

        public List<string[]> GetWorker()
        {
            return newClass.GetWorker();
        }

        public void Dismiss(string IdDismiss, int ResDel)
        {
            newClass.Dismiss(IdDismiss,ResDel);
        }


        public void Hire(int Choice,string Name, string Surname, string Lastname, string PhoneNumber, string Login,
            string Passwords)
        {
            if (Choice == null || Name == null || Surname == null || Lastname == null || PhoneNumber == null ||
                Login == null || Passwords == null)
            {
                MessageBox.Show("Незаповнена колонка");
                return;
            }
            newClass.Hire(Choice,Name, Surname, Lastname, PhoneNumber, Login,
                Passwords);
        }

        public void Update(string IdProd, string NewPrice)
        {
            newClass.Update(IdProd, NewPrice);
        }

        /// <summary>
        /// EndManeger
        /// </summary>
        /// <returns></returns>




        ////////////////////////////////////////WORKER\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\



        public List<string[]> GetDelivery()
        {
            return newClass.GetDelivery();
        }

        public List<string[]> GetSupplier()
        {
            return newClass.GetSupplier();
        }

        public void AddDelivery(string IdProd, string IdSupp, string Price, string Quant)
        {
            newClass.AddDelivery(IdProd, IdSupp, Price, Quant);
        }

        public List<string[]> GetMessument()
        {
            return newClass.GetMessument();
        }

        public List<string[]> GetMarkap()
        {
            return newClass.GetMarkap();
        }

        public List<string[]> GetCategory()
        {
            return newClass.GetCategory();
        }

        public void SetProducteds(string Name, string IdCategory, string Price, string Quantity, string Idproducer,
            string IdMeasurement, string IdMarkup)
        {
            if (Name != null || IdCategory != null || Price != null || Quantity != null || Idproducer != null ||
                IdMeasurement != null || IdMarkup != null)
            {
                newClass.SetProducteds(Name, IdCategory, Price, Quantity, Idproducer,
                    IdMeasurement, IdMarkup);
            }
            else
            {
                MessageBox.Show("Невірні дані");
            }
        }


        ///////////////////////////////////////////ADMIN



        public List<string[]> Manneger()
        {
           return newClass.Manneger();
        }
    }
}

