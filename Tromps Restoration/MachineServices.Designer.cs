namespace Tromps_Restoration
{
    partial class MachineServices
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineHiresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthAndSafteyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineSpecificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.documentationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exitToolStripMenuItem.Text = "Home";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.machinesToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(102, 23);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // machinesToolStripMenuItem
            // 
            this.machinesToolStripMenuItem.Checked = true;
            this.machinesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.machinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.machineHiresToolStripMenuItem,
            this.machineServicesToolStripMenuItem});
            this.machinesToolStripMenuItem.Name = "machinesToolStripMenuItem";
            this.machinesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.machinesToolStripMenuItem.Text = "Machines";
            // 
            // machineHiresToolStripMenuItem
            // 
            this.machineHiresToolStripMenuItem.Name = "machineHiresToolStripMenuItem";
            this.machineHiresToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.machineHiresToolStripMenuItem.Text = "Machine Hires";
            // 
            // machineServicesToolStripMenuItem
            // 
            this.machineServicesToolStripMenuItem.Checked = true;
            this.machineServicesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.machineServicesToolStripMenuItem.Enabled = false;
            this.machineServicesToolStripMenuItem.Name = "machineServicesToolStripMenuItem";
            this.machineServicesToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.machineServicesToolStripMenuItem.Text = "Machine Services";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.healthAndSafteyToolStripMenuItem,
            this.machineSpecificToolStripMenuItem});
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // healthAndSafteyToolStripMenuItem
            // 
            this.healthAndSafteyToolStripMenuItem.Name = "healthAndSafteyToolStripMenuItem";
            this.healthAndSafteyToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.healthAndSafteyToolStripMenuItem.Text = "Health and Saftey";
            // 
            // machineSpecificToolStripMenuItem
            // 
            this.machineSpecificToolStripMenuItem.Name = "machineSpecificToolStripMenuItem";
            this.machineSpecificToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.machineSpecificToolStripMenuItem.Text = "Machine Specific";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 423);
            this.dataGridView1.TabIndex = 4;
            // 
            // MachineServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MachineServices";
            this.Text = "MachineServices";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineHiresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthAndSafteyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineSpecificToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}