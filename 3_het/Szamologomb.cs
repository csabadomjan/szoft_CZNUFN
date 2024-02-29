using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _3_het
{
    internal class Szamologomb : Villogogomb
    {
        int szam = 0;
        public Szamologomb()
        {
            MouseClick += Szamologomb_MouseClick;
        }

        private void Szamologomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (szam <= 10)
            {
                szam++;
            }
            else
            {
                /*szam += 1;*/
                szam = 0;



            }
            Text = szam.ToString();
        }
    }
}
