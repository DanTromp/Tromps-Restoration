using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tromps_Restoration
{
    public partial class Machines : Form
    {
        public Machines()
        {
            InitializeComponent();
        }

        private void MachineHire_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trompsDataSet.Machines' table. You can move, or remove it, as needed.
            this.machinesTableAdapter.Fill(this.trompsDataSet.Machines);

        }
    }
}
