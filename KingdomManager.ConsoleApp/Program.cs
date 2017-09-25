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
                InitialScreen screen = new InitialScreen();
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