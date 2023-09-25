namespace _01_Uvod_07_Prumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vyzveme uživatele
            Console.WriteLine("Zadej dvě čísla, já spočítám průměr:");

            //načteme první číslo (řetězec)
            string vstup1 = Console.ReadLine();

            //načteme druhé číslo (řetězec)
            string vstup2 = Console.ReadLine();

            //převedeme oba vstupy na číslo
            double cislo1 = double.Parse(vstup1);
            double cislo2 = double.Parse(vstup2);

            //vypočítáme průměr
            double prumer = (cislo1 + cislo2) / 2;

            //vypíšme výsledek
            Console.WriteLine("Průměr je " + prumer);
        }
    }
}
