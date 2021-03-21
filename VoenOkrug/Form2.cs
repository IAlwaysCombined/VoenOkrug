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
    public partial class Form2 : Form
    {

        readonly string connectionString = @"Data Source = DESKTOP-NRFOUM2\VITALIY;Initial Catalog = VoenOkr; Integrated Security = True";

        SqlDataAdapter DBAdapter;
        SqlConnection DBConnection;
        SqlCommand DBCommand;
        DataSet DBDataSet;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetListUser();
            GetListRank();
            GetListSpeciality();
            GetListEmployee();
            GetListEquipment();
            GetListDislocation();
            GetListMilitaryUnit();
            GetListDistribution();


            //================ID Rank================//
            DBAdapter = new SqlDataAdapter("SELECT * FROM Rank ORDER BY ID_Rank", DBConnection);
            DataTable tbl = new DataTable();
            DBAdapter.Fill(tbl);
            comboBoxIDRank.DataSource = tbl;
            comboBoxIDRank.DisplayMember = "Name_Rank";
            comboBoxIDRank.ValueMember = "ID_Rank";
            //================ID Rank================//


            //================ID Speciality================//
            DBAdapter = new SqlDataAdapter("SELECT * FROM Military_Speciality ORDER BY ID_Speciality", DBConnection);
            DataTable tbl2 = new DataTable();
            DBAdapter.Fill(tbl2);
            comboBoxIDMilitarySpeciality.DataSource = tbl2;
            comboBoxIDMilitarySpeciality.DisplayMember = "Name_Speciality";
            comboBoxIDMilitarySpeciality.ValueMember = "ID_Speciality";
            //================ID Speciality================//

            //================ID Equipment================//
            DBAdapter = new SqlDataAdapter("SELECT * FROM Equipment ORDER BY ID_Equipment", DBConnection);
            DataTable tbl3 = new DataTable();
            DBAdapter.Fill(tbl3);
            comboBoxIDEquipment.DataSource = tbl3;
            comboBoxIDEquipment.DisplayMember = "Name_Equipment";
            comboBoxIDEquipment.ValueMember = "ID_Equipment";
            //================ID Equipment================//

            //================ID Dislication================//
            DBAdapter = new SqlDataAdapter("SELECT * FROM Dislocation ORDER BY ID_Dislocation", DBConnection);
            DataTable tbl4 = new DataTable();
            DBAdapter.Fill(tbl4);
            comboBoxIDDislication.DataSource = tbl4;
            comboBoxIDDislication.DisplayMember = "Fed_Destr";
            comboBoxIDDislication.ValueMember = "ID_Dislocation";
            //================ID Dislication================//

            //================ID Employee================//
            DBAdapter = new SqlDataAdapter("SELECT * FROM Employee ORDER BY ID_Employee", DBConnection);
            DataTable tbl5 = new DataTable();
            DBAdapter.Fill(tbl5);
            comboBoxIDEmployee.DataSource = tbl5;
            comboBoxIDEmployee.DisplayMember = "Last_Name";
            comboBoxIDEmployee.ValueMember = "ID_Employee";
            //================ID Employee================//

            //================ID Military Unit================//
            DBAdapter = new SqlDataAdapter("SELECT * FROM Military_Unit ORDER BY ID_Unit", DBConnection);
            DataTable tbl6 = new DataTable();
            DBAdapter.Fill(tbl6);
            comboBoxMilitaruUnit.DataSource = tbl6;
            comboBoxMilitaruUnit.DisplayMember = "Name_Unit";
            comboBoxMilitaruUnit.ValueMember = "ID_Unit";
            //================ID Military Unit================//
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



        //================Служащий================//

        //Получение данных из таблицы Rank 
        void GetListRank()
        {
            DBConnection = new SqlConnection(connectionString);
            DBAdapter = new SqlDataAdapter("SELECT * FROM Rank ORDER BY ID_Rank", DBConnection);
            DBDataSet = new DataSet();
            DBConnection.Open();
            DBAdapter.Fill(DBDataSet, "Rank");
            dataGridViewRank.DataSource = DBDataSet.Tables["Rank"];
            DBConnection.Close();
        }

        //Получение данных из таблицы Military_Speciality
        void GetListSpeciality()
        {
            DBConnection = new SqlConnection(connectionString);
            DBAdapter = new SqlDataAdapter("SELECT * FROM Military_Speciality ORDER BY ID_Speciality", DBConnection);
            DBDataSet = new DataSet();
            DBConnection.Open();
            DBAdapter.Fill(DBDataSet, "Military_Speciality");
            dataGridViewSpeciality.DataSource = DBDataSet.Tables["Military_Speciality"];
            DBConnection.Close();
        }

        //Получение данных из таблицы Employee
        void GetListEmployee()
        {
            DBConnection = new SqlConnection(connectionString);
            DBAdapter = new SqlDataAdapter("SELECT * FROM Employee ORDER BY ID_Employee", DBConnection);
            DBDataSet = new DataSet();
            DBConnection.Open();
            DBAdapter.Fill(DBDataSet, "Employee");
            dataGridView4.DataSource = DBDataSet.Tables["Employee"];
            DBConnection.Close();
        }

        //Добавление звания
        private void buttonAddRank_Click(object sender, EventArgs e)
        {
            if (textBoxRankName.Text == "" )
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("INSERT INTO Rank (Name_Rank) values ('{0}')", textBoxRankName.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListRank();
            }
        }

        //Удаление звания
        private void buttonDeleteRank_Click(object sender, EventArgs e)
        {
            if (textBoxRankName.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("DELETE FROM Rank WHERE Name_Rank = '{0}'", textBoxRankName.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListRank();
            }
        }

        //Добавление специальности
        private void buttonAddSpeciality_Click(object sender, EventArgs e)
        {
            if(textBoxNameMilitarySpeciality.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("INSERT INTO Military_Speciality (Name_Speciality) values ('{0}')", textBoxNameMilitarySpeciality.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListSpeciality();
            }
        }

        //Удаление специльности
        private void buttonDeleteSpeciality_Click(object sender, EventArgs e)
        {
            if (textBoxNameMilitarySpeciality.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("DELETE FROM Military_Speciality WHERE Name_Speciality = '{0}'", textBoxNameMilitarySpeciality.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListRank();
            }
        }

        //Добавление служащего
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "" && textBoxName.Text == "" && textBoxMiddleName.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                string ID_Speciality = comboBoxIDMilitarySpeciality.SelectedValue.ToString();
                string ID_Rank = comboBoxIDRank.SelectedValue.ToString();
                string Date_Birth = dateTimePickerDateBirth.Text.ToString();
                string Date_Call = dateTimePickerDateCall.Text.ToString();

                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("INSERT INTO Employee (Name, Last_Name, Middle_Name, Date_Birth, Date_Call, Speciality_ID, Rank_ID) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", textBoxName.Text, textBoxLastName.Text, textBoxMiddleName.Text, Date_Birth, Date_Call, ID_Speciality, ID_Rank);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListSpeciality();
            }
        }

        //Удаление служащего по имени 
        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("DELETE FROM Employee WHERE Name = '{0}'", textBoxName.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListEmployee();
            }
        }

        //Редактирование служащего
        private void buttonResetEmployee_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "" && textBoxName.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("UPDATE Employee SET Name='{0}', Last_Name='{1}' WHERE Name='{0}'", textBoxName.Text, textBoxLastName.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListEmployee();
            }
        }

        //================Служащий================//


        //================Воинская единица================//

        //Получение данных из таблицы Equipment
        void GetListEquipment()
        {
            DBConnection = new SqlConnection(connectionString);
            DBAdapter = new SqlDataAdapter("SELECT * FROM Equipment ORDER BY ID_Equipment", DBConnection);
            DBDataSet = new DataSet();
            DBConnection.Open();
            DBAdapter.Fill(DBDataSet, "Equipment");
            dataGridViewEquipment.DataSource = DBDataSet.Tables["Equipment"];
            DBConnection.Close();
        }

        //Получение данных из таблицы Dislocation
        void GetListDislocation()
        {
            DBConnection = new SqlConnection(connectionString);
            DBAdapter = new SqlDataAdapter("SELECT * FROM Dislocation ORDER BY ID_Dislocation", DBConnection);
            DBDataSet = new DataSet();
            DBConnection.Open();
            DBAdapter.Fill(DBDataSet, "Dislocation");
            dataGridViewDislocation.DataSource = DBDataSet.Tables["Dislocation"];
            DBConnection.Close();
        }

        //Получение данных из таблицы Military Unit
        void GetListMilitaryUnit()
        {
            DBConnection = new SqlConnection(connectionString);
            DBAdapter = new SqlDataAdapter("SELECT * FROM Military_Unit ORDER BY ID_Unit", DBConnection);
            DBDataSet = new DataSet();
            DBConnection.Open();
            DBAdapter.Fill(DBDataSet, "Military_Unit");
            dataGridViewMilitaryUnit.DataSource = DBDataSet.Tables["Military_Unit"];
            DBConnection.Close();
        }

        //Добавление техники
        private void buttonAddEquipment_Click(object sender, EventArgs e)
        {
            if (textBoxEquipment.Text == "" && textBoxWayToTravel.Text == "" && textBoxAttribute.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("INSERT INTO Equipment (Name_Equipment, Way_To_Travel, Attribute) values ('{0}', '{1}', '{2}')", textBoxEquipment.Text, textBoxWayToTravel.Text, textBoxAttribute.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListEquipment();
            }
        }

        //Удаление техники
        private void buttonDeleteEquipment_Click(object sender, EventArgs e)
        {
            if (textBoxEquipment.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("DELETE FROM Equipment WHERE Name_Equipment = '{0}'", textBoxEquipment.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListEquipment();
            }
        }

        //Редактирование техники
        private void buttonResetEquipment_Click(object sender, EventArgs e)
        {
            if (textBoxEquipment.Text == "" && textBoxAttribute.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("UPDATE Equipment SET Name_Equipment='{0}', Attribute='{1}' WHERE Name_Equipment='{0}'", textBoxEquipment.Text, textBoxAttribute.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListEquipment();
            }
        }

        //Добавление дислокации
        private void buttonAddDislication_Click(object sender, EventArgs e)
        {
            if (textBoxFed_Destr.Text == "" && textBoxLandscape.Text == "" && textBoxSubject.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("INSERT INTO Dislocation (Fed_Destr, Landscape, Subject) values ('{0}', '{1}', '{2}')", textBoxFed_Destr.Text, textBoxLandscape.Text, textBoxSubject.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListDislocation();
            }
        }

        //Удаление дислокации
        private void buttonDeleteDislocation_Click(object sender, EventArgs e)
        {
            if (textBoxFed_Destr.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("DELETE FROM Dislocation WHERE Fed_Destr = '{0}'", textBoxFed_Destr.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListDislocation();
            }
        }

        //Изменение дислокации
        private void buttonResetDislocation_Click(object sender, EventArgs e)
        {
            if (textBoxFed_Destr.Text == "" && textBoxLandscape.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("UPDATE Dislocation SET Fed_Destr='{0}', Landscape='{1}' WHERE Fed_Destr='{0}'", textBoxFed_Destr.Text, textBoxLandscape.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListDislocation();
            }
        }

        //Добавление воинской единицы
        private void buttonAddMilitaryUnit_Click(object sender, EventArgs e)
        {
            if (textBoxNameMilitaryUnit.Text == "" && textBoxCategoryMilitaryUnit.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                string ID_Dislocation = comboBoxIDDislication.SelectedValue.ToString();
                string ID_Equipment = comboBoxIDEquipment.SelectedValue.ToString();

                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("INSERT INTO Military_Unit (Name_Unit, Category_Unit, Dislocation_ID, Equipment_ID) values ('{0}', '{1}', '{2}', '{3}')", textBoxNameMilitaryUnit.Text, textBoxCategoryMilitaryUnit.Text, ID_Dislocation, ID_Equipment);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListMilitaryUnit();
            }
        }

        //Удаление воинской единицы
        private void buttonDeleteMilitaryUnit_Click(object sender, EventArgs e)
        {
            if (textBoxNameMilitaryUnit.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("DELETE FROM Military_Unit WHERE Name_Unit = '{0}'", textBoxNameMilitaryUnit.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListMilitaryUnit();
            }
        }

        //Редактирование воинской единицы
        private void buttonResetMilitaryUnit_Click(object sender, EventArgs e)
        {
            if (textBoxNameMilitaryUnit.Text == "" && textBoxCategoryMilitaryUnit.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("UPDATE Military_Unit SET Name_Unit='{0}', Category_Unit='{1}' WHERE Name_Unit='{0}'", textBoxNameMilitaryUnit.Text, textBoxCategoryMilitaryUnit.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListMilitaryUnit();
            }
        }

        //================Воинская единица================//


        //================Распределение================//

        //Получение данных из таблицы Distribution
        void GetListDistribution()
        {
            DBConnection = new SqlConnection(connectionString);
            DBAdapter = new SqlDataAdapter("SELECT * FROM Distribution ORDER BY ID_Distribution", DBConnection);
            DBDataSet = new DataSet();
            DBConnection.Open();
            DBAdapter.Fill(DBDataSet, "Distribution");
            dataGridViewDistribution.DataSource = DBDataSet.Tables["Distribution"];
            DBConnection.Close();
        }

        //Добавление распределения
        private void buttonAddDistribution_Click(object sender, EventArgs e)
        {
            if (textBoxCodeDistribution.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                string ID_MilitaruUnit = comboBoxMilitaruUnit.SelectedValue.ToString();
                string ID_Employee = comboBoxIDEmployee.SelectedValue.ToString();

                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("INSERT INTO Distribution (Code_Distribution, Employee_ID, Unit_ID ) values ('{0}', '{1}', '{2}')", textBoxCodeDistribution.Text, ID_Employee, ID_MilitaruUnit);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListDistribution();
            }
        }

        //Удаление распределения
        private void buttonDeleteDistribution_Click(object sender, EventArgs e)
        {
            if (textBoxCodeDistribution.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                DBCommand = new SqlCommand();
                DBConnection.Open();
                DBCommand.Connection = DBConnection;
                DBCommand.CommandText = String.Format("DELETE FROM Distribution WHERE Code_Distribution = '{0}'", textBoxCodeDistribution.Text);
                DBCommand.ExecuteNonQuery();
                DBConnection.Close();
                GetListDistribution();
            }
        }

        //================Распределение================//
    }
}