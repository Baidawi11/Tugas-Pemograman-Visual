using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tugas_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string jk; //buat variabel baru untuk menampung jenis kelamin di radiobutton
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            jk = radioButton1.Text; //variabel jika diisi text radioButton1 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            jk = radioButton2.Text; //variabel jika diisi text radioButton2
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBoxNama2.Text = textBoxNama1.Text; //memindah kan isi text textBoxNama1 ke textBoxNama2
            textBoxJk.Text = jk; //tampilkan radiobutton yang di pilih ke textBoxJk
            textBoxAlamat2.Text = textBoxAlamat1.Text;

            textBox_kabupaten.Text = comboBoxKabupaten.SelectedItem.ToString();//menampilkan isi comboBox
            textBox_kecamatan.Text = combo_kecamatan.SelectedItem.ToString();
            textBox_desa.Text = combo_desa.SelectedItem.ToString();

        }

        private void comboBoxKabupaten_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedKabupaten = comboBoxKabupaten.SelectedItem.ToString();

            // Menghapus semua item dari combo_kecamatan
            combo_kecamatan.Items.Clear();

            // Menambahkan item-item ke combo_kecamatan sesuai dengan pilihan kabupaten
            if (selectedKabupaten == "Kabupaten Pamekasan")
            {
                combo_kecamatan.Items.AddRange(new string[] {
            "Kecamatan Tlanakan",
            "Kecamatan Proppo",
            "Kecamatan Batu Marmar",
            "Kecamatan Galis",
            "Kecamatan Kadur",
            "Kecamatan Larangan",
            "Kecamatan Pademawu",
            "Kecamatan Pakong",
            "Kecamatan Palengaan",
            "Kecamatan Pamekasan",
            "Kecamatan Pasean",
            "Kecamatan Pegantenan",
            "Kecamatan Proppo",
            "Kecamatan Waru"
        });
            }
            else if (selectedKabupaten == "Kabupaten Sampang")
            {
                combo_kecamatan.Items.AddRange(new string[] {
            "Kecamatan Banyuates",
            "Kecamatan Camplong",
            "Kecamatan Jrengik",
            "Kecamatan Karang Penang",
            "Kecamatan Kedungdung",
            "Kecamatan Ketapang",
            "Kecamatan Omben",
            "Kecamatan Pangarengan",
            "Kecamatan Robatal",
            "Kecamatan Sampang",
            "Kecamatan Sokobanah",
            "Kecamatan Sreseh",
            "Kecamatan Tambelangan",
            "Kecamatan Torju"
        });
            }
            else if (selectedKabupaten == "Kabupaten Sumenep")
            {
                combo_kecamatan.Items.AddRange(new string[] {
            "Kecamatan Arjasa",
            "Kecamatan Batang-Batang",
            "Kecamatan Batuan",
            "Kecamatan Bluto",
            "Kecamatan Camplong",
            "Kecamatan Dasuk",
            "Kecamatan Dungkek",
            "Kecamatan Ganding",
            "Kecamatan Gapura",
            "Kecamatan Gayam",
            "Kecamatan Giligenteng",
            "Kecamatan Gili Iyang"
        });
            }

        }


        private void combo_kecamatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedKecamatan = combo_kecamatan.SelectedItem.ToString();

            combo_desa.Items.Clear(); // Menghapus semua item dari combo_desa

            // Menambahkan item-item ke combo_desa sesuai dengan pilihan kecamatan
            if (selectedKecamatan == "Kecamatan Tlanakan")
            {
                combo_desa.Items.AddRange(new string[] {

                    "Desa Kramat",
                    "Desa Mangar",
                    "Desa Terrak",
                    "Desa Gugul",
                    "Desa Larangan",
                    "Desa Panglegur",
                    "Desa Bandaran",
                    "Desa Branta Pasisir",
                    "Desa Ambat",
                    "Desa Taro'an",
                    "Desa Tlesa",
        });
            }
            else if (selectedKecamatan == "Kecamatan Proppo")
            {
                combo_desa.Items.AddRange(new string[] {
            "Desa Badung",
            "Desa Gro'om",
            "Desa Karanganyar",
            "Desa Klampar",
            "Desa Kodik",
            "Desa Lenteng",
            "Desa Mapper",
            "Desa Panaguan",
            "Desa Pangbatok",
            "Desa Pangtonggal",
            "Desa Batu Kalangan"
        });
            }
            else if (selectedKecamatan == "Kecamatan Batu Marmar")
            {
                combo_desa.Items.AddRange(new string[] {
            "Desa Bangsereh",
            "Desa Blaban",
            "Desa Bujur Barat",
            "Desa Bujur Tengah",
            "Desa Bujur Timur",
            "Desa Kapong",
            "Desa Lesong Daja",
            "Desa Lesong Laok",
            "Desa Pangereman",
            "Desa Ponjanan Barat",
            "Desa Ponjanan Timur"
        });
            }
            else if (selectedKecamatan == "Kecamatan Galis")
            {
                combo_desa.Items.AddRange(new string[] {
            "Desa Artodung",
            "Desa Bulay",
            "Desa Galis",
            "Desa Konang",
            "Desa Lembung",
            "Desa Pagendingan",
            "Desa Pandan",
            "Desa Polagan",
            "Desa Tobungan"
        });
            }
        }

    }
}
