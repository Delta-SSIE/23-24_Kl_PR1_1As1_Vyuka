namespace _04_For_11_Zamaskuj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "DESNE TAJNA ZPRAVA";
            int offset = 1;
            int krok = 2;

            string zamaskovano = "";
            Random rnd = new Random();

            //přidám OFFSET náhodných znaků
            for (int i = 0; i < offset; i++)
            {
                zamaskovano += (char)rnd.Next(65, 91);
            }

            //projdu původní text
            for (int i = 0; i < text.Length; i++)
            {
                //přidám jeden původní znak
                zamaskovano += text[i];

                //a pak KROK - 1 náhodných znaků
                for (int j = 0; j < krok - 1; j++)
                {
                    zamaskovano += (char)rnd.Next(65, 91);
                }
            }

            Console.WriteLine(zamaskovano);
        }
    }
}
