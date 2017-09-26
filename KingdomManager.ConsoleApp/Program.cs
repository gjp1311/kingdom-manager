using KingdomManager.Core;
using KingdomManager.UI;
using System;

namespace KingdomManager.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Game game = new Game();
                InitialScreen screen = new InitialScreen(game);
                screen.Draw();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}