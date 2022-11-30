using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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


            

            
            
            SqlConnection cnn = new SqlConnection("server=(local);database=EmployeeManagement;integrated Security=SSPI;"); // this one works for me

            if (cnn == null) { return; }


            string sqlQuery;
            sqlQuery = $"SELECT password, userID FROM ManagerLogin WHERE username='{userNameTextBox.Text}';";
            
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, cnn);
            cnn.Open(); // needed to add this for it to work
            SqlDataReader reader = sqlCommand.ExecuteReader();
            


            // Setting the data in reader;
            string userPassword = "";
            string userID = "";
            while (reader.Read())
            {
                userPassword = String.Format("{0}", reader[0]);
                userID = String.Format("{0}", reader[1]);
            }
            reader.Close();
            sqlQuery = $"SELECT position FROM EmployeeManagement WHERE eID='{userID}';";

            sqlCommand = new SqlCommand(sqlQuery, cnn);
            reader = sqlCommand.ExecuteReader();
            string userPosition = "";

            while (reader.Read())
            {
                userPosition = String.Format("{0}", reader[0]);
            }
            reader.Close();


            cnn.Close();

            // Check if password in database is = to password typed;
            if(userPassword == passwordMaskedTextBox.Text)
            {
                if (userPosition.ToLower() == "manager")
                    ShowManagmentScreen(userID);
                else if (userPosition.ToLower() == "employee")
                    ShowEmployeeScreen(userID);

            }
        }

        
        private void ShowEmployeeScreen(string userID)
        {
            ScheduleViewerForm scheduleViewer = new ScheduleViewerForm();
            scheduleViewer.Show();
            this.Close();

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

