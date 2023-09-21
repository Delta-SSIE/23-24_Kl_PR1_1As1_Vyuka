namespace _01_Uvod_06_Znak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej písmeno");
            char znak1 = Console.ReadKey().KeyChar;

            Console.WriteLine(); 
            Console.WriteLine("Zadej další písmeno");
            char znak2 = Console.ReadKey().KeyChar;

            Console.WriteLine();
            Console.WriteLine("Zadej další písmeno");
            char znak3 = Console.ReadKey().KeyChar;

            char znak4 = 'f'; //jeden znak zapisujeme do jednoduchých uvozovek

            Console.WriteLine("První písmeno bylo " + znak1);
            //string dohromady = znak1 + znak2 + znak3; //nefunguje - sčítání znaků je převede na čísla (int) a pak nelze dát do řetězce

            string dohromady = "" + znak1 + znak2 + znak3 + znak4; //funguje - přidáváme písmena za prázdný řetězec

            Console.WriteLine("Dohromady jsi napsal: '" + dohromady + "'"); //vypsáno v uvozovkách

            Console.WriteLine($"Dohromady jsi napsal: '{dohromady}'."); //interpolace řetězce


        }
    }
}
