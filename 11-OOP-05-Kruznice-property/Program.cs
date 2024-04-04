namespace _11_OOP_05_Kruznice_property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Kruznice k = new Kruznice(1);
                Console.WriteLine($"Obsah kružníce o poloměru {k.Polomer} je {k.Obsah()}");
                k.Polomer = -1;
                Console.WriteLine($"Obsah kružníce o poloměru {k.Polomer} je {k.Obsah()}");
            }
            catch
            {
                Console.WriteLine("Došlo k chybě při nastavení parametru");
            }
        }
    }
}
