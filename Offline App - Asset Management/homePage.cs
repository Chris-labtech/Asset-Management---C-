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
    public partial class homePage : Form
    {
        // Declare Additional Views/Forms
        dashboard dashboard;
        public homePage()
        {
            InitializeComponent();

        }

        // If this image is clicked, the side panel will either expand or close
        private void txtDropDown_Click(object sender, EventArgs e)
        {
            sidePanelTransition.Start();
        }

        //  Variables for Side Panel Expansion
        bool sidePanelExpandState = true;
        private void sidePanelTransition_Tick(object sender, EventArgs e)
        {
            if (sidePanelExpandState)
            {
                sidePanel.Width -= 10;
                if(sidePanel.Width <= 50)
                {
                    sidePanelTransition.Stop();
                    sidePanelExpandState = false;
                }
            }
            else
            {
                sidePanel.Width += 10;
                if(sidePanel.Width >= 210)
                {
                    sidePanelTransition.Stop();
                    sidePanelExpandState = true;
                }
            }
        }

        //  Variables for Side Panel Expansion
        bool menuPanelExpandState = false;

        // If menu button is pressed, the menu will either expand or close
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //menuPanelExpandState = true;
            //MessageBox.Show("Menu button was clicked");
            menuPanelTransition.Start();
        }


        private void menuPanelTransition_Tick(object sender, EventArgs e)
        {
            

            if (menuPanelExpandState)
            {
                // Collapse
                menuPanel.Height -= 10;
                if (menuPanel.Height <= 50)
                {
                    menuPanelTransition.Stop();
                    menuPanelExpandState = false;
                }
            }
            else
            {
                // Expand
                menuPanel.Height += 10;
                if (menuPanel.Height >= 137)
                {
                    menuPanelTransition.Stop();
                    menuPanelExpandState = true;
                }
            }
        }
        // Open Dashboard when clicked
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if(dashboard == null)
            {
                dashboard = new dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }

            
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            //  throw new NotImplementedException();
            dashboard = null;
        }
    }
}
