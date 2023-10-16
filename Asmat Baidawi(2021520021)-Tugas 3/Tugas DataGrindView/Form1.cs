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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data.Columns.Add("Kode Barang");
            data.Columns.Add("Nama Barang");
            data.Columns.Add("Stok Barang");

            dataGridView1.DataSource = data;

            dataGridView1.Columns["Kode Barang"].Width = 100;
            dataGridView1.Columns["Nama Barang"].Width = 150;
            dataGridView1.Columns["Stok Barang"].Width = 90;

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

                textKode.Text = "BR"+(data.Rows.Count+1).ToString().PadLeft(3,'0');
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
                    string[] array_data = new string[3];
                    array_data[0] = textKode.Text;
                    array_data[1] = textNama.Text;
                    array_data[2] = textStok.Text;

                    data.Rows.Add(array_data);


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

                if (data.Rows.Count > 0){
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

                data.Rows[dataGridView1.CurrentRow.Index][0] = textKode.Text;
                data.Rows[dataGridView1.CurrentRow.Index][1] = textNama.Text;
                data.Rows[dataGridView1.CurrentRow.Index][2] = textStok.Text;

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
            int i = dataGridView1.CurrentRow.Index;

            if (data.Rows.Count > 0)
            {
                data.Rows[i].Delete();

                if (data.Rows.Count == 0)
                {
                    textKode.Clear();
                    textNama.Clear();
                    textStok.Clear();
                }
            }
        }
        
    }
}
