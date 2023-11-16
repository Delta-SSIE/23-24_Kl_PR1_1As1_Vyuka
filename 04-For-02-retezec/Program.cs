namespace _04_For_02_retezec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string veta = "Kdy už bude konec?";
            Console.WriteLine(veta.Length);
            Console.WriteLine(veta[0]); //prvni znak

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(veta[veta.Length - 1]); //posledni znak - první byl [0]

            for (int i = 0; i < veta.Length; i++)
            {
                char znak = veta[i];
                if (znak != ' ')
                    Console.Write(znak);
            }
            Console.WriteLine();


            for (int i = veta.Length - 1; i >= 0; i--)
            {
                Console.Write(veta[i]);
            }
            Console.WriteLine();
        }
    }
}
