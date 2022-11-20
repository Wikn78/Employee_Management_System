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
            int count = 0;
            string connetionString;
            connetionString = @"Data Source=JORGLE;Initial Catalog=EmployeeManagement;Integrated Security=True"; // don't forget to change your datasource when using this
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();

            using (SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM dbo.EmployeeManagement", cnn))
            {
                count = (int)cmdCount.ExecuteScalar();
                Console.Write(count);
            }

            // sql keeps throwing an error
            SqlCommand sc = new SqlCommand("INSERT into dbo.EmployeeManagement (eID, fName,lName, address, zip, pNum, SSN, state, position, shift) values ('" + count+1 + "')" + "('" + fNameTextBox.Text + "')" 
                + "('" + lNameTextBox.Text + "')" + "('" + addTextBox.Text + "')" + "('" + zipTextBox.Text + "')" + "('" + pNumTextBox.Text + "')" + "('" + sSNTextBox.Text + "')" 
                + "('" + stateCBox.SelectedIndex + "')" + "('" + positionCBox.SelectedIndex + "')" + "('" + shiftCBox.SelectedIndex + "')", cnn);
            sc.ExecuteNonQuery();

            cnn.Close();
        }
    }
}
