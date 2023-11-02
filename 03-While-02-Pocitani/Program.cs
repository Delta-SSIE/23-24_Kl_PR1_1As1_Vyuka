namespace _03_While_02_Pocitani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //napočítat po "krok" do 10
            int cislo = 1;
            int krok = 4;
            int maximum = 100;

            while (cislo <= maximum)
            {
                Console.WriteLine(cislo);
                //cislo = cislo + krok;
                cislo += krok; //zkratka za předchozí
            }
        }
    }
}
