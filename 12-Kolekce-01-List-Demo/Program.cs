namespace _12_Kolekce_01_List_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 1, 2, 3, 7, 8, 56, -4, 12, 8 };

            int[] suda = VyberSuda(cisla);

            Console.WriteLine(string.Join(',', suda));


           
        }

        static int[] VyberSuda(int[] cisla)
        {
            List<int> suda = new List<int>();
            foreach (int cislo in cisla)
            {
                if (cislo % 2 == 0)
                    suda.Add(cislo);
            }

            //Console.WriteLine($"Celkem jsem našel {suda.Count} sudých čísel");

            //for (int i = 0; i < suda.Count; i++) //pozor, není Length, je Count
            //{
            //    Console.WriteLine(suda[i]); //funguje jako pole
            //}

            return suda.ToArray();
        }


    }
}
