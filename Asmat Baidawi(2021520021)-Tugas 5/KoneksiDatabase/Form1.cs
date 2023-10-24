using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KoneksiDatabase
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
            dataTable = new DataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection koneksi = new MySqlConnection();
                koneksi.ConnectionString = "datasource=localhost;uid=root;pwd=;database=kampus";
                koneksi.Open();

                string query = "SELECT * FROM mahasiswa";
                MySqlCommand ambil = new MySqlCommand(query, koneksi);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(ambil);
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                dataGridView1.Columns["Nama"].Width = 150;
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.ToString());
            }
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            string filter = "[Nama] like '%" + cari.Text + "%' OR [NIM] like '%" + cari.Text + "%' OR [Alamat] like '%" + cari.Text + "%' OR [Jenis Kelamin] like '%" + cari.Text + "%'";
            dataTable.DefaultView.RowFilter = filter;
        }
    }
}
