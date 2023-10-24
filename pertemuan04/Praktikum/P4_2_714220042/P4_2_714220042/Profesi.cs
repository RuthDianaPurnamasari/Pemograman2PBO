using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220042
{
    public class Profesi
    {
        //field
        public string jenis;
        public string spesialis;

        //constructor
        public Profesi(string jenis, string spesialis)
        {
            this.jenis = jenis;
            this.spesialis = spesialis;
        }

        //property
        public string Jenis
        {
            get { return jenis; }
            set { jenis = value; }
        }

        public string Spesialis
        {
            get { return spesialis; }
            set { spesialis = value; }
        }
    }
}
