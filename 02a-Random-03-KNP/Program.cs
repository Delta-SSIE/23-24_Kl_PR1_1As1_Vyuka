namespace _02a_Random_03_KNP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Budeme hrát Kámen/Nůžky/Papír");

            //načtení figury hráče
            Console.WriteLine("Zvol figuru (k/n/p): ");
            char znakHrac = Console.ReadKey().KeyChar;
            Console.WriteLine(); //to je jen odřádkování za stiskem klávesy

            znakHrac = char.ToLower(znakHrac);

            if (znakHrac != 'k' && znakHrac != 'n' && znakHrac != 'p')
            {
                Console.WriteLine("Neplatný symbol, ukončuji hru.");
                return;
            }


            //načtení figury PC
            Random random = new Random();
            int nahCislo = random.Next(0, 3);
            
            char znakPC = '\0'; //naplním jakoukoli výchozí hodnotou
            switch (nahCislo)
            {
                case 0:
                    znakPC = 'k';
                    break;
                case 1:
                    znakPC = 'n';
                    break;
                case 2:
                    znakPC = 'p';
                    break;
                //default: //jen aby si nemyslel, že ve znakPC nemůže nic být
                //    znakPC = '\0';
                //    break;
            }


            //vyhodnocení
            string vysledek;
            if (znakPC == znakHrac)
            { 
                vysledek = "Remíza";
            }
            else if (
                (znakPC == 'k' && znakHrac == 'n')
                || (znakPC == 'n' && znakHrac == 'p')
                || (znakPC == 'p' && znakHrac == 'k')
            )
            {
                vysledek = "Vítězí počítač";
            }
            else
            {
                vysledek = "Vítězí hráč";
            }

            //závěr
            Console.WriteLine($"{vysledek} ({znakHrac} : {znakPC}).");
        }
    }
}
