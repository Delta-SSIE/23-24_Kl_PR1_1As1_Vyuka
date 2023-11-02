namespace _03_While_07_Odpocet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chceme odpočet od 10 do 1
            int cislo = 10;
            while (cislo > 0)
            {
                Console.WriteLine(cislo--); //vrať do cw hodnotu proměnné cislo a pak ji sniž o 1
                //Console.WriteLine(--cislo); //sniž hodnotu proměnné cislo o 1 a pak ji vrať do cw 
            }
            Console.WriteLine("Start!");
        }
    }
}
