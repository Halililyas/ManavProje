using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav_Gelismis_Getup
{

    
    public class Hal
    {
        public List<string> MeyvelerHal = new List<string>() { "KİRAZ", "ELMA", "KİVİ", "KARPUZ", "ARMUT" };
        public  List<int> MeyveKgHal = new List<int>() { 100, 100, 100, 100, 100 };

        public void Hesap(int index, int kg )
        {
        
        MeyveKgHal[index - 1] = MeyveKgHal[index - 1] - kg;
        }
        
        
        
        
        
        public void MeyvelerListe()
        {
            for (int i = 0; i < MeyvelerHal.Count; i++)
            {
                Console.WriteLine(i+1 + "-)" + MeyvelerHal[i] + " Kg : " + MeyveKgHal[i] );
                

            }
        }

    }
}
