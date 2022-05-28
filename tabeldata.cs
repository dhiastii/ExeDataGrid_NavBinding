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
    public partial class tabeldata : Form
    {
        public tabeldata()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet1.Mahasiswa1' table. You can move, or remove it, as needed.
            this.mahasiswa1TableAdapter.Fill(this.prodiTIDataSet1.Mahasiswa1);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);


            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.DarkBlue;
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.DarkCyan;
            this.dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Maroon;
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Green;
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.Blue;
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
        }
        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Pink;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Orange;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Green;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.DodgerBlue;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
            else if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.SaddleBrown;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Purple;
            }
            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Blue;
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.DarkCyan;
            }
            else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Green;
            }
            else if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dataGridView1[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Red;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingnav1 bind1 = new bindingnav1();
            bind1.nimmhs.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bind1.namamhs.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            bind1.alamatmhs.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            bind1.sexmhs.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            bind1.tlpmhs.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            bind1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenuu mainmenu = new MainMenuu();
            mainmenu.Show();
            this.Hide();
        }
    }
}