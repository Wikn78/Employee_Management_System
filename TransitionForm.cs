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

namespace EmployeeManagementSystem
{
    public partial class TransitionForm : Form
    {
        public TransitionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeAddForm addForm = new EmployeeAddForm();
            addForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScheduleViewerForm scheduleForm = new ScheduleViewerForm();
            scheduleForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        public void UpdateGreetingLabel(string userID)
        {

            SqlConnection cnn = ApplicationManager.ConnectToDatabase();

            string checkUserID;
            checkUserID = $"SELECT fName FROM EmployeeManagement WHERE eID='{userID}';";

            SqlCommand sqlCommand = new SqlCommand(checkUserID, cnn);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            string userFName = "";
            while (reader.Read())
            {
                userFName = String.Format("{0}", reader[0]);
                
            }

            greetingLabel.Text = $"Hello, {userFName} welcome to the Employee Managment. Please select a task below to do.";
            cnn.Close();
        }

        private void TransitionForm_Load(object sender, EventArgs e)
        {

           

        }
    }
}
