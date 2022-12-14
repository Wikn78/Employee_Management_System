using System;
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
    public partial class TransitionForm : Form
    {
        public TransitionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeMan = new EmployeeManager();
            employeeMan.Show();
            employeeMan.managerID = userID;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScheduleViewerForm scheduleForm = new ScheduleViewerForm();
            scheduleForm.isManager = true;
            scheduleForm.managerID = userID;
            scheduleForm.Show();

            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Close();
        }

        string userID;
        public void UpdateGreetingLabel(string userID)
        {
            String connetionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString.ToString();
            SqlConnection cnn = new SqlConnection(connetionString);
            this.userID = userID;
            string connetionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString.ToString();
            SqlConnection cnn = new SqlConnection(connetionString);

            if (cnn == null) { return; }
            cnn.Open();

            string sqlQuery;
            sqlQuery = $"SELECT fName FROM EmployeeManagement WHERE eID='{userID}';";
            cnn.Open();
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, cnn);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            string userFName = "";
            while (reader.Read())
            {
                userFName = String.Format("{0}", reader[0]);
                
            }

            greetingLabel.Text = $"Hello, {userFName} welcome to the Employee Managment. \nPlease select a task below to do.";
            reader.Close();
            cnn.Close();
        }

        private void TransitionForm_Load(object sender, EventArgs e)
        {

           

        }
    }
}
