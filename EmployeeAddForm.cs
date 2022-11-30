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
            SqlConnection cnn = new SqlConnection("server=(local);database=EmployeeManagement;integrated Security=SSPI;"); // this one works fore me the other does not
            // SqlConnection conn = ApplicationManager.ConnectToDatabase(); // This also opens it
                                                                            // Re: This is broken for me

            SqlCommand sc = new SqlCommand("INSERT into dbo.EmployeeManagement (fName, lName, address, zip, pNum, SSN, state, position, shift) VALUES ('" + fNameTextBox.Text.Trim() + "', " 
                + "'" + lNameTextBox.Text.Trim() + "', " + "'" + addTextBox.Text.Trim() + "', " + "'" + zipTextBox.Text.Trim() + "', " + "'" + pNumTextBox.Text.Trim() + "', " + "'" + sSNTextBox.Text.Trim() + "', " 
                + "'" + stateCBox.SelectedIndex + "', " + "'" + positionCBox.SelectedIndex + "', " + "'" + shiftCBox.SelectedIndex + "');", cnn);

            cnn.Open();

            sc.ExecuteNonQuery();

            cnn.Close();
        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
