namespace _06_Metody_030_ReadInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kolik = ReadInt("Kolik lidí přijde");            
            Console.WriteLine(kolik);
        }

        static int ReadInt(string message)
        {
            Console.WriteLine(message);
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Neplatné zadání");
                Console.WriteLine(message);
            }
            return result;
        }
    }
}
