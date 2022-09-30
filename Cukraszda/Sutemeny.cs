using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cukraszda
{
    internal class Sutemeny
    {
        public string Nev { get; set; }
        public int Ar { get; set; }

        public Sutemeny(string sor)
        {
            string[] adat = sor.Split(';');
            Nev = adat[0];
            Ar = int.Parse(adat[1]);
        }
    }
}
