using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220042
{
    //Inheritance
    class Dokter : Profesi
    {
        // Constructor
        public Dokter(string jenis, string spesialis) : base(jenis, spesialis)
        { 
            this.jenis = jenis;
        }

    }
}
