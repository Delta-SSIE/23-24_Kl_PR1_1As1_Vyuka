namespace _05_Array_01_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] navstevy = new string[4]; //budu používat pole řetězců a má 4 prvky
            navstevy[0] = "Jarda"; //první prvek má index 0
            navstevy[1] = "Pepa";
            navstevy[2] = "Anežka";
            navstevy[3] = "Martina"; //poslední prvek má index (délka - 1)

            //procházení pole
            for (int i = 0; i < navstevy.Length; i++)
            {
                Console.WriteLine("Na večeři přijde také " + navstevy[i]);
            }


            int[] cisla = new int[3];
            cisla[0] = 7;
            cisla[1] = 2;
            cisla[2] = 113;

            for (int i = 0; i < cisla.Length; i++)
            {
                int cislo = cisla[i];
                if (cislo % 2 == 0)
                    Console.WriteLine($"Číslo {cislo} je sudé");
                else
                    Console.WriteLine($"Číslo {cislo} je liché");

            }

            Console.WriteLine();
            //vstup od uživatele
            int pocet = 10;
            int[] zadanaCisla = new int[pocet];

            Console.WriteLine($"Zadej {pocet} čísel");
            
            for (int i = 0; i < pocet; i++)
            {
                int cislo;
                string input;
                do
                {
                    Console.Write($"zadej {i + 1}. číslo: ");
                    input = Console.ReadLine();
                }
                while (!int.TryParse(input, out cislo));

                zadanaCisla[i] = cislo;
            }

            //vypis - třeba odzadu
            for (int i = zadanaCisla.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(zadanaCisla[i]);
            }

            double[] jinaCisla = { 1.3, 2.7, 4.9 };

            double soucet = 0;
            for (int i = 0; i < jinaCisla.Length; i++)
            {
                soucet += jinaCisla[i];
            }
            Console.WriteLine($"Součet je {soucet}");

        }
    }
}
