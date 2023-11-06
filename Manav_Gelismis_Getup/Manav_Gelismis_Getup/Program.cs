using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Manav_Gelismis_Getup
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hal hal = new Hal();
            Manav manav = new Manav();

            Console.WriteLine("******* MANAV OTOMASYONUNA HOŞ GELDİNİZ *******");
            while (true)
            {


                Console.WriteLine("Hale Hoş Geldiniz Meyveler İçin (M) Sebzeler İçin (S) Basınız ");
                string sec = Console.ReadLine().ToUpper();
                Console.Clear();
                if (sec == "M")
                {
                   

                    hal.MeyvelerListe();

                        Console.WriteLine("Alıcağı Meyveyi Yazınız ");
                        string Meyve = Console.ReadLine().ToUpper();

                        Console.WriteLine("Kaç Kilo Alıcaksınız :");
                        int kg = Convert.ToInt16(Console.ReadLine());

                        manav.MeyveAra(Meyve, kg);
                        Console.WriteLine("Başka Arzunuz Varmı Evet için (E) Hayır İçin (H)");
                        string Sec = Console.ReadLine().ToUpper();
                        if (Sec=="E")
                        {
                        Console.Write("Tekrar Ana menüye Yönlendiriliyosunuz ");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.Write(".");
                       
                    }
                    else if(Sec == "H")
                        {
                            Console.WriteLine("Manava Hoş Geldiniz Meyveler İçin (M) Sebzeler İçin (S) Basınız ");
                        string SEC = Console.ReadLine().ToUpper() ;
                        if (SEC == "M")
                        {
                            manav.MeyveListe();
                        }
                        }
                    }

                
            }
            Console.ReadLine();
        }
    }
}
