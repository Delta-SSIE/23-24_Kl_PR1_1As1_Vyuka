namespace _04_For_10_Demaskuj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zamaskovano = "Atkanjdnkak kzsprrtagvvas.";
            int offset = 1;
            int krok = 2;

            string demaskovano = "";

            //začni na prvním "zajímavém" poli, jdi po KROK znacích
            for (int i = offset; i < zamaskovano.Length; i += krok)
            {
                demaskovano += zamaskovano[i];
            }
            //for (int i = 0; i < zamaskovano.Length; i++)
            //{
            //    if (i % krok == offset)
            //        demaskovano += zamaskovano[i];
            //}

            Console.WriteLine(demaskovano);
        }
    }
}
