using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagementSystem
{
    public partial class EmployeeAddForm : Form
    {
        public EmployeeAddForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TransitionForm form = new TransitionForm();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pNumTextBox.Text = "";
            sSNTextBox.Text = "";
            fNameTextBox.Text = "";
            lNameTextBox.Text = "";
            addTextBox.Text = "";
            zipTextBox.Text = "";
            // needs to reset the pictureBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            connetionString = @"Data Source=JORGLE;Initial Catalog=EmployeeManagement;Integrated Security=True"; // don't forget to change your datasource when using this
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand sc = new SqlCommand("Insert into EmployeeInfo (eID,fName,lName, address, zip, pNum, SSN, state, position) values ('" + "')", cnn);
            sc.ExecuteNonQuery();

            cnn.Close();
        }
    }
}
