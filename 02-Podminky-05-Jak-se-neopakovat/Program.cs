namespace _02_Podminky_05_Jak_se_neopakovat
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


            string vysledek; //připravim proměnnou bez obsahu
            
            if (cislo > hranice)
            { //sem jdu jen v případě splněné podmínky
                vysledek = "velké";
            }
            else
            { //sem jdu, pokud splněno není
                vysledek = "malé";
            }

            Console.WriteLine($"Číslo {cislo} je {vysledek}.");
        }
    }
}
