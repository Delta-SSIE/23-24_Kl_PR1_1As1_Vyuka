using System.Diagnostics;

namespace _04_For_13_Delitele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 21154207;
            //int num = 33554432;
            int num = 100;
            int count = 0;

            ////brute-force: projít všechna menší čísla a zjistit, zda to není dělitel
            //for (int i = 1; i <= num; i++)
            //{
            //    if (num % i == 0)//když je dělitelné 
            //    {
            //        count++;
            //        Console.WriteLine($"{count}: {i}");//vypíšu i

            //    }
            //}

            ////rychlejší - jen do poloviny
            //int limit = num / 2;
            //for (int i = 1; i <= limit; i++)
            //{
            //    if (num % i == 0)//když je dělitelné 
            //    {
            //        count++;
            //    }

            //}
            //count++;
            //Console.WriteLine($"{count}: {num}");//vypíšu i

            //ještě rychlejší - do odmocniny
            double limit = Math.Sqrt(num);
            for (int i = 1; i <= limit; i++)
            {
                if (num % i == 0)//když je dělitelné 
                {
                    count++;
                    Console.WriteLine($"{count}: {i}");//vypíšu dělitele i
                    if (i != limit) //když to není odmocina z pův. čísla
                    {
                        count++;
                        Console.WriteLine($"{count}: {num / i}");//vypíšu také dělitele num / i
                    }
                }

            }

        }
    }
}
