namespace AssetManagement_ConsoleApplication
{
    partial class homeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnPanel = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAssets_B = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnAssets_A = new System.Windows.Forms.Button();
            this.defaultPanel = new System.Windows.Forms.Panel();
            this.timerMenuExpand = new System.Windows.Forms.Timer(this.components);
            this.timerLeftPanelExpand = new System.Windows.Forms.Timer(this.components);
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.defaultPanel.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(172, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Asset Management | Alpha";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.IndianRed;
            this.panel10.Controls.Add(this.btnSettings);
            this.panel10.Location = new System.Drawing.Point(667, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(150, 44);
            this.panel10.TabIndex = 6;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(3, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(143, 37);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.IndianRed;
            this.panel8.Controls.Add(this.btnPanel);
            this.panel8.Location = new System.Drawing.Point(12, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(150, 44);
            this.panel8.TabIndex = 4;
            // 
            // btnPanel
            // 
            this.btnPanel.Location = new System.Drawing.Point(3, 3);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(143, 37);
            this.btnPanel.TabIndex = 0;
            this.btnPanel.Text = "Panel Expansion";
            this.btnPanel.UseVisualStyleBackColor = true;
            this.btnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.IndianRed;
            this.panel9.Controls.Add(this.btnUser);
            this.panel9.Location = new System.Drawing.Point(823, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(150, 44);
            this.panel9.TabIndex = 5;
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(3, 3);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(143, 37);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkGray;
            this.panelLeft.Controls.Add(this.panel7);
            this.panelLeft.Controls.Add(this.panel4);
            this.panelLeft.Controls.Add(this.panel6);
            this.panelLeft.Controls.Add(this.panelMenu);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 54);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(175, 484);
            this.panelLeft.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.IndianRed;
            this.panel7.Controls.Add(this.btnLogout);
            this.panel7.Location = new System.Drawing.Point(12, 435);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(150, 44);
            this.panel7.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(3, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(143, 37);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Controls.Add(this.btnDashboard);
            this.panel4.Location = new System.Drawing.Point(12, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 44);
            this.panel4.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(143, 37);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.IndianRed;
            this.panel6.Controls.Add(this.btnAbout);
            this.panel6.Location = new System.Drawing.Point(12, 385);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 44);
            this.panel6.TabIndex = 3;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(3, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(143, 37);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.IndianRed;
            this.panelMenu.Controls.Add(this.btnAssets_B);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Controls.Add(this.btnAssets_A);
            this.panelMenu.Location = new System.Drawing.Point(12, 56);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 44);
            this.panelMenu.TabIndex = 2;
            // 
            // btnAssets_B
            // 
            this.btnAssets_B.Location = new System.Drawing.Point(3, 89);
            this.btnAssets_B.Name = "btnAssets_B";
            this.btnAssets_B.Size = new System.Drawing.Size(143, 37);
            this.btnAssets_B.TabIndex = 2;
            this.btnAssets_B.Text = "Assets_B";
            this.btnAssets_B.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(143, 37);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnAssets_A
            // 
            this.btnAssets_A.Location = new System.Drawing.Point(3, 46);
            this.btnAssets_A.Name = "btnAssets_A";
            this.btnAssets_A.Size = new System.Drawing.Size(143, 37);
            this.btnAssets_A.TabIndex = 1;
            this.btnAssets_A.Text = "Assets_A";
            this.btnAssets_A.UseVisualStyleBackColor = true;
            // 
            // defaultPanel
            // 
            this.defaultPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.defaultPanel.Controls.Add(this.dashboardPanel);
            this.defaultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultPanel.Location = new System.Drawing.Point(175, 54);
            this.defaultPanel.Name = "defaultPanel";
            this.defaultPanel.Size = new System.Drawing.Size(801, 484);
            this.defaultPanel.TabIndex = 2;
            // 
            // timerMenuExpand
            // 
            this.timerMenuExpand.Interval = 10;
            this.timerMenuExpand.Tick += new System.EventHandler(this.timerMenuExpand_Tick);
            // 
            // timerLeftPanelExpand
            // 
            this.timerLeftPanelExpand.Interval = 10;
            this.timerLeftPanelExpand.Tick += new System.EventHandler(this.timerLeftPanelExpand_Tick);
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.dashboardPanel.Controls.Add(this.label2);
            this.dashboardPanel.Location = new System.Drawing.Point(7, 7);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(787, 472);
            this.dashboardPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "DashBoard";
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 538);
            this.Controls.Add(this.defaultPanel);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Name = "homeForm";
            this.Text = "HomeForm - Asset Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.defaultPanel.ResumeLayout(false);
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel defaultPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnAssets_A;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnAssets_B;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Timer timerMenuExpand;
        private System.Windows.Forms.Timer timerLeftPanelExpand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Label label2;
    }
}