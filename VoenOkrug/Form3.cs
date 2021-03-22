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
    public partial class Form3 : Form
    {
        readonly string connectionString = @"Data Source = DESKTOP-NRFOUM2\VITALIY;Initial Catalog = VoenOkr; Integrated Security = True";

        SqlDataAdapter DBAdapter;
        SqlConnection DBConnection;
        SqlCommand DBCommand;
        DataSet DBDataSet;

        public Form3()
        {
            InitializeComponent();
            GetListUser();
        }

        //================Пользьзователь================//

        //Получение данных из таблицы Users
        void GetListUser()
        {
            DBConnection = new SqlConnection(connectionString);
            DBAdapter = new SqlDataAdapter("SELECT * FROM Users ORDER BY ID_User", DBConnection);
            DBDataSet = new DataSet();
            DBConnection.Open();
            DBAdapter.Fill(DBDataSet, "Users");
            dataGridViewUsers.DataSource = DBDataSet.Tables["Users"];
            DBConnection.Close();
        }

        //Добавление пользователя
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (textBoxLoginUser.Text == "" && textBoxPasswordUser.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("INSERT INTO Users (Login, Password) values ('{0}','{1}')", textBoxLoginUser.Text, textBoxPasswordUser.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListUser();
            }
        }

        //Удаление пользователя
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {

            if (textBoxLoginUser.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("DELETE FROM Users WHERE Login = '{0}'", textBoxLoginUser.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListUser();
            }
        }

        //Преобразование пользователя
        private void buttonResetUser_Click(object sender, EventArgs e)
        {
            if (textBoxLoginUser.Text == "" && textBoxPasswordUser.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("UPDATE Users SET Login='{0}', Password='{1}' WHERE Login='{0}'", textBoxLoginUser.Text, textBoxPasswordUser.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListUser();
            }
        }

        //================Пользьзователь================//
    }
}
