using KingdomManager.Core;
using KingdomManager.UI.InitialScreenOptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI
{
    public class NewGameScreen : BaseScreen
    {
        private IOption humanOption;
        private IOption elfOption;
        private IOption dwarfOption;
        private IOption orcOption;
        private IOption necromancerOption;

        public NewGameScreen(Game game) : base(game)
        {
            options = new List<IOption>();
            options.Add(new HumanOption());
            options.Add(new HumanOption());
            options.Add(new HumanOption());
            options.Add(new HumanOption());
            options.Add(new HumanOption());
            choices = new List<string>() { "1", "2", "3", "4" ,"5"};
        }

        public override void Draw(string msg = "")
        {
            Console.Clear();
            //Options
            Console.WriteLine("Choose your Civilization :");
            Console.WriteLine("(1) - Human - Common people with nothing unusual");
            Console.WriteLine("(2) - Elf - Immortal beings with magic affinity");
            Console.WriteLine("(3) - Dwarf - Drunk people who live under earth and like to mine.");
            Console.WriteLine("(4) - Orcs - Brutal and tribal people.");
            Console.WriteLine("(5) - Necros - Use undead as slaves and soldiers");
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
