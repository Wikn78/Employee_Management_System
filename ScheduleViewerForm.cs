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
    public partial class ScheduleViewerForm : Form
    {
        public ScheduleViewerForm()
        {
            InitializeComponent();
        }

        private void nightShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String connetionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString.ToString();
            SqlConnection cnn = new SqlConnection(connetionString);

            cnn.Open();

            string sqlQuery;
            sqlQuery = $"SELECT startTime, endTime, fName, lName, department FROM EmployeeManagement WHERE shift='Night Shift';";

            SqlCommand command = new SqlCommand(sqlQuery, cnn);

            SqlDataReader reader = command.ExecuteReader();

            bindingSource1.DataSource = reader;
            dataGridView1.DataSource = bindingSource1;

            reader.Close();
            cnn.Close();
        }

        private void eveningShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String connetionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString.ToString();
            SqlConnection cnn = new SqlConnection(connetionString);

            cnn.Open();

            string sqlQuery;
            sqlQuery = $"SELECT startTime, endTime, fName, lName, department FROM EmployeeManagement WHERE shift='Evening Shift';";

            SqlCommand command = new SqlCommand(sqlQuery, cnn);

            SqlDataReader reader = command.ExecuteReader();

            bindingSource1.DataSource = reader;
            dataGridView1.DataSource = bindingSource1;

            reader.Close();
            cnn.Close();
        }

        private void morningShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String connetionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString.ToString();
            SqlConnection cnn = new SqlConnection(connetionString);

            cnn.Open();

            string sqlQuery;
            sqlQuery = $"SELECT startTime, endTime, fName, lName, department FROM EmployeeManagement WHERE shift='Morning Shift';";
            
            SqlCommand command = new SqlCommand(sqlQuery, cnn);

            SqlDataReader reader = command.ExecuteReader();

            bindingSource1.DataSource = reader;
            dataGridView1.DataSource = bindingSource1;
            
            reader.Close();
            cnn.Close();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ScheduleViewerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
