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
            options.Add(new NewGameOption());
            options.Add(new LoadGameOption());
            options.Add(new OptionsOption());
            options.Add(new ExitOption());
        }

        public override void Draw(string msg = "")
        {
            //Logo
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kingdom Manager");
            Console.ForegroundColor = ConsoleColor.Gray;
            //Menu            
            DrawOptions();
            //User Response
            Read(msg);

        }
    }
}
