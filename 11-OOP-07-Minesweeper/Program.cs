namespace _11_OOP_07_Minesweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(5, 5, 5);
            game.GameLoop();
        }
    }
}
