using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (showPasswordCheckBox.Checked)
                passwordMaskedTextBox.PasswordChar = '\0';
            else
                passwordMaskedTextBox.PasswordChar = '*';

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            SqlConnection cnn = ApplicationManager.ConnectToDatabase();

            if (cnn == null) { return; }


            string sqlQuery;
            sqlQuery = $"SELECT username, password, eID, position FROM EmployeeManagement WHERE username='{userNameTextBox.Text}';";
            
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, cnn);
            cnn.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();



            // Setting the data in reader;
            string username = "";
            string userPassword = "";
            string userID = "";
            string userPosition = "";

            while (reader.Read())
            {
                username = String.Format("{0}", reader[0]);
                userPassword = String.Format("{0}", reader[1]);
                userID = String.Format("{0}", reader[2]);
                userPosition = String.Format("{0}", reader[3]);
                
            }

            reader.Close();
           

            if(userNameTextBox.Text == username && passwordMaskedTextBox.Text == userPassword)
            {

                
                if (userPosition.ToLower() == "manager")
                {
                    ShowManagmentScreen(userID);
                }
                   
                else if (userPosition.ToLower() == "associate")
                {
                    ShowEmployeeScreen(userID);
                }
                
            }
            else
            {
                
            }

            cnn.Close();
        }

        
        private void ShowEmployeeScreen(string userID)
        {
            ScheduleViewerForm scheduleViewer = new ScheduleViewerForm();
            scheduleViewer.Show();
            this.Hide();

        }
        private void ShowManagmentScreen(string userID)
        {

            TransitionForm TransitionForm = new TransitionForm();
            TransitionForm.Show();
            TransitionForm.UpdateGreetingLabel(userID);
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransitionForm TransitionForm = new TransitionForm();
            TransitionForm.Show();
            this.Hide();
        }
    }
}

