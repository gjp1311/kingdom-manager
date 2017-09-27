using KingdomManager.Core;
using KingdomManager.UI.InitialScreenOptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI
{
    public class InitialScreen : BaseScreen
    {
        public InitialScreen(Game game) : base(game)
        {            
            options = new List<IOption>();
            options.Add(new NewGameOption());
            options.Add(new LoadGameOption());
            options.Add(new OptionsOption());
            options.Add(new ExitOption());
            choices = new List<string>() { "1", "2", "3", "4" };
        }

        public override void Draw(string msg = "")
        {
            //Logo
            Console.Clear();            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kingdom Manager");            
            Console.ForegroundColor = ConsoleColor.Gray;
            //Menu            
            Console.WriteLine($@"(1)New Game");
            Console.WriteLine($@"(2)Load Game");
            Console.WriteLine($@"(3)Options");
            Console.WriteLine($@"(4)Exit");
            //User Response
            Read(msg);

        }
    }
}
