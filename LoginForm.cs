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


            

            
            
            SqlConnection cnn = ApplicationManager.ConnectToDatabase();

            if(cnn == null) { return; }


            string checkPassword;
            checkPassword = "SELECT password, userID FROM ManagerLogin WHERE username='" + userNameTextBox.Text + "';";
            
            SqlCommand sqlCommand = new SqlCommand(checkPassword, cnn);

            SqlDataReader reader = sqlCommand.ExecuteReader();


            // Setting the data in reader;
            string userPassword = "";
            string userID = "";
            while (reader.Read())
            {
                userPassword = String.Format("{0}", reader[0]);
                userID = String.Format("{0}", reader[1]);
            }


            cnn.Close();

            // Check if password in database is = to password typed;
            if(userPassword == passwordMaskedTextBox.Text)
            {
                
                ShowSelectionScreen(userID);

            }






        }

        

        private void ShowSelectionScreen(string userID)
        {

            TransitionForm TransitionForm = new TransitionForm();
            TransitionForm.Show();
            TransitionForm.UpdateGreetingLabel(userID);
            this.Hide();

        }
    }
}

