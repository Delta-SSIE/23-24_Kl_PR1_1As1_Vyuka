namespace _01_Uvod_09_Kolik_bude_za_rok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // načíst jméno
            Console.Write("jak se jmenuješ: ");
            string jmeno = Console.ReadLine();

            // načíst věk
            Console.Write("Kolik ti je: ");
            string vekVstup = Console.ReadLine();

            // převést na číslo 
            int vek = int.Parse(vekVstup);

            // spočítat věk za rok
            int vekZaRok = vek + 1;

            // vypsat podle šablony
            Console.WriteLine($"Za rok bude {jmeno} {vekZaRok} let starý/á.");
        }
    }
}
