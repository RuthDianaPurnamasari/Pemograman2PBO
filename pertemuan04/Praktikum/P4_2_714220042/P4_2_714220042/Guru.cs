using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220042
{
    //Inheritance
    class Guru : Profesi
    {
        //construct
        public Guru(string jenis, string spesialis) : base(jenis, spesialis)
        {
            this.jenis = jenis;
        }

    }
}
