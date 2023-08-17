using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1  
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdShowpassword.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
    }/*

    /*private void buttonLogin_Click(object sender, EventArgs e)
            {
                string username = txt.Text;
                string password = txtPass.Text;

                // Perform your authentication logic here, e.g., check against a database, API, etc.
                // For this example, we'll use a simple hardcoded check.
                if (username == "admin" && password == "password")
                {
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
        }*/


        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtAccount.Text;
            string password = txtPassword.Text;
            if (IsUserValid(name, password))
            {
               Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                if ((txtAccount.Text == "") || (txtPassword.Text == ""))
                {
                    MessageBox.Show("Please provide your complete login information.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again!",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private bool IsUserValid(string name, string password)
        {
            return (name == "thu" && password == "123");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = txtAccount.Text;
            string password = txtPassword.Text;
            if (IsUserValid(name, password))
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
            else
            {
                if ((txtAccount.Text == "") || (txtPassword.Text == ""))
                {
                    MessageBox.Show("Please provide your complete login information.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again!",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String message = "Do you want to Exit?";
            string title = "Notice";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        } 

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
               txtPassword.PasswordChar = '*';
            }
        }
    }
}

