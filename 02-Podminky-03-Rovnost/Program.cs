namespace _02_Podminky_03_Rovnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //načíst číslo
            Console.WriteLine("Zadej číslo");
            string vstup = Console.ReadLine();
            double cislo = double.Parse(vstup); //jedno rovnítko je přiřazení - příkaz "ulož"

            if (cislo < 0)
                Console.WriteLine("číslo je záporné");
            else if (cislo == 0) //dvě rovnítka jsou porovnání, musí zde být
                Console.WriteLine("číslo je nula");
            else
                Console.WriteLine("číslo je kladné");


        }
    }
}
