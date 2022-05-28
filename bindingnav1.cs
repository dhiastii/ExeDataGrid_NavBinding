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
    public partial class bindingnav1 : Form
    {
        public bindingnav1()
        {
            InitializeComponent();
        }

        private void bindingnav1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenuu mainmenu = new MainMenuu();
            mainmenu.Show();
            this.Hide();
        }
    }
}
