namespace Offline_App___Asset_Management
{
    partial class homePage
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSidePanelExpansion = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelMenuExpand = new System.Windows.Forms.Panel();
            this.btnCurrency = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnCrypto = new System.Windows.Forms.Button();
            this.timerLeftPanelTransition = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSidePanelExpansion)).BeginInit();
            this.txtSidePanelExpansion.SuspendLayout();
            this.panelMenuExpand.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.txtSidePanelExpansion);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(852, 48);
            this.panelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Wealth";
            // 
            // txtSidePanelExpansion
            // 
            this.txtSidePanelExpansion.BackColor = System.Drawing.SystemColors.Window;
            this.txtSidePanelExpansion.Location = new System.Drawing.Point(12, 12);
            this.txtSidePanelExpansion.Name = "txtSidePanelExpansion";
            this.txtSidePanelExpansion.Size = new System.Drawing.Size(24, 18);
            this.txtSidePanelExpansion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtSidePanelExpansion.TabIndex = 2;
            this.txtSidePanelExpansion.TabStop = false;
            // 
            // txtSidePanelExpansion
            // 
            this.txtSidePanelExpansion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSidePanelExpansion.Controls.Add(this.btnLogout);
            this.txtSidePanelExpansion.Controls.Add(this.btnDashboard);
            this.txtSidePanelExpansion.Controls.Add(this.btnSettings);
            this.txtSidePanelExpansion.Controls.Add(this.panelMenuExpand);
            this.txtSidePanelExpansion.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSidePanelExpansion.Location = new System.Drawing.Point(0, 48);
            this.txtSidePanelExpansion.Name = "panelLeftSide";
            this.txtSidePanelExpansion.Size = new System.Drawing.Size(230, 430);
            this.txtSidePanelExpansion.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 122);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 30);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(12, 6);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(150, 30);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(12, 86);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(150, 30);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // panelMenuExpand
            // 
            this.panelMenuExpand.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMenuExpand.Controls.Add(this.btnCurrency);
            this.panelMenuExpand.Controls.Add(this.btnMenu);
            this.panelMenuExpand.Controls.Add(this.btnCrypto);
            this.panelMenuExpand.Location = new System.Drawing.Point(5, 42);
            this.panelMenuExpand.Name = "panelMenuExpand";
            this.panelMenuExpand.Size = new System.Drawing.Size(157, 38);
            this.panelMenuExpand.TabIndex = 2;
            // 
            // btnCurrency
            // 
            this.btnCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrency.Location = new System.Drawing.Point(3, 75);
            this.btnCurrency.Name = "btnCurrency";
            this.btnCurrency.Size = new System.Drawing.Size(150, 30);
            this.btnCurrency.TabIndex = 3;
            this.btnCurrency.Text = "Currency";
            this.btnCurrency.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(3, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(150, 30);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnCrypto
            // 
            this.btnCrypto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrypto.Location = new System.Drawing.Point(3, 40);
            this.btnCrypto.Name = "btnCrypto";
            this.btnCrypto.Size = new System.Drawing.Size(150, 30);
            this.btnCrypto.TabIndex = 3;
            this.btnCrypto.Text = "Crypto";
            this.btnCrypto.UseVisualStyleBackColor = true;
            // 
            // timerLeftPanelTransition
            // 
            this.timerLeftPanelTransition.Interval = 10;
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 478);
            this.Controls.Add(this.panelLeftSide);
            this.Controls.Add(this.panelTop);
            this.Name = "homePage";
            this.Text = "homePage";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSidePanelExpansion)).EndInit();
            this.panelLeftSide.ResumeLayout(false);
            this.panelMenuExpand.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox txtSidePanelExpansion;
        private System.Windows.Forms.Panel panelMenuExpand;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnCurrency;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnCrypto;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer timerLeftPanelTransition;
    }
}