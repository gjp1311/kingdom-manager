using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI
{
    public class InitialScreen
    {
        public void Draw(string msg = "")
        {
            //Logo
            string padding = "                ";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($@"{padding}****************************************************************************************");
            Console.WriteLine($@"{padding}* _   ___                 _                  ___  ___                                  *");
            Console.WriteLine($@"{padding}*| | / (_)               | |                 |  \/  |                                  *");
            Console.WriteLine($@"{padding}*| |/ / _ _ __   __ _  __| | ___  _ __ ___   | .  . | __ _ _ __   __ _  __ _  ___ _ __ *");
            Console.WriteLine($@"{padding}*|    \| | '_ \ / _` |/ _` |/ _ \| '_ ` _ \  | |\/| |/ _` | '_ \ / _` |/ _` |/ _ \ '__|*");
            Console.WriteLine($@"{padding}*| |\  \ | | | | (_| | (_| | (_) | | | | | | | |  | | (_| | | | | (_| | (_| |  __/ |   *");
            Console.WriteLine($@"{padding}*\_| \_/_|_| |_|\__, |\__,_|\___/|_| |_| |_| \_|  |_/\__,_|_| |_|\__,_|\__, |\___|_|   *");
            Console.WriteLine($@"{padding}*                __/ |                                                  __/ |          *");
            Console.WriteLine($@"{padding}*               |___/                                                  |___/           *");
            Console.WriteLine($@"{padding}****************************************************************************************");
            Console.ForegroundColor = ConsoleColor.Gray;
            //Menu            
            Console.WriteLine($@"{padding}{padding}{padding}       (N)ew Game");
            Console.WriteLine($@"{padding}{padding}{padding}       (L)oad Game");
            Console.WriteLine($@"{padding}{padding}{padding}       (O)ptions");
            Console.WriteLine($@"{padding}{padding}{padding}       (E)xit");
            //User Response
            Console.WriteLine(); Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($@"{padding}{padding}{padding}       {msg}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($@"{padding}{padding}{padding}       >");
            
            Read();

        }

        public void Read()
        {
            string response = Console.ReadLine();
            if (CheckResponse(response))
            {
                Console.Clear();
                Draw($"You chose {response}");                
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
            var choices = new List<string>() { "n", "l", "o", "e" };
            return choices.Contains(response);
        }
    }
}
