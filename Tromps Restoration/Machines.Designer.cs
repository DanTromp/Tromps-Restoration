namespace Tromps_Restoration
{
    partial class Machines
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
            this.machineHiresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthAndSafteyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineSpecificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.machineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineClassificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineSerialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trompsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trompsDataSet = new Tromps_Restoration.TrompsDataSet();
            this.trompsDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.machinesTableAdapter = new Tromps_Restoration.TrompsDataSetTableAdapters.MachinesTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trompsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trompsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trompsDataSetBindingSource1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(346, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Home";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.machinesToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // machinesToolStripMenuItem
            // 
            this.machinesToolStripMenuItem.Checked = true;
            this.machinesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.machinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.machineHiresToolStripMenuItem,
            this.machineServicesToolStripMenuItem});
            this.machinesToolStripMenuItem.Enabled = false;
            this.machinesToolStripMenuItem.Name = "machinesToolStripMenuItem";
            this.machinesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.machinesToolStripMenuItem.Text = "Machines";
            // 
            // machineHiresToolStripMenuItem
            // 
            this.machineHiresToolStripMenuItem.Name = "machineHiresToolStripMenuItem";
            this.machineHiresToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.machineHiresToolStripMenuItem.Text = "Machine Hires";
            // 
            // machineServicesToolStripMenuItem
            // 
            this.machineServicesToolStripMenuItem.Name = "machineServicesToolStripMenuItem";
            this.machineServicesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.machineServicesToolStripMenuItem.Text = "Machine Services";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.healthAndSafteyToolStripMenuItem,
            this.machineSpecificToolStripMenuItem});
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // healthAndSafteyToolStripMenuItem
            // 
            this.healthAndSafteyToolStripMenuItem.Name = "healthAndSafteyToolStripMenuItem";
            this.healthAndSafteyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.healthAndSafteyToolStripMenuItem.Text = "Health and Saftey";
            // 
            // machineSpecificToolStripMenuItem
            // 
            this.machineSpecificToolStripMenuItem.Name = "machineSpecificToolStripMenuItem";
            this.machineSpecificToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.machineSpecificToolStripMenuItem.Text = "Machine Specific";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machineNameDataGridViewTextBoxColumn,
            this.machineClassificationDataGridViewTextBoxColumn,
            this.machineSerialNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.machinesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 173);
            this.dataGridView1.TabIndex = 3;
            // 
            // machineNameDataGridViewTextBoxColumn
            // 
            this.machineNameDataGridViewTextBoxColumn.DataPropertyName = "Machine Name";
            this.machineNameDataGridViewTextBoxColumn.HeaderText = "Machine Name";
            this.machineNameDataGridViewTextBoxColumn.Name = "machineNameDataGridViewTextBoxColumn";
            // 
            // machineClassificationDataGridViewTextBoxColumn
            // 
            this.machineClassificationDataGridViewTextBoxColumn.DataPropertyName = "Machine Classification";
            this.machineClassificationDataGridViewTextBoxColumn.HeaderText = "Machine Classification";
            this.machineClassificationDataGridViewTextBoxColumn.Name = "machineClassificationDataGridViewTextBoxColumn";
            // 
            // machineSerialNumberDataGridViewTextBoxColumn
            // 
            this.machineSerialNumberDataGridViewTextBoxColumn.DataPropertyName = "Machine Serial Number";
            this.machineSerialNumberDataGridViewTextBoxColumn.HeaderText = "Machine Serial Number";
            this.machineSerialNumberDataGridViewTextBoxColumn.Name = "machineSerialNumberDataGridViewTextBoxColumn";
            // 
            // machinesBindingSource
            // 
            this.machinesBindingSource.DataMember = "Machines";
            this.machinesBindingSource.DataSource = this.trompsDataSetBindingSource;
            // 
            // trompsDataSetBindingSource
            // 
            this.trompsDataSetBindingSource.DataSource = this.trompsDataSet;
            this.trompsDataSetBindingSource.Position = 0;
            // 
            // trompsDataSet
            // 
            this.trompsDataSet.DataSetName = "TrompsDataSet";
            this.trompsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trompsDataSetBindingSource1
            // 
            this.trompsDataSetBindingSource1.DataSource = this.trompsDataSet;
            this.trompsDataSetBindingSource1.Position = 0;
            // 
            // machinesTableAdapter
            // 
            this.machinesTableAdapter.ClearBeforeFill = true;
            // 
            // Machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 206);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Machines";
            this.Text = "Machines";
            this.Load += new System.EventHandler(this.MachineHire_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trompsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trompsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trompsDataSetBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource trompsDataSetBindingSource;
        private TrompsDataSet trompsDataSet;
        private System.Windows.Forms.BindingSource trompsDataSetBindingSource1;
        private System.Windows.Forms.BindingSource machinesBindingSource;
        private TrompsDataSetTableAdapters.MachinesTableAdapter machinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineClassificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineSerialNumberDataGridViewTextBoxColumn;
    }
}