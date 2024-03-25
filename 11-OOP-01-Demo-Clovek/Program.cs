namespace _11_OOP_01_Demo_Clovek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek karel = new Clovek();
            karel.Jmeno = "Karel";
            karel.Prijmeni = "Novotný";
            karel.Vek = 25;

            Console.WriteLine($"Křestní jméno je {karel.Jmeno}");

            Clovek lojza = new Clovek();
            lojza.Jmeno = "Alois";
            lojza.Prijmeni = "Zelenka";
            lojza.Vek = 67;

            PopisOsoby(karel);
            PopisOsoby(lojza);

            Clovek nekdo = NactiOsobu();
            PopisOsoby(nekdo);
        }

        static void PopisOsoby(Clovek osoba)
        {
            Console.WriteLine($"Jmenuji se {osoba.Jmeno} {osoba.Prijmeni} a je mi {osoba.Vek} let." );
        }

        static Clovek NactiOsobu()
        {
            Clovek osoba = new Clovek();

            Console.Write("Zadej jméno: ");
            osoba.Jmeno = Console.ReadLine();

            Console.Write("Zadej příjmení: ");
            osoba.Prijmeni = Console.ReadLine();

            Console.Write("Zadej věk: ");
            osoba.Vek = int.Parse(Console.ReadLine());

            return osoba;
        }
    }
}
