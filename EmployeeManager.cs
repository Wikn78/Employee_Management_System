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
    public partial class EmployeeManager : Form
    {
        public EmployeeManager()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeAddForm addForm = new EmployeeAddForm();
            addForm.Show();
            addForm.managerID = managerID;
            Close();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeRemoveEditForm removeForm = new EmployeeRemoveEditForm();
            removeForm.Show();
            removeForm.managerID = managerID;
            Close();
        }

        private void EmployeeManager_Load(object sender, EventArgs e)
        {

            string connetionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString.ToString();
            SqlConnection cnn = new SqlConnection(connetionString);

            if (cnn == null) { return; }


            string sqlQuery;
            sqlQuery = $"SELECT eID, fName, lName, address, zip, state, pNum, SSN, shift, position, department, startTime, endTime, username, password  FROM EmployeeManagement;";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, cnn);
            cnn.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            bindingSource1.DataSource = reader;
            dataGridView1.DataSource = bindingSource1;

            reader.Close();
            cnn.Close();
        }
        public string managerID = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            TransitionForm transition = new TransitionForm();
            transition.Show();
            transition.UpdateGreetingLabel(managerID);

            Close();
        }
    }
}
