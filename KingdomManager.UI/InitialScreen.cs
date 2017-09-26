using KingdomManager.UI.InitialScreenOptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI
{
    public class InitialScreen : BaseScreen
    {


        private IOption newGameOption;
        private IOption loadGameOption;
        private IOption optionsOption;
        private IOption exitOption;


        public InitialScreen()
        {
            newGameOption = new NewGameOption();
            loadGameOption = new LoadGameOption();
            optionsOption = new OptionsOption();
            exitOption = new ExitOption();
            options = new List<IOption>();
            options.Add(newGameOption);
            options.Add(loadGameOption);
            options.Add(optionsOption);
            options.Add(exitOption);
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
            Console.WriteLine(); Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($@"{msg}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($@">");

            Read();

        }
    }
}
