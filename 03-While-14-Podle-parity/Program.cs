namespace _03_While_14_Podle_parity
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int sude = 0;
            int liche = 0;
            int cislo;
            do
            {
                Console.WriteLine("Zadej prirozene cislo");
                string vstup = Console.ReadLine();

                while (!int.TryParse(vstup, out cislo))
                {
                    Console.WriteLine("Zadej prosim prirozene cislo");
                    vstup = Console.ReadLine();
                }
                if (cislo > 0)
                {
                    if (cislo % 2 == 0)
                    {
                        sude++;
                    }
                    else
                    {
                        liche++;
                    }
                }
            }
            while (cislo > 0);

            Console.WriteLine($"Zadal jsi {sude} sudych cisel a {liche} lichych cisel");

        }
    }
}
