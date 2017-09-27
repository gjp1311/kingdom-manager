using KingdomManager.Core;
using KingdomManager.UI.ChooseRaceScreenOptions;

using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI
{
    public class NewGameScreen : BaseScreen
    {
        
        public NewGameScreen(Game game) : base(game)
        {            
            options.Add(new HumanOption());
            options.Add(new ElfOption());
            options.Add(new DwarfOption());
            options.Add(new OrcOption());
            options.Add(new NecromancerOption());            
        }

        public override void Draw(string msg = "")
        {
            Console.Clear();
            //Options
            Console.WriteLine("Choose your Civilization :");
            DrawOptions();
            //User Response          
            Read(msg);
        }


    }
}
