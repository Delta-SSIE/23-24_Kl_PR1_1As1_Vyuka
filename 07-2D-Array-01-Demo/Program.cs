namespace _07_2D_Array_01_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabulka = new int[2, 3]; //pole 2 x 3

            //Console.WriteLine(tabulka.GetLength(0));
            //Console.WriteLine(tabulka.GetLength(1));

            tabulka[0, 0] = 1;
            tabulka[1, 0] = 2;

            tabulka[0, 1] = 5;
            tabulka[1, 1] = 4;

            tabulka[0, 2] = 3;
            tabulka[1, 2] = 7;

            Console.WriteLine(tabulka[0, 2]);
            Console.WriteLine();

            //Console.WriteLine(tabulka[0, 3]); //chyba - mimo hranice
            //Console.WriteLine(tabulka[2, 0]); //chyba - mimo hranice

            for (int y = 0; y < tabulka.GetLength(1); y++)
            {
                for (int x = 0; x < tabulka.GetLength(0); x++)
                {
                    Console.Write(tabulka[x, y] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int y = 0; y < tabulka.GetLength(0); y++)
            {
                for (int x = 0; x < tabulka.GetLength(1); x++)
                {
                    Console.Write(tabulka[y, x] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
