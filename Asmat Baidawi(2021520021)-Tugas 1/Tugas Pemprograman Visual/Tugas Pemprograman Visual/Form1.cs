using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tugas_Pemprograman_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Perkenalkan Nama Saya " + textBox1.Text + " Saya Kuliah di "+ textBox2.Text + " fakultas " + textBox3.Text + " dengan Jurasan " + textBox4.Text + " pada Angkatan "+ textBox5.Text);
        }
    }
}
