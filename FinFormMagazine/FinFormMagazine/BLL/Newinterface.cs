using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinFormMagazine.BLL
{
    interface Newinterface
    {

        ////////////////////////////////////////////// CasirForm
        List<string[]> GetSale();
        List<string[]> GetProduct();
        void SellProduct(string tbIdProduct, string Price, string Quantity);
        void InsertProd(string tbIdProduct, string Price, string Quantity, string Date);

        ////////////////////////////////////////////// Maneger

        List<string[]> GetCasir();
        List<string[]> GetWorker();

        void Dismiss(string IdDismiss, int ResDel);
        void Hire(int Choice,string Name, string Surname , string Lastname , string PhoneNumber , string Login , string Passwords);
        void Update(string IdProd, string NewPrice);

        ///////////////////////////////////////////////Worker

        List<string[]> GetDelivery();
        List<string[]> GetSupplier();

        void AddDelivery(string IdProd , string IdSupp , string Price , string Quant );
        List<string[]> GetMessument();
        List<string[]> GetMarkap();
        List<string[]> GetCategory();
        //////////////////////////////////////////ADMIN

        List<string[]> Manneger();
         void InsertAdmins(int res,string Id,  string Passwd);

    }
}
