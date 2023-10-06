namespace _05_Podminky_06_Ternarni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hranice = 7; //rozhraní mezi malým a velkým

            //Načíst číslo
            Console.WriteLine("Zadej číslo");
            string vstup = Console.ReadLine();
            double cislo = double.Parse(vstup);

            //ternární operátor
            string vysledek = cislo > hranice ? "velké" : "malé";

            //string vysledek; //připravim proměnnou bez obsahu
            //if (cislo > hranice)
            //{
            //    vysledek = "velké";
            //}
            //else
            //{
            //    vysledek = "malé";
            //}

            Console.WriteLine($"Číslo {cislo} je {vysledek}.");
        }
    }
}
