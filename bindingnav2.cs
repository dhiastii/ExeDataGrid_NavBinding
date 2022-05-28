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
    public partial class bindingnav2 : Form
    {
        public bindingnav2()
        {
            InitializeComponent();
        }

        private void bindingnav2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet1.Mahasiswa1' table. You can move, or remove it, as needed.
            this.mahasiswa1TableAdapter.Fill(this.prodiTIDataSet1.Mahasiswa1);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenuu mainmenu = new MainMenuu();
            mainmenu.Show();
            this.Hide();
        }
    }
}
