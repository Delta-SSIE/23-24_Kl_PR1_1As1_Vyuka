namespace _04_For_16_Faktorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (ulong num = 0; num < 30; num++)
            {

                ulong fac;

                if (num == 0)
                    fac = 1;
                else
                {
                    fac = 1;
                    for (ulong i = 1; i <= num; i++)
                    {
                        checked 
                        { 
                            fac *= i;
                        }
                    }
                }

                Console.WriteLine($"{num}! = {fac}");
            }
        }
    }
}
