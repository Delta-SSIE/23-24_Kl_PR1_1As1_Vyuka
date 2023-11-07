using System.Diagnostics;

namespace _03_While_10_SOucet_v_intervalu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //načtu začátek
            //int zacatek = int.Parse(Console.ReadLine());

            //načtu konec
            //int konec = int.Parse(Console.ReadLine());

            int zacatek = 1;
            int konec = 20_000_000;

            if (konec < zacatek)
            {
                int tmp = zacatek;
                zacatek = konec;
                konec = tmp;
            }

            Stopwatch stopky = new Stopwatch();
            stopky.Start();

            //připravím si promenné pro součet
            long soucet = 0;
            int kdeJsem = zacatek;

            //dokud nepřekročím konec
            while (kdeJsem <= konec)
            {
                //přidám číslo do součtu
                soucet += kdeJsem;
                //přejdu na další
                kdeJsem++;
            }

            stopky.Stop();

            Console.WriteLine(soucet);
            Console.WriteLine("trvalo " + stopky.ElapsedMilliseconds);

            stopky.Reset();
            stopky.Start();

            long soucetJinak = ((long)zacatek + konec) * (konec - zacatek + 1) / 2; //rozmysli si ...
            stopky.Stop();

            Console.WriteLine(soucetJinak);
            Console.WriteLine("trvalo " + stopky.ElapsedMilliseconds);

        }
    }
}
