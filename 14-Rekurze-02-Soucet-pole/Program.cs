namespace _14_Rekurze_02_Soucet_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = [1, 2, 3, 4, 5];
            Console.WriteLine(SoucetPole(cisla));

        }

        static int SoucetPole(int[] pole, int odkud = 0) 
        {
            if (odkud == pole.Length - 1) //poslední prvek - už nespouštím znovu
                return pole[odkud];

            return pole[odkud] + SoucetPole(pole, odkud + 1); //vezmu první prvek a přidám součet zbytku
        }
    }
}
