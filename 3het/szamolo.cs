using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3het
{
    internal class SzamoloGomb : VillogoGomb
    {
        public int szam = 0;
        public SzamoloGomb()
        {
            MouseClick += SzamoloGomb_MouseClick;
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            szam++;
            Text = szam.ToString();
            if (szam == 6)
            {
                szam = 0;
            }
        }
    }
}
