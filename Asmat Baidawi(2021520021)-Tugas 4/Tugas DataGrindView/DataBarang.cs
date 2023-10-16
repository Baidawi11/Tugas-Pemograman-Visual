using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tugas_DataGrindView
{
   internal class DataBarang
    {
        DataTable data = new DataTable();

        public DataBarang() 
        {
            data.Columns.Add("Kode Barang");
            data.Columns.Add("Nama Barang");
            data.Columns.Add("Stok Barang");
        }

        public DataTable GetData()
        {
            return data;
        }


        public void TambahBarang(string kode, string nama, string stok)
        {
            string[] arrayData = new string[3];
            arrayData[0] = kode;
            arrayData[1] = nama;
            arrayData[2] = stok;
            data.Rows.Add(arrayData);

        }

        public void EditBarang(int rowIndex, string kode,string nama, string stok)
        {
            data.Rows[rowIndex][0] = kode;
            data.Rows[rowIndex][1] = nama;
            data.Rows[rowIndex][2] = stok;
        }

        public void DeleteBarang(int rowIndex)
        {
            if (data.Rows.Count > 0)
            {
                data.Rows[rowIndex].Delete();

                if (data.Rows.Count == 0)
                {
                   
                }
            }
        }
    }
}
