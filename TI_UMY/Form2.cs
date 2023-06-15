using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_UMY
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet1.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet1.Mahasiswa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            // Mendapatkan indeks baris dan kolom sel yang diklik
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            // Mengakses data pada sel yang diklik
            object cellValue = dataGridView1.Rows[rowIndex].Cells[columnIndex].Value;

            Form3 form3 = new Form3(cellValue.ToString());
            // Lakukan sesuatu dengan data yang diakses
            form3.Show();
            this.Hide();
        }

    }
}
