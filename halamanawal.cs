using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGrid_NavBinding
{
    public partial class TeknologiInformasi : Form
    {
        public TeknologiInformasi()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usrname = username.Text;
            string pssword = password.Text;

            if (usrname == "dhiastii" && pssword == "12345maba")
            {
                MainMenuu mainmenu = new MainMenuu();
                mainmenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void TeknologiInformasi_Load(object sender, EventArgs e)
        {

        }
    }
}
