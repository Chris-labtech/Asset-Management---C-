using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Offline_App___Asset_Management
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();

            // Monitor changes in the Output monitor
            txtInputUsername.TextChanged += txtOutputUsername_TextChanged;
            txtInputPassword.TextChanged += txtOutputPassword_TextChanged;
        }

        private void txtClearLoginEntries_Click(object sender, EventArgs e)
        {
            txtInputUsername.Clear();
            txtInputPassword.Clear();
            // Focus on Username after Clear
            txtInputUsername.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // [1] - Should this variable be here? Change type of variable
            string username = txtInputUsername.Text;
            string password = txtInputPassword.Text;


            // [3] - Hardcoded Username and Password
            if (username == "admin" &&  password == "1234")
            {
                // Debug Message
                MessageBox.Show("Login was Successful");
                //  [2] - Should this be hidden afterwards or should this be closed?
                //this.Hide();
                new homePage().Show(); 
            }
            else
            {
                // Debug Message
                MessageBox.Show("Login was Unsuccessful");
            }
        }

        private void txtOutputUsername_TextChanged(object sender, EventArgs e)
        {
            //  Debug Message
            //  MessageBox.Show("Text was changed for Username");
            txtOutputUsername.Text = txtInputUsername.Text;
        }

        private void txtOutputPassword_TextChanged(object sender, EventArgs e)
        {
            //  Debug Message
            //  MessageBox.Show("Text was changed for Password");
            txtOutputPassword.Text = txtInputPassword.Text;
        }
    }
}
