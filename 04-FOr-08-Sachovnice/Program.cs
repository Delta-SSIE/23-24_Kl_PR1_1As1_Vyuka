namespace _04_FOr_08_Sachovnice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pozice = "D3";

            int radek = pozice[1] - '0';
            int sloupec = pozice[0] - 'A' + 1;

            //nakreslit šachovnici
            int max = 8;
            bool tmava = false;

            Console.Write("  ");
            for (int i = 0; i < max; i++)
            {
                Console.Write( (char)('A' + i) + " ");
            }
            Console.WriteLine();

            for (int y = 8; y > 0; y--)
            {
                Console.Write($"{y} ");

                for (int x = 1; x <= max; x++)
                {
                    bool stojiTuFigura = y == radek && x == sloupec;
                    //bool ohrozenePole = y == radek || x == sloupec; //pro vez
                    
                    int rozdilRadek = Math.Abs(y - radek);
                    int rozdilSloupec = Math.Abs(x - sloupec);

                    //bool ohrozenePole = rozdilRadek < 2 && rozdilSloupec < 2; //kral
                    //bool ohrozenePole = rozdilRadek == rozdilSloupec; //strelec
                    bool ohrozenePole = (y == radek || x == sloupec) || rozdilRadek == rozdilSloupec; //dama
                    //bool ohrozenePole = (rozdilRadek == 2 && rozdilSloupec == 1) || (rozdilRadek == 1 && rozdilSloupec == 2); //jezdec


                    if (!tmava)
                    {
                        if (stojiTuFigura)
                            Console.BackgroundColor = ConsoleColor.Yellow;
                        else if (ohrozenePole)
                            Console.BackgroundColor = ConsoleColor.Magenta;
                        else
                            Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        if (stojiTuFigura)
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                        else if (ohrozenePole)
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    }

                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Black;


                    tmava = !tmava;
                }
                tmava = !tmava;

                Console.WriteLine($" {y}");
            }
            Console.Write("  ");
            for (int i = 0; i < max; i++)
            {
                Console.Write((char)('A' + i) + " ");
            }
            Console.WriteLine();
        }
    }
}
