using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }

       
        public static int LLPersonelInsert( EntityPersonel p)
        {
            if (p.Ad != ""  &&   p.Soyad != "" && p.maas >=4000 &&p.ad.Length >=3)
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLPersonelSil(int per)
        {
            if (per<= 0)
            {
                return false;
            }
            else
            {
               return DALPersonel.PersonelSil(per);
            }
        }
        public static bool LLPersonelGuncelle (EntityPersonel entP)
        {
            if (entP.Ad.Length >= 3 && entP.Ad != "")
            {
                return DALPersonel.PersonelGuncelle(entP);
            }
            else
            {
                return false;   
            }    
        }
    }
}
