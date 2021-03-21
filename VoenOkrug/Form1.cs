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

        SqlDataAdapter DBAdapter;
        SqlConnection DBConnection;
        SqlCommand DBCommand;
        DataSet DBDataSet;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            changeLogPass();
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void changeLogPass()
        {

        }

        void GetList()
        {
            DBConnection = new SqlConnection(connectionString);
            DBAdapter = new SqlDataAdapter($"SELECT * FROM Users WHERE Login = {textBoxLoginAuthorization.Text} AND Password = {textBoxPasswordAuthorization.Text} ", DBConnection);
            DBDataSet = new DataSet();
            DBConnection.Open();
            DBAdapter.Fill(DBDataSet, "Users");
            
            DBConnection.Close();
        }

    }
}
