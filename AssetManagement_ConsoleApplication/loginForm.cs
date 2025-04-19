using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement_ConsoleApplication
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();

            // View Changes in Username and Password
            txtOutputUsername.TextChanged += txtOutputUsername_TextChanged;
            txtOutputPassword.TextChanged += txtOutputPassword_TextChanged;
        }

        private void txtOutputUsername_TextChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show("Text was changed for Username");
            txtOutputUsername.Text = txtUsernameInput.Text;
        }
        private void txtOutputPassword_TextChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show("Text was changed for Password"); 
            txtOutputPassword.Text = txtPasswordInput.Text;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsernameInput.Text;
            string password = txtPasswordInput.Text;

            if (username == "admin" && password == "1234")
            {
                // Debug Message
                MessageBox.Show("Login was Successful");
                new homeForm().Show();
            }
            else
            {
                // Debug Message
                MessageBox.Show("Login was unsucessful");
            }
            
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtUsernameInput.Clear();
            txtPasswordInput.Clear();
            // Once cleared focus icon on Username Input.
            txtUsernameInput.Focus();
        }
    }
}
