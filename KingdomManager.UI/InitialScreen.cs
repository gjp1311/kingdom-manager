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
        private List<IOption> options;

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
        }

        public void Draw(string msg = "")
        {
            //Logo
            Console.Clear();
            string padding = "";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kingdom Manager");
            //Console.WriteLine($@"{padding}****************************************************************************************");
            //Console.WriteLine($@"{padding}* _   ___                 _                  ___  ___                                  *");
            //Console.WriteLine($@"{padding}*| | / (_)               | |                 |  \/  |                                  *");
            //Console.WriteLine($@"{padding}*| |/ / _ _ __   __ _  __| | ___  _ __ ___   | .  . | __ _ _ __   __ _  __ _  ___ _ __ *");
            //Console.WriteLine($@"{padding}*|    \| | '_ \ / _` |/ _` |/ _ \| '_ ` _ \  | |\/| |/ _` | '_ \ / _` |/ _` |/ _ \ '__|*");
            //Console.WriteLine($@"{padding}*| |\  \ | | | | (_| | (_| | (_) | | | | | | | |  | | (_| | | | | (_| | (_| |  __/ |   *");
            //Console.WriteLine($@"{padding}*\_| \_/_|_| |_|\__, |\__,_|\___/|_| |_| |_| \_|  |_/\__,_|_| |_|\__,_|\__, |\___|_|   *");
            //Console.WriteLine($@"{padding}*                __/ |                                                  __/ |          *");
            //Console.WriteLine($@"{padding}*               |___/                                                  |___/           *");
            //Console.WriteLine($@"{padding}****************************************************************************************");
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

        public void Read()
        {
            string response = Console.ReadLine();
            if (CheckResponse(response))
            {                
                options.ForEach(q =>
                {
                    if (q.Match(response))
                        q.Do();
                });
            }
            else
            {
                Console.Clear();
                Draw("Wrong Answer!");
            }
        }

        private bool CheckResponse(string response)
        {
            response = response.ToLower();
            var choices = new List<string>() { "1", "2", "3", "4" };
            return choices.Contains(response);
        }
    }
}
