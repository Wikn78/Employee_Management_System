using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class EmployeeRemoveEditForm : Form
    {
        public EmployeeRemoveEditForm()
        {
            InitializeComponent();
        }

        private void EmployeeRemoveEditForm_Load(object sender, EventArgs e)
        {

            string connetionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString.ToString();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand sc = new SqlCommand("select eID from EmployeeManagement", cnn);
            SqlDataReader reader = sc.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Columns.Add("eID", typeof(string));
            dt.Load(reader);

            eIDComboBox.ValueMember = "eID";
            eIDComboBox.DisplayMember = "eID";

            eIDComboBox.DataSource = dt;
           

          
            
            sc = new SqlCommand("select Dept_Name from Departments", cnn);
            reader = sc.ExecuteReader();

            dt = new DataTable();

            dt.Columns.Add("Dept_Name", typeof(string));
            dt.Load(reader);

            departmentCBox.ValueMember = "Dept_Name";
            departmentCBox.DisplayMember = "Dept_Name";

            departmentCBox.DataSource = dt;




            cnn.Close();

        }

        private void eIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Select Data

            string connetionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString.ToString();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand sc = new SqlCommand($"SELECT fName, lName, address, zip, state, pNum, SSN, shift, position, department, startTime, endTime, username, password FROM EmployeeManagement where eID = {Int32.Parse(eIDComboBox.Text)};", cnn);
            SqlDataReader reader = sc.ExecuteReader();
            while (reader.Read())
            {

                fNameTextBox.Text = String.Format("{0}", reader[0]);
                lNameTextBox.Text = String.Format("{0}", reader[1]);
                addTextBox.Text = String.Format("{0}", reader[2]);
                zipTextBox.Text = String.Format("{0}", reader[3]);
                
                pNumTextBox.Text = String.Format("{0}", reader[5]);
                sSNTextBox.Text = String.Format("{0}", reader[6]);
                
                startTimeTextBox.Text = String.Format("{0}", reader[10]);
                endTimeTextBox.Text = String.Format("{0}", reader[11]);
                usernameTextBox.Text = String.Format("{0}", reader[12]);
                passwordTextBox.Text = String.Format("{0}", reader[13]);


                

                for(int i = 0; i < stateCBox.Items.Count; i++)
                {

                    if(reader.GetString(4).Equals(stateCBox.Items[i]))
                    {

                        stateCBox.SelectedIndex = i;

                    }


                }

                for (int i = 0; i < shiftCBox.Items.Count; i++)
                {

                    if (reader.GetString(7).Equals(shiftCBox.Items[i]))
                    {

                        shiftCBox.SelectedIndex = i;

                    }


                }

                for (int i = 0; i < departmentCBox.Items.Count; i++)
                {

                    if (reader.GetString(9).Equals(departmentCBox.Items[i]))
                    {

                        departmentCBox.SelectedIndex = i;

                    }


                }

                for (int i = 0; i < positionCBox.Items.Count; i++)
                {

                    if (reader.GetString(8).Equals(positionCBox.Items[i]))
                    {

                        positionCBox.SelectedIndex = i;

                    }


                }


            }
            reader.Close();
            cnn.Close();

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeMan = new EmployeeManager();
            employeeMan.Show();
            Close();

        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string connetionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString.ToString();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
           
            SqlCommand sc = new SqlCommand($"UPDATE EmployeeManagement SET fname = '{fNameTextBox.Text.Trim()}', lName = '{lNameTextBox.Text.Trim()}', address = '{addTextBox.Text.Trim()}', zip = '{zipTextBox.Text.Trim()}', " +
                $"pNum = '{pNumTextBox.Text.Trim()}', SSN = '{sSNTextBox.Text.Trim()}', state = '{stateCBox.Text.Trim()}', position = '{positionCBox.Text.Trim()}', shift = '{shiftCBox.Text.Trim()}', department = '{departmentCBox.Text.Trim()}', " +
                $"startTime = '{startTimeTextBox.Text.Trim()}', endTime = '{endTimeTextBox.Text.Trim()}', username = '{usernameTextBox.Text.Trim()}', password = '{passwordTextBox.Text.Trim()}'" +
                $"where eID = {Int32.Parse(eIDComboBox.Text)};", cnn);
            sc.ExecuteNonQuery();
            cnn.Close();

            EmployeeManager employeeMan = new EmployeeManager();
            employeeMan.Show();
            Close();

        }

        private void removeEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string connetionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString.ToString();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand sc = new SqlCommand($"DELETE FROM EmployeeManagement where eID = {Int32.Parse(eIDComboBox.Text)};", cnn);
            sc.ExecuteNonQuery();
            cnn.Close();
            
            EmployeeManager employeeMan = new EmployeeManager();
            employeeMan.Show();
            Close();

        }

    }
}
