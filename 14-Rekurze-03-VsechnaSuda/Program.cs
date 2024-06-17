namespace _14_Rekurze_03_VsechnaSuda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = [2, 4, 5, 8, 10];
            Console.WriteLine(JsouVsechnaSuda(cisla, 0));
        }

        static bool JsouVsechnaSuda(int[] cisla, int odkud)
        {
            if (odkud == cisla.Length) //došel jsem na konec - už se liché neobjeví
                return true;

            if (cisla[odkud] % 2 == 1) //našel jsem liché, to nejde
                return false;

            return JsouVsechnaSuda(cisla, odkud + 1);
        }
    }
}
