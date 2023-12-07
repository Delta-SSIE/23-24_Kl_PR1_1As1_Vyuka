namespace _04_For_14_Je_prvocislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 21154207;

            bool jePrvocislo = true;

            double limit = Math.Sqrt(num);
            for (int i = 2; i < limit; i++)
            {
                if (num % i == 0) //když jsem našel dělitele
                {
                    jePrvocislo = false;
                    break;
                }
            }

            Console.WriteLine($"{num} {(jePrvocislo ? "je" : "není")} prvočíslo");

            //if (jePrvocislo)
            //    Console.WriteLine($"{num} je prvočíslo");
            //else
            //    Console.WriteLine($"{num} není prvočíslo");

        }
    }
}
