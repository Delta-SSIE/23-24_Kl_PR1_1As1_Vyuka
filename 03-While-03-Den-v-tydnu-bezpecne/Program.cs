namespace _03_While_03_Den_v_tydnu_bezpecne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo dne (1-7): ");
            int cisloDne = int.Parse(Console.ReadLine());

            while (cisloDne < 1 || cisloDne > 7) //když je den neplatný, načítej
            {
                Console.WriteLine("Chyba zadání");
                cisloDne = int.Parse(Console.ReadLine());
            }

            string den;

            switch (cisloDne)
            {
                case 1:
                    den = "pondělí";
                    break;
                case 2:
                    den = "úterý";
                    break;
                case 3:
                    den = "středa";
                    break;
                case 4:
                    den = "čtvrtek";
                    break;
                case 5:
                    den = "pátek";
                    break;
                case 6:
                    den = "sobota";
                    break;
                case 7:
                    den = "neděle";
                    break;
                default:
                    den = string.Empty;
                    break;
            }

            Console.WriteLine($"Dnes je {den}.");

        }
    }
}
