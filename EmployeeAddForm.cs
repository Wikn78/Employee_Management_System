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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagementSystem
{
    public partial class EmployeeAddForm : Form
    {
        public EmployeeAddForm()
        {
            InitializeComponent();
        }
        public string userID;
        private void button3_Click(object sender, EventArgs e)
        {
            TransitionForm form = new TransitionForm();
            form.Show();
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pNumTextBox.Text = "";
            sSNTextBox.Text = "";
            fNameTextBox.Text = "";
            lNameTextBox.Text = "";
            addTextBox.Text = "";
            zipTextBox.Text = "";
            pictureBox1.ImageLocation = @".\Images\PlaceHolder.png"; // WIP
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            //SqlConnection cnn = new SqlConnection("server=(local);database=EmployeeManagement;integrated Security=SSPI;");
            // cnn.Open();
            SqlConnection cnn = ApplicationManager.ConnectToDatabase();

            Image img = pictureBox1.Image;

            SqlCommand sc = new SqlCommand($"INSERT into dbo.EmployeeManagement (fName, lName, address, zip, pNum, SSN, state, position, shift, department, eImage, startTime, endTime, username, password) VALUES " +
                $"('{fNameTextBox.Text.Trim()}', '{lNameTextBox.Text.Trim()}', '{addTextBox.Text.Trim()}', '{zipTextBox.Text.Trim()}', '{pNumTextBox.Text.Trim()}', '{sSNTextBox.Text.Trim()}', '{stateCBox.Text}', " +
                $"'{positionCBox.Text}', '{shiftCBox.Text}', '{departmentCBox.Text}', '{img}', '{startTimeTextBox.Text.Trim()}', '{endTimeTextBox.Text.Trim()}', '{usernameTextBox.Text.Trim()}', '{passwordTextBox.Text.Trim()}');", cnn); 
                
                

            

            sc.ExecuteNonQuery();

            cnn.Close();


            TransitionForm transitionForm = new TransitionForm();
            transitionForm.Show();
            transitionForm.UpdateGreetingLabel(userID);
            this.Hide();
        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png;";

            dialog.ShowDialog();
            string newImage = dialog.FileName;

            pictureBox1.ImageLocation = newImage;
        }
    }
}
