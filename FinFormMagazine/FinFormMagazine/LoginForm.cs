using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinFormMagazine.BLL;

namespace FinFormMagazine
{
    public partial class LoginForm : Form
    {
        NewImplementation news = new NewImplementation();
        public LoginForm()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }
        private string GetConnectionString()
        {
            return @"Server=VADIM-PC;Database=MyMagazine; User=VadimLogin;Password=123456;  Integrated Security=false;";
        }

        private void Enter_Click_1(object sender, EventArgs e)
        {

            int result = 0;
            string query = null;
            tbLogin.Text = tbLogin.Text.Trim();
            tbPassword.Text = tbPassword.Text.Trim();
           //int num = Convert.ToInt32(tbPassword.Text);
            if (rbCasir.Checked)
            {
                result = 1;
                // query = (@"Select * from Casir where  IdCasir = 14623784687236 AND Logins = N'mycas' AND Passwords = N'11222'");
                query = string.Format(@"Select Name from Casir where  IdCasir = " + tbId.Text + " AND Logins = " + "N'" + tbLogin.Text + "'" + " AND Passwords = N'" + tbPassword.Text + "'" );
               // query = string.Format(@"Select Lastname , Name , Surname from Casir where  IdCasir = " + tbId.Text + " AND Logins = " + "N'" + tbLogin.Text + "'" + " AND Passwords = N'" + tbPassword.Text + "'" );
            }
            else if (rbManeger.Checked)
            {
                query = string.Format(@"Select * from Manager where  IdManager = " + tbId.Text + " AND Logins = " + "N'" + tbLogin.Text + "'" + " AND Passwords = N'" + tbPassword.Text + "'");
                result = 2;
               // query = string.Format(@"Select Name from Manager where  IdManager = " + tbId.Text + " AND Logins = " + "N'" + tbLogin.Text + " '" + " AND Passwords = " + tbPassword.Text);
            }
            else if (rbWorker.Checked)
            {
                query = string.Format(@"Select * from WarWorker where  IdWarWorker = " + tbId.Text + " AND Logins = " + "N'" + tbLogin.Text + "'" + " AND Passwords = N'" + tbPassword.Text + "'");
                result = 3;
                //query = string.Format(@"Select Name from WarWorker where  IdWarWorker = " + tbId.Text + " AND Logins = " + "N'" + tbLogin.Text + " '" + " AND Passwords = " + tbPassword.Text);
            }
            else if (rbAdmins.Checked)
            {
                query = string.Format(@"Select * from Admins where  IdAdmins = " + tbId.Text + " AND Logins = " + "N'" + tbLogin.Text + "'" + " AND Passwords = N'" + tbPassword.Text + "'");
                result = 4;
                //query = string.Format(@"Select Name from Admins where  IdAdmins = " + tbId.Text + " AND Logins = " + "N'" + tbLogin.Text + " '" + " AND Passwords = " + tbPassword.Text);
            }
            else
            {
                MessageBox.Show("Зробіть вибір");
                return;
            }
            try
            {

                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                   
                    if (!reader.Read())
                    {
                        MessageBox.Show("______Невірні дані______");
                        return;
                    }
                }

                Choice(result);
                tbId.Text = null;
                tbLogin.Text = null;
                tbPassword.Text = null;
                rbManeger.Checked = false;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }

         //  query = (@"Select * from Casir where  IdCasir = " + tbId.Text + " AND Logins = " + "N'" + tbLogin.Text + " '" + " AND Passwords = " + num);
            //query = (@"Select Name from Casir where  IdCasir = 11 AND Logins = N'mycas' AND Passwords = N'11sad22'");
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            //    {
            //        connection.Open();
            //        SqlCommand command = new SqlCommand(query, connection);
            //        SqlDataReader reader = command.ExecuteReader();
            //    }
            //}
            //catch (SqlException exception)
            //{
            //    MessageBox.Show(exception.Message);
            //}
        }

        public void Choice(int res)
        {
            if (res == 1)
            {

                CasirForm c = new CasirForm(this);
                c.Show();
                this.Hide();
            }
            else if (res == 2)
            {
                ManegerForm m = new ManegerForm(this);
                m.Show();
                this.Hide();
            }
            else if (res == 3)
            {
                FormWorker work = new FormWorker(this);
                work.Show();
                this.Hide();
            }


        }

       
    }
}
