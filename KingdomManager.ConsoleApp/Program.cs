using KingdomManager.UI;
using System;

namespace KingdomManager.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InitialScreen screen = new InitialScreen();
            screen.Draw();            
            Console.ReadLine();
        }
    }
}