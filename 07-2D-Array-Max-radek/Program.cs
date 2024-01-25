namespace _07_2D_Array_Max_radek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabulka = {
                {0, 1},
                {7, 6},
                {3, 5}
            };

            //najdi souradnice max prvku
            int maxX = 0;
            int maxY = 0;
            int maxValue = tabulka[maxY, maxX];

            for (int y = 0; y < tabulka.GetLength(0); y++)
            {
                for (int x = 0; x < tabulka.GetLength(1); x++)
                {
                    int value = tabulka[y, x];
                    if (value > maxValue)
                    {
                        maxX = x;
                        maxY = y;
                        maxValue = value;
                    }
                }
            }

            Console.WriteLine($"Největší hodnota {maxValue} se nachází na [{maxX}, {maxY}]");

            int maxSoucetRadku = int.MinValue;
            int indexMaxRadku = 0;

            for (int y = 0; y < tabulka.GetLength(0); y++)
            {
                int soucetRadku = 0;

                for (int x = 0; x < tabulka.GetLength(1); x++)
                {
                    soucetRadku += tabulka[y, x];
                }

                if (soucetRadku > maxSoucetRadku)
                {
                    indexMaxRadku = y;
                    maxSoucetRadku = soucetRadku;
                }
            }

            Console.WriteLine($"Najvětší je řádek s indexem {indexMaxRadku} a jeho součet je {maxSoucetRadku}");
        }
    }
}
