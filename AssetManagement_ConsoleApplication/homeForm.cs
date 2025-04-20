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
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        bool menuExpand = false;
        private void timerMenuExpand_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                panelMenu.Height += 10;
                if (panelMenu.Height >= 130)
                {
                    timerMenuExpand.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                panelMenu.Height -= 10;
                if (panelMenu.Height <= 44)
                {
                    panelMenu.Height -= 10;
                    timerMenuExpand.Stop();
                    menuExpand = false;
                }
            }
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerMenuExpand.Start();
        }

        bool leftPanelExpand = false;
        private void timerLeftPanelExpand_Tick(object sender, EventArgs e)
        {
            if (!leftPanelExpand)
            {
                panelLeft.Width += 10;
                if (panelLeft.Width >= 175)
                {
                    timerLeftPanelExpand.Stop();
                    leftPanelExpand = true;
                }
            }
            else
            {
                panelLeft.Width -= 10;
                if (panelLeft.Width <= 52)
                {
                    panelLeft.Width -= 10;
                    timerLeftPanelExpand.Stop();
                    leftPanelExpand = false;
                }
            }
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            timerLeftPanelExpand.Start();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox("Asset Management - Alpha Version V0.0");
        }
    }
}
