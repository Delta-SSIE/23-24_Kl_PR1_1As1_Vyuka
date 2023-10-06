namespace _05_Podminky_07_Nacteni_klavesy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mám jít nakoupit (A/N)");
            bool nakoupit;

            //
            char odpoved = Console.ReadKey().KeyChar;
            if (odpoved == 'A' || odpoved == 'a')
                nakoupit = true;
            else
                nakoupit = false;

            //zde naplnit promennou
            //

            if (nakoupit)
            {
                Console.WriteLine("Jdu do obchodu");
            }
            else
            {
                Console.WriteLine("Jdu na ryby");
            }


        }
    }
}
