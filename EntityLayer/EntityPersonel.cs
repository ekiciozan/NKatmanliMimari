using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonel
    {
        private int id;
        public string ad;
        public string soyad;
        public string gorev;
        public string sehir;
        public short maas;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Gorev { get => gorev; set => gorev = value; }
        public string Sehir { get => sehir; set => sehir = value; }

        public short Maas { get { return maas; } set { maas = value; } }
    }
}
