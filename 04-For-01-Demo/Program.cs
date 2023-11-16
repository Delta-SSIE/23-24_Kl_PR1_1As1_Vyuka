namespace _04_For_01_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            // i zůstane jako aktivní proměnná i po skončení cyklu

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // napočítat po 10 do 100
            for (int i = 0; i < 101; i += 10)
            {
                Console.WriteLine(i);
            }

            // od 100 do nuly
            for (int i = 100; i >= 0; i -= 10)
            {
                Console.WriteLine(i);
            }



        }
    }
}
