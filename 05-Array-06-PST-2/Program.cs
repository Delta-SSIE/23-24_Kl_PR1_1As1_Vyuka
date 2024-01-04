namespace _05_Array_06_PST_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1000000;
            int k = 6;

            int maxSoucet = 6 * k;
            int minSoucet = k;

            int[] pocty = new int[maxSoucet + 1];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int hodCelkem = 0;
                for (int j = 0; j < k; j++)
                {
                    hodCelkem += rnd.Next(1, 7);
                }
                pocty[hodCelkem]++;
            }

            for (int i = minSoucet; i <= maxSoucet; i++)
            {
                double pst = Convert.ToDouble(pocty[i]) / n;
                Console.WriteLine($"{i}: {pst}");
            }


            //int[] hodnoty = { 100, 300, 200, 400, 700, 1200, 400 };

            //v C# lze zjistit aktuální šířku okna konzole tímto způsobem
            int delkaRadky = Console.WindowWidth - 5;
            //těch - 5 odpovídá úvodním znakům, které vypíšeme na začátek každé řádky


            //Zjistím největší číslo
            int max = 0;
            for (int i = 0; i < pocty.Length; i++)
            {
                if (pocty[i] > max)
                {
                    max = pocty[i];
                }
            }
            //v proměnné max je teď maximum z pole hodnoty


            for (int i = minSoucet; i <= maxSoucet; i++)
            {
                //záhlaví řádku
                Console.Write($"{i}: ".PadLeft(5, ' '));

                //Počet symbolů vezmu jako aktuální číslo v poli, ale vydělím max číslem 
                //(to by dalo desetinné číslo mezi 0 a 1) a vynásobím délkou řádky.
                //Říká se tomu normování.
                int pocetSymbolu = pocty[i] * delkaRadky / max;

                for (int j = 0; j < pocetSymbolu; j++)
                {
                    Console.Write("#");
                }

                //a odřádkujeme
                Console.WriteLine();
            }
        }
    }
    
}
