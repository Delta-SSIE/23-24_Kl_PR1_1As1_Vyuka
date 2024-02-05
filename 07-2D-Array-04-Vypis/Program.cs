
namespace _07_2D_Array_04_Vypis
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool[,] mapa =
            {
                {  true, false, false,  true, false, false,  true},
                { false,  true, false,  true, false,  true, false},
                { false, false,  true,  true,  true, false, false},
                { false, false, false,  true, false, false, false},
            };

            VykresliPole(mapa);
            VykresliPole(mapa, '*');
            VykresliPole(mapa, '*', ' ');
            VykresliPole(mapa, falseChar: '*');

        }

        private static void VykresliPole(bool[,] mapa, char trueChar = '#',  char falseChar = '-')
        {
            for (int y = 0; y < mapa.GetLength(0); y++)
            {
                for (int x = 0; x < mapa.GetLength(1); x++)
                {
                    char znak = mapa[y, x] ? trueChar : falseChar;
                    Console.Write(znak);

                }
                Console.WriteLine();
            }
        }
    }
}
