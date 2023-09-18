namespace _01_Uvod_02_Konzole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, second World!");
            Console.WriteLine();
            Console.WriteLine("Hello, World!");

            Console.Write("Nazdar");
            Console.Write(" ");
            Console.Write("Matěji");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Jak se jmenuješ:");

            string jmeno; //deklarace proměnné jmeno
            jmeno = Console.ReadLine(); //přiřazení hodnoty do proměnné

            Console.Write("Ať žije ");
            Console.WriteLine(jmeno);

            Console.WriteLine("Jak se jmenuje ten vedle tebe:");
            jmeno = Console.ReadLine(); //zmena hodnoty proměnné

            Console.Write("Proč je tu i ");
            Console.Write(jmeno);

        }
    }
}
