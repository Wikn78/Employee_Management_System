using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            TransitionForm TransitionForm = new TransitionForm();
            TransitionForm.Show();
            this.Hide();
        }
    }
}
