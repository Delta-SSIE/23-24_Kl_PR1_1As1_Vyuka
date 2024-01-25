namespace _06_Metody_050_Array__ref_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = [1, 2, 3, 4];
            Console.WriteLine(SectiPole(cisla));
            VypisPole(cisla);
            ZmenPole(cisla);
            VypisPole(cisla);


            int a = 10;
            ZmenCislo(a);
            Console.WriteLine(a);


            
        }

        static int SectiPole(int[] pole)
        {
            int soucet = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                soucet += pole[i];
            }
            return soucet;
        }
        static void VypisPole(int[] pole)
        {
            Console.WriteLine(string.Join(", ", pole));
        }
        static void ZmenCislo(int cislo)
        {
            cislo = cislo + 1;
        }
        static void ZmenPole(int[] pole)
        {
            pole[0] = pole[0] + 1;
        }
    }
}
