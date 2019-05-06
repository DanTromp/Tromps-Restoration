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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "ADMIN")
                if (password == "Tromps1")
                {
                    this.Hide();
                    home.Show();                    
                }
                else
                    return;
        }
    }
}
