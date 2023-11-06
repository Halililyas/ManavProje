using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav_Gelismis_Getup
{
    public class Manav
    {
        List<string> MeyveManav = new List<string>();
        List<int> MeyveKgManav = new List<int>();
       
        public void MeyveAra(string Meyve , int kg )


        {
            Hal hal = new Hal();
            int indexarama = hal.MeyvelerHal.IndexOf(Meyve);
            if (hal.MeyvelerHal.Contains(Meyve) == true && hal.MeyveKgHal[indexarama-1] >=kg )
            {
                hal.Hesap(indexarama,kg);
               
                MeyveManav.Add(Meyve);
                MeyveKgManav.Add(kg);
            }
            else
            {
                Console.WriteLine("Yazdığınız Ürün Bulunamadı Tekrar Deniyiniz ");
            }
            
        }

        public void MeyveListe()
        {
            for (int i = 0; i < MeyveManav.Count; i++)
            {
                Console.WriteLine(i+1 +"-)"+ MeyveManav[i] + "KG :" + MeyveKgManav[i]);
            }
        }

    }
}
