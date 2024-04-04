namespace _11_OOP_02_Demo_Kruznice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kruznice k = new Kruznice();
            //k.Polomer = 1;
            k.SetPolomer(1);
            Console.WriteLine($"Obsah kružníce o poloměru {k.GetPolomer()} je {k.Obsah()}");

            try                
            {
                k.SetPolomer(-50);
            }
            catch
            {
                Console.WriteLine("Došlo k chybě při nastavení parametru");
            }
        }
    }
}
