using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoenOkrug
{
    public partial class Form1 : Form
    {

        string connectionString = @"Data Source = DESKTOP-NRFOUM2\VITALIY;Initial Catalog = VoenOkr; Integrated Security = True";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            changeLogPass();
        }

        private void changeLogPass()
        {
            try
            {
                if (textBoxLoginAuthorization != null && textBoxPasswordAuthorization != null)
                {
                    string LoginPerson = textBoxLoginAuthorization.Text;
                    string PasswordPerson = textBoxPasswordAuthorization.Text;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {


                        string sql = "SELECT * FROM Users WHERE Login = @lP AND Password = @pP";
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.Add("@lP", SqlDbType.VarChar).Value = LoginPerson;
                        command.Parameters.Add("@pP", SqlDbType.VarChar).Value = PasswordPerson;



                        var Error = command.ExecuteScalar();
                        if (Error != null)
                        {
                            Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Данные введены не верно");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Вы что-то не заполнели");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }

        }
    }
}
