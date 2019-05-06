namespace Tromps_Restoration
{
    partial class Home
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
            this.menuMainPage = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineHireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthSafteyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineSpecificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMainPage
            // 
            this.menuMainPage.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.menuMainPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.documentationToolStripMenuItem});
            this.menuMainPage.Location = new System.Drawing.Point(0, 0);
            this.menuMainPage.Name = "menuMainPage";
            this.menuMainPage.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuMainPage.Size = new System.Drawing.Size(699, 27);
            this.menuMainPage.TabIndex = 0;
            this.menuMainPage.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.machineHireToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(102, 23);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.CustomersToolStripMenuItem_Click);
            // 
            // machineHireToolStripMenuItem
            // 
            this.machineHireToolStripMenuItem.Name = "machineHireToolStripMenuItem";
            this.machineHireToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.machineHireToolStripMenuItem.Text = "Machines";
            this.machineHireToolStripMenuItem.Click += new System.EventHandler(this.MachineHireToolStripMenuItem_Click);
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.healthSafteyToolStripMenuItem,
            this.machineSpecificToolStripMenuItem});
            this.documentationToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(117, 23);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // healthSafteyToolStripMenuItem
            // 
            this.healthSafteyToolStripMenuItem.Name = "healthSafteyToolStripMenuItem";
            this.healthSafteyToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.healthSafteyToolStripMenuItem.Text = "Health and Saftey";
            this.healthSafteyToolStripMenuItem.Click += new System.EventHandler(this.HealthSafteyToolStripMenuItem_Click);
            // 
            // machineSpecificToolStripMenuItem
            // 
            this.machineSpecificToolStripMenuItem.Name = "machineSpecificToolStripMenuItem";
            this.machineSpecificToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.machineSpecificToolStripMenuItem.Text = "Machine Specific";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 508);
            this.Controls.Add(this.menuMainPage);
            this.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.MainMenuStrip = this.menuMainPage;
            this.Name = "Home";
            this.Text = "Home";
            this.menuMainPage.ResumeLayout(false);
            this.menuMainPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainPage;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineHireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthSafteyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineSpecificToolStripMenuItem;
    }
}