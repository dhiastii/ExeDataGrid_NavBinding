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
    public partial class MainMenuu : Form
    {
        public MainMenuu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bindingnav2 bind2 = new bindingnav2();
            bind2.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void gridview_Click(object sender, EventArgs e)
        {
            tabeldata data = new tabeldata();
            data.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            TeknologiInformasi awal = new TeknologiInformasi();
            awal.Show();
            this.Hide();
        }
    }
}
