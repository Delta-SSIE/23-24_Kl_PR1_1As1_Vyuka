namespace _01_Uvod_05_Nacitani_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej celé číslo:");
            string vstup = Console.ReadLine();

            Console.WriteLine("Zadal jsi " + vstup);

            int cislo = int.Parse(vstup); //dovnitř jde řetězec, ven jde int
                            //pro neplatné řetězce může spadnout

            int zvetseno = cislo + 1;

            Console.WriteLine("O jedna víc je " + zvetseno);


            Console.WriteLine("Zadej desetinné číslo:");
            vstup = Console.ReadLine();

            double desetinne = double.Parse(vstup);            
            Console.WriteLine("Zadal jsi " + vstup);
            double zaokrouhleno = Math.Round(desetinne, 3); //co zaokrouhlit, na kolik mist
            Console.WriteLine("Na tři desetinná: " + zaokrouhleno);


        }
    }
}
