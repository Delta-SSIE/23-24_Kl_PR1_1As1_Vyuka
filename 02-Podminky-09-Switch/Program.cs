using System.Text.Json;

namespace _02_Podminky_09_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jaké je číslo dnešního dne (1-7): ");
            int cisloDne = int.Parse(Console.ReadLine());

            switch (cisloDne)
            {
                case 1:
                    Console.WriteLine("pondělí");
                    break;

                case 2:
                    Console.WriteLine("úterý");
                    break;

                case 3:
                    Console.WriteLine("středa");
                    break;

                case 4:
                    Console.WriteLine("čtvrtek");
                    break;

                case 5:
                    Console.WriteLine("pátek");
                    break;

                case 6:
                    Console.WriteLine("sobota");
                    break;

                case 7:
                    Console.WriteLine("neděle");
                    break;

                default: //všechny ostatní případy
                    Console.WriteLine("Píšeš nesmysly");
                    break;
            }

            switch (cisloDne)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("není víkend");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("je víkend");
                    break;

            }

        }
    }
}
