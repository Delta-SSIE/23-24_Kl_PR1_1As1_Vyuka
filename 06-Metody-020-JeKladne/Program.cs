namespace _06_Metody_020_JeKladne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] cisla = [1.3, -2.7, -16, 4.43, 0];
            for (int i = 0; i < cisla.Length; i++)
            {
                if (JeKladne(cisla[i]))
                    Console.WriteLine($"Číslo {cisla[i]} je kladné");
                else
                    Console.WriteLine($"Číslo {cisla[i]} není kladné");
            }
        }
        static bool JeKladne(double cislo)
        {
            return cislo > 0;

            //if (cislo <= 0)
            //    return false;
            //else
            //    return true;
            
            //return cislo <= 0 ? false : true;
        }         
    }
}
