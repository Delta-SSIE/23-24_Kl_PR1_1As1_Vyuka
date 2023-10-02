namespace _02_Podminky_01_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //načíst číslo
            Console.WriteLine("Zadej číslo");
            string vstup = Console.ReadLine();
            double cislo = double.Parse(vstup);

            ////větvení
            //if (cislo > 7) //kulatá závorka nutná
            //{ //sem jdu jen v případě splněné podmínky
            //    Console.WriteLine($"Číslo {cislo} je velké");
            //}
            //else
            //{ //sem jdu, pokud splněno není
            //    Console.WriteLine($"Číslo {cislo} je malé");
            //}

            //větvení
            if (cislo > 100) //více ifů - zastaví se na prvním splněném
            { //sem jdu jen v případě splněné podmínky
                Console.WriteLine($"Číslo {cislo} je fakt velké");
            }
            
            else if (cislo > 7)
            {
                Console.WriteLine($"Číslo {cislo} je velké");
            }
            else
            { //sem jdu, pokud splněno není
                Console.WriteLine($"Číslo {cislo} je malé");
            }

        }
    }
}
