using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace mahirin_soruları
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rastgele Lig Yarışmamıza Hoş Geldiniz...");
            Console.WriteLine("Katılan Tüm Takımlara Başarılar Dileriz...\n");

            Random rastgele = new Random();

            int a1, b1, c1, d1;
            int a2, b2, c2, d2;
            int a3, b3, c3, d3;
         

            int gs = 0;
            int fb = 0;
            int bjk = 0;
            int ts = 0;
            int sayac = 1;

            if(sayac==1)
            {
                sayac++;
                a1 = rastgele.Next(0, 6);
                b1 = rastgele.Next(0, 6);
                c1 = rastgele.Next(0, 6);
                d1 = rastgele.Next(0, 6);
                Console.WriteLine("Birinci Hafta Skorları");
                Console.WriteLine("----------------------");

                Console.WriteLine("Galatasaray " + a1 + "-" + b1 + "Fenerbahçe");
                if(a1>b1)
                {
                    gs = gs + 3;
                }
                if(b1>a1)
                {
                    fb = fb + 3;
                }
                if(a1==b1)
                {
                    fb++;
                    gs++;
                }
                Console.WriteLine("Bşşiktaş " + c1 + "-" + d1 + "Trabzonspor");
                if(c1>d1)
                {
                    bjk = bjk + 3;
                }
                if(d1>c1)
                {
                    ts = ts + 3;

                }
                if(c1==d1)
                {
                    bjk++;
                    ts++;
                }
                Console.ReadLine();

            }

            if(sayac==2)
            {
                sayac++;
                a2 = rastgele.Next(0, 6);
                b2 = rastgele.Next(0, 6);
                c2 = rastgele.Next(0, 6);
                d2 = rastgele.Next(0, 6);

                Console.WriteLine("İkinci Hafta Skorları\n");
                Console.WriteLine("---------------------");

                Console.WriteLine("Beşiktaş " + c2 + "-" + a2 + "Galatasaray");
                if(c2>a2)
                {
                    bjk = bjk + 3;

                }
                if(a2>c2)
                {
                    gs = gs + 3;
                }
                if(a2==c2)
                {
                    bjk++;
                    gs++;
                }
 
                Console.WriteLine("Fenerbahçe " + b2 + "-" +d2+ "Trabzonspor");
                if(b2>d2)
                {
                    fb = fb + 3;

                }
                if(d2>b2)
                {
                    ts = ts + 3;
                }
                if(d2==b2)
                {
                    ts++;
                    fb++;
                }
                Console.ReadLine();

            }


            if(sayac==3)
            {
                sayac++;
                a3 = rastgele.Next(0, 6);
                b3 = rastgele.Next(0, 6);
                c3 = rastgele.Next(0, 6);
                d3 = rastgele.Next(0, 6);

                Console.WriteLine("Üçüncü Hafta Skorları\n");
                Console.WriteLine("---------------------");

                Console.WriteLine("Trabzonspor " + d3 + "-" + a3+ "Galatasaray");
                if(d3>a3)
                {
                    ts = ts + 3;
                }
                if(a3>d3)
                {
                    gs = gs + 3;
                }
                if(a3==d3)
                {
                    gs++;
                    ts++;
                }
                Console.WriteLine("Beşiktaş " + c3 + "-" + b3 + "Fenerbahçe");
                if(c3>b3)
                {
                    bjk = bjk + 3;
                }
                if(b3>c3)
                {
                    fb = fb + 3;
                }
                if(bjk==fb)
                {
                    bjk++;
                    fb++;
                }
                Console.ReadLine();

            }

            Console.WriteLine("Galatasaray: " + gs);
            Console.WriteLine("Fenerbahçe: " + fb);
            Console.WriteLine("Beşiktaş: " + bjk);
            Console.WriteLine("Trabzonspor: " + ts);

            SoundPlayer ses = new SoundPlayer();
            string yol;
            if(gs>fb && gs>bjk && gs>ts)
            {
                yol = "gs.wav";
                ses.SoundLocation = yol;
                ses.Play();
            }
            if(fb>gs && fb> bjk && fb>ts)
            {
                yol = "fb.wav";
                ses.SoundLocation = yol;
                ses.Play();

            }
            if(bjk>gs && bjk>fb && bjk>ts)
            {
                yol = "bjk.wav";
                ses.SoundLocation = yol;
                ses.Play();
            }
            if(ts>gs && ts>fb && ts>bjk)
            {
                yol = "ts.wav";
                ses.SoundLocation = yol;
                ses.Play();
            }

            Console.ReadLine();
        }
    }
}