using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_AtaSaat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForLoop();
        }

        static void ForLoop()
        {
            basla:
            var h = 0;
            var m = 0;
            var s = 0;
            var dakika = 0;
            var saat = 0;
            var saniye = 0;
            for (saat = h; saat < 24; saat++)
                //saat sıfırdır saat 24'ten küçükse saate 1 ekle
            {

                for (dakika = m; dakika < 60; dakika++)
                    // dakika sıfırdır dakika altmıştan küçükse dakikayı 1 arttır
                {

                    for (saniye = s; saniye < 60; saniye++)
                        // saniye sıfıra eşittir saniye altmıştan küçükse 1 arttır
                    {
                        Console.WriteLine($@"{saat.ToString("D2")}:{dakika.ToString("D2")}:{saniye.ToString("D2")}");
                        //tek basamaklı sayılarda ilk rakamı 0 yapar
                        Thread.Sleep(1000);
                        //1 saniye ileri bekler
                        Console.Clear();
                        //konsolu temizler
                    }
                    s = 0;
                }
                m = 0;
                

            }
            goto basla;
            //basla konumuna gider
        }
        
    }

}
