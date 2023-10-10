namespace _05_Podminky_08_Logicke_operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mamHlad = true;
            bool jeVenkuHezky = true;

            if (mamHlad && jeVenkuHezky) //a zároveň
                Console.WriteLine("jde se do restaurace"); 
            else
                Console.WriteLine("nikam se nejde");


            bool jeVenkuOsklive = !jeVenkuHezky; //negace 

            if (mamHlad || jeVenkuHezky) //nebo
                Console.WriteLine("Nezůstanu tady");
            else
                Console.WriteLine("Budu doma");


            bool mamDestnik = true;

            if (mamHlad && (jeVenkuHezky || mamDestnik))
                Console.WriteLine("jde se jíst ven");
        }
    }
}
