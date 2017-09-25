﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI
{
    public class NewGameScreen : BaseScreen
    {
        public void Draw(string msg = "")
        {
            Console.Clear();
            Console.WriteLine("Choose your Civilization :");
            Console.WriteLine("(1) - Human - Common people with nothing unusual");
            Console.WriteLine("(2) - Elf - Immortal beings with magic affinity");
            Console.WriteLine("(3) - Dwarf - Drunk people who live under earth and like to mine.");
            Console.WriteLine("(4) - Orcs - Brutal and tribal people.");
            Console.WriteLine("(5) - Necros - Use undead as slaves and soldiers");
        }

        public void Read()
        {
            throw new NotImplementedException();
        }
    }
}
