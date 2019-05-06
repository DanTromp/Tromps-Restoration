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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthAndSafteyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineSpecificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridServices = new System.Windows.Forms.DataGridView();
            this.machineServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trompsDataSet = new Tromps_Restoration.TrompsDataSet();
            this.machine_ServicesTableAdapter = new Tromps_Restoration.TrompsDataSetTableAdapters.Machine_ServicesTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trompsDataSet)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(543, 27);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.exitToolStripMenuItem.Text = "Home";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(115, 24);
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
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // machinesToolStripMenuItem
            // 
            this.machinesToolStripMenuItem.Checked = true;
            this.machinesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.machinesToolStripMenuItem.Name = "machinesToolStripMenuItem";
            this.machinesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.machinesToolStripMenuItem.Text = "Machines";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.healthAndSafteyToolStripMenuItem,
            this.machineSpecificToolStripMenuItem});
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(117, 23);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // healthAndSafteyToolStripMenuItem
            // 
            this.healthAndSafteyToolStripMenuItem.Name = "healthAndSafteyToolStripMenuItem";
            this.healthAndSafteyToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.healthAndSafteyToolStripMenuItem.Text = "Health and Saftey";
            // 
            // machineSpecificToolStripMenuItem
            // 
            this.machineSpecificToolStripMenuItem.Name = "machineSpecificToolStripMenuItem";
            this.machineSpecificToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.machineSpecificToolStripMenuItem.Text = "Machine Specific";
            // 
            // dataGridServices
            // 
            this.dataGridServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridServices.Location = new System.Drawing.Point(0, 27);
            this.dataGridServices.Name = "dataGridServices";
            this.dataGridServices.Size = new System.Drawing.Size(543, 338);
            this.dataGridServices.TabIndex = 4;
            // 
            // machineServicesBindingSource
            // 
            this.machineServicesBindingSource.DataMember = "Machine Services";
            this.machineServicesBindingSource.DataSource = this.trompsDataSet;
            // 
            // trompsDataSet
            // 
            this.trompsDataSet.DataSetName = "TrompsDataSet";
            this.trompsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // machine_ServicesTableAdapter
            // 
            this.machine_ServicesTableAdapter.ClearBeforeFill = true;
            // 
            // MachineServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 365);
            this.Controls.Add(this.dataGridServices);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.Name = "MachineServices";
            this.Text = "MachineServices";
            this.Load += new System.EventHandler(this.MachineServices_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trompsDataSet)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthAndSafteyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineSpecificToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridServices;
        private TrompsDataSet trompsDataSet;
        private System.Windows.Forms.BindingSource machineServicesBindingSource;
        private TrompsDataSetTableAdapters.Machine_ServicesTableAdapter machine_ServicesTableAdapter;
    }
}