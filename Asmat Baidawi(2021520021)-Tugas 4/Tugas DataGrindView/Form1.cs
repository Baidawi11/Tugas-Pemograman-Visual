using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tugas_DataGrindView
{
    public partial class Form1 : Form
    {
        DataTable data = new DataTable();

        DataBarang toko = new DataBarang();

        private DataTable originalData;

        int baris;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = toko.GetData();
            originalData = toko.GetData();
            dataGridView1.DataSource = originalData;

            dataGridView1.Columns["Kode Barang"].Width = 100;
            dataGridView1.Columns["Nama Barang"].Width = 150;
            dataGridView1.Columns["Stok Barang"].Width = 90;

            baris = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Tambah")
            {
                button1.Text = "Simpan";
                //textKode.ReadOnly = false;
                textNama.ReadOnly = false;
                textStok.ReadOnly = false;
                textNama.Focus();
                button2.Enabled = false;
                button3.Enabled = false;

                textKode.Text = "BRT"+baris.ToString().PadLeft(3,'0');
                baris++; 
            }
            else
            {
                if (textNama.Text == "" || textStok.Text == "")
                {
                    MessageBox.Show("Data Tidak Boleh Kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    button1.Text = "Tambah";
                    //textKode.ReadOnly = true;
                    textNama.ReadOnly = true;
                    textStok.ReadOnly = true;
                    button2.Enabled = true;
                    button3.Enabled = true;

                    toko.TambahBarang(textKode.Text, textNama.Text, textStok.Text);

                    textKode.Clear();
                    textNama.Clear();
                    textStok.Clear();
                }
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Edit")
            {

                if (dataGridView1.Rows.Count > 0)
                {
                    button2.Text = "Update";
                    textNama.ReadOnly = false;
                    textStok.ReadOnly = false;
                    textNama.Focus();
                    button1.Enabled = false;
                    button3.Enabled = false;
                }
                else {
                    textNama.ReadOnly = true;
                    textStok.ReadOnly = true;
                    MessageBox.Show("Data Masih Kosong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                button2.Text = "Edit";

                int rowIndex = dataGridView1.CurrentRow.Index;
                toko.EditBarang(rowIndex ,textKode.Text, textNama.Text, textStok.Text);

                textNama.ReadOnly = true;
                textStok.ReadOnly = true;
                button1.Enabled = true;
                button3.Enabled = true;

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridView1.CurrentRow.Index;

                textKode.Text = dataGridView1.Rows[i].Cells["Kode Barang"].Value.ToString();
                textNama.Text = dataGridView1.Rows[i].Cells["Nama Barang"].Value.ToString();
                textStok.Text = dataGridView1.Rows[i].Cells["Stok Barang"].Value.ToString();
            }
            catch (Exception abc)
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            toko.DeleteBarang(rowIndex);
            textKode.Clear();
            textNama.Clear();
            textStok.Clear();
        }


        private bool mencari = false;

        private void button4_Click(object sender, EventArgs e)
        {
            if (!mencari)
            {
                // Ambil nama barang dari textBox1
                string namaBarang = textcari.Text;

                if (string.IsNullOrWhiteSpace(namaBarang))
                {
                    MessageBox.Show("Silakan masukkan nama barang untuk melakukan pencarian.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Lakukan pencarian berdasarkan nama barang
                DataRow[] cariBaris = originalData.Select("[Nama Barang] = '" + namaBarang + "'");

                if (cariBaris.Length > 0)
                {
                    // Buat tabel baru untuk menampilkan hasil pencarian
                    DataTable searchResult = cariBaris.CopyToDataTable();

                    // Tampilkan hasil pencarian di dataGridView1
                    dataGridView1.DataSource = searchResult;

                    // Ubah teks tombol menjadi "Kembalikan"
                    button4.Text = "Riset";
                    mencari = true;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Mengembalikan data ke keadaan asli
                dataGridView1.DataSource = originalData;

                // Ubah teks tombol menjadi "Cari" kembali
                button4.Text = "Cari";
                mencari = false;
            }
        }

        
    }
}
