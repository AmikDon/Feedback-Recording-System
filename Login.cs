using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerFeedback.Class;

namespace CustomerFeedback
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            isValid();
        }

        private void isValid()
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Enter Username", "Error");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Password", "Error");
            }
            else
            {
                if (txtUsername.Text.Trim().ToLower() == "admin" && txtPassword.Text.Trim().ToLower() == "admin")
                {
                    User.Username = txtUsername.Text.Trim();
                    User.Role = "Admin";
                    ShowDashboard();
                }
                else if (txtUsername.Text.Trim().ToLower() == "user" && txtPassword.Text.Trim().ToLower() == "user")
                {
                    User.Username = txtUsername.Text.Trim();
                    User.Role = "User";
                    ShowDashboard();
                }
                else
                {
                    MessageBox.Show("Unauthorized User", "Information");
                }

            }
        }

        private void ShowDashboard()
        {
            Dashboard dfrm = new Dashboard();
            dfrm.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}