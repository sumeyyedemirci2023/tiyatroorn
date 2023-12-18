using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiyatroornegi.Resources
{
    internal class Tiyatro
    {
        int id;
        string ad;
        DateTime tarih;
        int sure;
        string sahne;
        bool muzikal;
        int fiyat;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public int Sure { get => sure; set => sure = value; }
        public string Sahne { get => sahne; set => sahne = value; }
        public bool Muzikal { get => muzikal; set => muzikal = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }

        public Tiyatro(int id, string ad, DateTime tarih, int sure, string sahne, bool muzikal, int fiyat)
        {
            this.id = id;
            this.ad = ad;
            this.tarih = tarih;
            this.sure = sure;
            this.sahne = sahne;
            this.muzikal = muzikal;
            this.fiyat = fiyat;
        }
    }
}
