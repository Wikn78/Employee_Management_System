using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
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
      
        private void backButton_Click(object sender, EventArgs e)
        {
            EmployeeManager manager = new EmployeeManager();
            manager.Show();
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();

            pNumTextBox.Text = "";
            sSNTextBox.Text = "";
            fNameTextBox.Text = "";
            lNameTextBox.Text = "";
            addTextBox.Text = "";
            zipTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            startTimeTextBox.Text = "";
            endTimeTextBox.Text = "";
            // pictureBox1.ImageLocation = (path + @"/Images/PlaceHolder.png"); // WIP; paths always give me a headache
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            String connetionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString.ToString();
            SqlConnection cnn = new SqlConnection(connetionString);
            Image img = pictureBox1.Image;

            SqlCommand sc = new SqlCommand($"INSERT into dbo.EmployeeManagement (fName, lName, address, zip, pNum, SSN, state, position, shift, department, eImage, startTime, endTime, username, password) VALUES " +
                $"('{fNameTextBox.Text.Trim()}', '{lNameTextBox.Text.Trim()}', '{addTextBox.Text.Trim()}', '{zipTextBox.Text.Trim()}', '{pNumTextBox.Text.Trim()}', '{sSNTextBox.Text.Trim()}', '{stateCBox.Text}', " +
                $"'{positionCBox.Text}', '{shiftCBox.Text}', '{departmentCBox.Text}', '{img}', '{startTimeTextBox.Text.Trim()}', '{endTimeTextBox.Text.Trim()}', '{usernameTextBox.Text.Trim()}', '{passwordTextBox.Text.Trim()}');", cnn);

            cnn.Open();
            sc.ExecuteNonQuery();
            cnn.Close();

            EmployeeManager manager = new EmployeeManager();
            manager.Show();
            Close();
        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png;";

            dialog.ShowDialog();
            string newImage = dialog.FileName;

            pictureBox1.ImageLocation = newImage;
        }

        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeManagementDataSet.Departments' table. You can move, or remove it, as needed.

            String connetionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString.ToString();
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand sc = new SqlCommand("select Dept_Name from Departments", cnn);
            SqlDataReader reader = sc.ExecuteReader();
            
            DataTable dt = new DataTable();

            dt.Columns.Add("Dept_Name", typeof(string));
            dt.Load(reader);
            
            departmentCBox.ValueMember = "Dept_Name";
            departmentCBox.DisplayMember = "Dept_Name";
            
            departmentCBox.DataSource = dt;

            
           
            
            cnn.Close();

            stateCBox.SelectedIndex = 0;
            shiftCBox.SelectedIndex = 0;
            positionCBox.SelectedIndex = 0;

        }

        private void departmentCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
