using System.Diagnostics;

namespace _12_Kolekce_02_List_vykon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1_000_000;
            //List<int> cisla = new List<int>{ 0, 1, 2, 3 ,4, 5, 6 ,7 ,8 ,9 ,10 };
            List<int> cisla = new List<int>(10000);
            for (int i = 0; i < cisla.Count; i++)
            {
                cisla.Add(i);
            }
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < n; i++)
            {
                cisla.Add(0); //přidání na konec
                cisla.RemoveAt(cisla.Count - 1); //smazání posledního
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);


            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < n; i++)
            {
                cisla.Insert(0,0);
                cisla.RemoveAt(0);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

        }
    }
}
