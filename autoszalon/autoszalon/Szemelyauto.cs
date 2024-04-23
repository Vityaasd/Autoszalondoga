using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoszalon
{
    public class Szemelyauto : Jarmu
    {
        public int UlesekSzama { get; set; }
        public double Fogyasztas { get; set; }
        public string Szin { get; set; }

        public Szemelyauto(string gyarto, string modell, int evjarat, int alapAr, int kmAllas, int ulesekSzama, double fogyasztas, string szin)
            : base (gyarto, modell, evjarat, alapAr, kmAllas)
        {
            UlesekSzama = ulesekSzama;
            Fogyasztas = fogyasztas;
            Szin = szin;
        }

        public void KenyelmiExtraBeszerzese(string extra)
        {
            if (extra == "prémium hangrendszer")
            {
                AlapAr += 500000;
            }
            else if (extra == "napfénytető")
            {
                AlapAr += 300000;
            }
        }

        public void SzinFrissitese(string ujSzin)
        {
            Szin = ujSzin;
        }
    }
}
