namespace _10_EnumEx_03_Demo_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double podil = Podil("10", "nula");
                Console.WriteLine(podil);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nulou se nedělí");
            }
            catch (FormatException)
            {
                Console.WriteLine("Neplatný formát vstupu");
            }
            catch
            {
                Console.WriteLine("Došlo k neznámé chybě");
            }

            //try 
            //{ 
            //    int cislo = Nacti("Hello, World!");
            //}
            //catch
            //{
            //    Console.WriteLine("Nejde to načíst");
            //}
        }
        static int Nacti(string retezec)
        {
            return int.Parse(retezec);
        }
        static double Podil(string delenec, string delitel)
        {
            double delenecCislo = double.Parse(delenec);
            double delitelCislo = double.Parse(delitel);

            if (delitelCislo == 0)
                throw new DivideByZeroException("Pokus o dělení nulou v racionálních číslech");
            return delenecCislo / delitelCislo;
        }
    }
}
