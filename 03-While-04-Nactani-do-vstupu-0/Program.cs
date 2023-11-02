namespace _03_While_04_Nactani_do_vstupu_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej čísla, já je budu sčítat. Vložení \"0\" zadávání ukončí");

            int soucet = 0;

            int cislo = int.Parse(Console.ReadLine());
            
            while(cislo != 0)
            {
                soucet += cislo;
                cislo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Součet je {soucet}.");
        }
    }
}
