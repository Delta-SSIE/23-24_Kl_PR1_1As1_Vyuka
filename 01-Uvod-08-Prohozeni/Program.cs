namespace _01_Uvod_08_Prohozeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hrnek = "mléko";
            string sklenice = "džus";

            //jak prohodíme? Jako na kuchyňské lince

            //potřebuju třetí - dočasnou proměnnou
            string tmp = hrnek; //přeleju do dočasné nádoby z hrnka
            hrnek = sklenice; //přeleju do hrnka ze sklenice
            sklenice = tmp; //přeleju do sklenice to, co jsem si odložil

            Console.WriteLine($"Ve sklenici je {sklenice}, v hrnku {hrnek}");
        }
    }
}
