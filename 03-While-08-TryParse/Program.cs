namespace _03_While_08_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo:");
            string vstup = Console.ReadLine();
            //int cislo = int.Parse(vstup); //spadne při neplatném vstupu
            //Console.WriteLine(cislo * 10);

            //int cislo;
            //bool vysloTo = int.TryParse(vstup, out cislo); //zkusí parsovat, vrací, jestli to lze, naplní proměnnou cislo parsovanou hodnotou, nebo do ní dá 0
            //if (vysloTo)
            //{
            //    Console.WriteLine("Zadal jsi " + cislo);
            //}
            //else
            //{
            //    Console.WriteLine($"Řetězec \"{vstup}\" nelze parsovat");
            //}
            
            int cislo;
            while (!int.TryParse(vstup, out cislo))
            {
                Console.WriteLine("Seš mamlas, řekl jsem zadej číslo");
                vstup = Console.ReadLine();
            }
            Console.WriteLine("Zadal jsi " + cislo);
        }
    }
}
