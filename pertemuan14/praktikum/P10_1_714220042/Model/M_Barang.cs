﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_1_714220042.Model
{
    class M_Barang
    {
        string nama_barang, harga;
        public M_Barang()
        {
        }
        public M_Barang(string nama_barang, string harga)
        {
            this.Nama_barang = nama_barang;
            this.Harga = harga;
        }
        public string Nama_barang
        {
            get => nama_barang; set => nama_barang =
       value;
        }
        public string Harga { get => harga; set => harga = value; }
    }
}

