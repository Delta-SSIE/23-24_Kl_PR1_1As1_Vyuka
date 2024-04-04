namespace _11_OOP_04_Konstruktor_kruznice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Kruznice k = new Kruznice(-1);
                Console.WriteLine($"Obsah kružníce o poloměru {k.GetPolomer()} je {k.Obsah()}");
            }
            catch
            {
                Console.WriteLine("Došlo k chybě při nastavení parametru");
            }

        }
    }
}
