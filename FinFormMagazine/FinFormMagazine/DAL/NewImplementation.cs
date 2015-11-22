using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinFormMagazine.BLL
{
    internal class NewImplementation : Newinterface
    {
        private string GetConnectionString()
        {
            return @"Server=VADIM-PC;Database=MyMagazine; User=VadimLogin;Password=123456;  Integrated Security=false;";
        }

        ///////////////////////////////////////////Login






        ///////////////////////////////////////////EnLogin

        /// <summary>
        /// CasirForm
        /// </summary>
        /// <returns></returns>
        public List<string[]> GetSale()
        {
            string query = @"SELECT p.Name, s.DateSale , s.Price, s.Quantity 
                                FROM Product p , Sale s 
                                where p.IdProduct = s.IdProduct
                            ";

            List<string[]> result = new List<string[]>();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row = new string[]
                        {
                            reader["Name"].ToString(),
                            reader["DateSale"].ToString(),
                            reader["Price"].ToString(),
                            reader["Quantity"].ToString()

                        };
                        result.Add(row);
                    }

                }
            }
            catch (SqlException exception)
            {
                return new List<string[]>();
                // MessageBox.Show("lol");
            }
            return result;
        }

        public List<string[]> GetProduct()
        {
            string query = @"SELECT * From Product
                           ";
            // string query = @"SELECT  From Product p , Category , Producer pr , Measurement m ,Markup
            //     ";

            List<string[]> result = new List<string[]>();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row = new string[]
                        {
                            reader["IdProduct"].ToString(),
                            reader["Name"].ToString(),
                            reader["IdCategory"].ToString(),
                            reader["Price"].ToString(),
                            reader["Quantity"].ToString(),
                            reader["IdProducer"].ToString(),
                            reader["IdMeasurement"].ToString(),
                            reader["IdMarkup"].ToString()

                        };
                        result.Add(row);
                    }

                }
            }
            catch (SqlException exception)
            {
                return new List<string[]>();
                //  MessageBox.Show("lol");
            }
            return result;
        }

        public void SellProduct(string tbIdProduct, string Price, string Quantity)
        {
            string query;

            query = @"select Quantity from Product 
                        where IdProduct = " + tbIdProduct;
            //AND Quantity < 0 AND 4 > Quantity"  
            ;
            string row = null;
            int num = 0;
            //  String str = DateTime.Now.ToString("dd");
            String str = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        row = reader["Quantity"].ToString();
                    }
                    num = Convert.ToInt16(row);
                    if (Convert.ToInt16(Quantity) <= num)
                    {
                        InsertProd(tbIdProduct, Price, Quantity, str);
                        MessageBox.Show("Продано");
                    }
                    else
                    {
                        MessageBox.Show("Перевірте нвність товару");
                    }
                }


            }
            catch (SqlException exception)
            {
                //return new List<string[]>();
                //  MessageBox.Show("lol");
            }
            //return result;
        }

        public void InsertProd(string tbIdProduct, string Price, string Quantity, string Date)
        {
            string query;

            query = (@"insert into Sale values ( " + tbIdProduct + " , " + Price + " , " + Quantity + " , N' " + Date +
                     "' )"); //, IdProduct, Price, Quantity, Date);


            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Erorr!!!");
            }
        }

        /// <summary>
        /// EndCasir
        /// </summary>
        /// <returns></returns>

        ///////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Maneger
        /// </summary>
        /// <returns></returns>


        public List<string[]> GetCasir()
        {
            string query = @"SELECT * From Casir
                            ";

            List<string[]> result = new List<string[]>();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row = new string[]
                        {

                            reader["IdCasir"].ToString(),
                            reader["Name"].ToString(),
                            reader["Surname"].ToString(),
                            reader["Lastname"].ToString(),
                            reader["NumberPhone"].ToString(),
                            reader["Logins"].ToString(),
                            reader["Passwords"].ToString()

                        };
                        result.Add(row);
                    }

                }
            }
            catch (SqlException exception)
            {
                return new List<string[]>();
                //  MessageBox.Show("lol");
            }
            return result;
        }

        public List<string[]> GetWorker()
        {
            string query = @"SELECT * From WarWorker
                            ";

            List<string[]> result = new List<string[]>();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row = new string[]
                        {

                            reader["IdWarWorker"].ToString(),
                            reader["Name"].ToString(),
                            reader["Surname"].ToString(),
                            reader["Lastname"].ToString(),
                            reader["NumberPhone"].ToString(),
                             reader["Logins"].ToString(),
                            reader["Passwords"].ToString()

                        };
                        result.Add(row);
                    }

                }
            }
            catch (SqlException exception)
            {
                return new List<string[]>();
                //  MessageBox.Show("lol");
            }
            return result;
        }


        public void Dismiss(string IdDismiss, int ResDel)
        {
            string query = null;
            if (ResDel == 1)
            {
                query = string.Format(@"delete Casir where IdCasir = " + IdDismiss);
            }
            if (ResDel == 2)
            {
                query = string.Format(@"delete WarWorker where IdWarWorker = " + IdDismiss);
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("Виконано");
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        public void Hire(int Choice, string Name, string Surname, string Lastname, string PhoneNumber, string Login,
            string Passwords)
        {
            string query = null;
            if (Choice == 1)
            {
                query =
                    string.Format(@"INSERT INTO Casir VALUES ( " + "N'" + Name + "' , " + "N'" + Surname + "' , " + "N'" +
                                  Lastname + "' , " + "N' , " + PhoneNumber + "' , " + "N'" + Login + "' , " +
                                  Convert.ToInt16(Passwords) + " )");
                //query = string.Format(@"INSERT INTO Casir VALUES( N'{0}',N'{1}',N'{2}',N'{3},N'{4}' " + Passwords + " )", Name, Surname, Lastname, PhoneNumber, Login);

            }
            else if (Choice == 2)
            {
                query =
                    string.Format(@"INSERT INTO WarWorker VALUES ( " + "N'" + Name + "' , " + "N'" + Surname + "' , " +
                                  "N'" + Lastname + "' , " + "N' , " + PhoneNumber + "' , " + "N'" + Login + "' , " +
                                  Convert.ToInt16(Passwords) + " )");

                //query = string.Format(@"INSERT INTO WarWorker VALUES( N'{0}',N'{1}',N'{2}',N'{3},N'{4}', N'{5}' )", Name, Surname, Lastname, PhoneNumber, Login,Passwords);
            }
            else
            {
                MessageBox.Show("Ошибка");
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                }
                MessageBox.Show("Успішно добавлено");
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void Update(string IdProd, string NewPrice)
        {
            // string query = string.Format(@"UPDATE " + table + " SET " + colums + " = N'" + result + "' where " + IdChoice + " = " + id);
            string query = (@"update Product set Price = " + "N'" + NewPrice + "' where IdProduct = " + IdProd);

            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }




        /// <summary>
        /// EndManeger
        /// </summary>
        /// <returns></returns>
        /// ////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////Worker\\\\\\\\\\\\\\\\\


        public List<string[]> GetDelivery()
        {
            string query = @"SELECT  d.IdDelivery,p.Name, s.IdSupplier, d.Price, d.Quantity , d.DateDelivery 
                                FROM Product p , Delivery d ,Supplier s
                                where p.IdProduct = d.IdProduct
                                AND s.IdSupplier = d.IdSupplier
                            ";

            List<string[]> result = new List<string[]>();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row = new string[]
                        {
                            reader["IdDelivery"].ToString(),
                            reader["Name"].ToString(),
                            reader["IdSupplier"].ToString(),
                            reader["Price"].ToString(),
                            reader["Quantity"].ToString(),
                            reader["DateDelivery"].ToString(),

                        };
                        result.Add(row);
                    }

                }
            }
            catch (SqlException exception)
            {
                return new List<string[]>();
                // MessageBox.Show("lol");
            }
            return result;
        }

        public List<string[]> GetSupplier()
        {
            string query = @"Select IdSupplier , Name , IdAddress from Supplier ";


            List<string[]> result = new List<string[]>();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row = new string[]
                        {
                            reader["IdSupplier"].ToString(),
                            reader["Name"].ToString(),
                            reader["IdAddress"].ToString(),
                        };
                        result.Add(row);
                    }

                }
            }
            catch (SqlException exception)
            {
                return new List<string[]>();
            }
            return result;
        }

        public void AddDelivery(string IdProd, string IdSupp, string Price, string Quant)
        {
            String str = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            string query = String.Format(@"insert into Delivery values ({0} , {1} , {2} , {3} , " + "N'" + str + "')",
                IdProd, IdSupp, Price, Quant);

            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                }
                MessageBox.Show("Доставлено");
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        public List<string[]> GetMessument()
        {
            string query = (@"select * from Measurement")
                ;


            List<string[]> result = new List<string[]>();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row = new string[]
                        {

                            reader["IdMeasurement"].ToString(),
                            reader["Name"].ToString(),
                            reader["Description"].ToString()

                        };
                        result.Add(row);
                    }

                }
            }
            catch (SqlException exception)
            {
                return new List<string[]>();
                //  MessageBox.Show("lol");
            }
            return result;
        }

        public List<string[]> GetMarkap()
        {
            string query = (@"select * from Markup")
                ;


            List<string[]> result = new List<string[]>();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row = new string[]
                        {

                            reader["IdMarkup"].ToString(),
                            reader["Name"].ToString(),
                            reader["Percent"].ToString()

                        };
                        result.Add(row);
                    }

                }
            }
            catch (SqlException exception)
            {
                return new List<string[]>();
                //  MessageBox.Show("lol");
            }
            return result;
        }

        public List<string[]> GetCategory()
        {
            string query = (@"select * from Category")
                ;


            List<string[]> result = new List<string[]>();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row = new string[]
                        {

                            reader["IdCategory"].ToString(),
                            reader["Name"].ToString()
                        };
                        result.Add(row);
                    }

                }
            }
            catch (SqlException exception)
            {
                return new List<string[]>();
                //  MessageBox.Show("lol");
            }
            return result;
        }

        public void SetProducteds(string Name, string IdCategory, string Price, string Quantity, string Idproducer,
            string IdMeasurement, string IdMarkup)
        {
            string query =
                String.Format(@"insert into Product values (N'" + Name + "' , " + IdCategory + " , " + Price + " , " +
                              Quantity + " , " + Idproducer + " , " + IdMeasurement + " , " + IdMarkup + " )")
                ;

            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                }
                MessageBox.Show("Добавлено");
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /////////////////////////////////////////////ADMIN
        /// 
        /// 


        public List<string[]> Manneger()
        {
            string query = (@"select * from Manager")
                ;


            List<string[]> result = new List<string[]>();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row = new string[]
                        {

                            reader["IdManager"].ToString(),
                            reader["Name"].ToString(),
                            reader["Surname"].ToString(),
                            reader["Lastname"].ToString(),
                            reader["NumberPhone"].ToString(),
                            reader["Logins"].ToString(),
                            reader["Passwords"].ToString()

                        };
                        result.Add(row);
                    }

                }

            }
            catch (SqlException exception)
            {
                return new List<string[]>();
                //  MessageBox.Show("lol");
            }
            return result;
        }

        public void InsertAdmins(int res,string Id, string Passwd)
        {
            string query = null;
               ;
            if (res == 1)
            {
                query = (@"Update Manager Set Passwords = " + " N'" + Passwd + "' where IdManager = " + Id);
            }
            else if (res == 2)
            {
                query = (@"Update Casir Set Passwords  = " + " N'" + Passwd + "' where IdCasir = " + Id);
            }
            else if (res == 3)
            {
                query = (@"Update WarWorker Set Passwords = " + " N'" + Passwd + "' where IdWarWorker = " + Id);
            }
            else
            {
                MessageBox.Show("Проверте даные");
            }


            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                }
                MessageBox.Show("Измена произошла успешно");
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }



        }
    }
}

