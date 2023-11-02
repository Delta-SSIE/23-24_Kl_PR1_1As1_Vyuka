namespace _03_While_05_Nacteni_slova_do_mezery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš slovo a za ním mezeru");

            string slovo = "";
            char znak = Console.ReadKey().KeyChar;
            
            while (znak != ' ')
            {
                slovo += znak;
                znak = Console.ReadKey().KeyChar;
            }

            Console.WriteLine();
            Console.WriteLine($"Zadal jsi \"{slovo}\", má {slovo.Length} znaků.");
        }
    }
}
