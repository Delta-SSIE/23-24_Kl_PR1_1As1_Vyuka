namespace _03_While_09_Nejmensi_z_deseti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Úkol: Zeptat se uživatele na 10 čísel, pak říci, které je nejmenší z nich
            Console.WriteLine("Zadej deset čísel, já zjistím nejmenší z nich.");

            //vytvořit si úložiště pro minimum
            //dát do něj výchozí hodnotu - největší povolené číslo
            int min = int.MaxValue;

            //načítat čísla
            int i = 0;
            while (i < 10) {
                i++;
                Console.Write($"Zadej {i}. číslo: ");

                int cislo;
                while (!int.TryParse(Console.ReadLine(), out cislo))
                {
                    Console.WriteLine("Seš mamlas, řekl jsem zadej číslo");
                }

                //když je načtené číslo menší, než zapamatované minimum,
                //aktualizovat minimum
                if (cislo < min)
                    min = cislo;                
            }

            Console.WriteLine($"Zadané minimum bylo {min}.");
        }
    }
}
