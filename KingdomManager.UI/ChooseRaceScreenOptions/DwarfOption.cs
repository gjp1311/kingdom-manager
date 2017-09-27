using KingdomManager.Core;
using KingdomManager.Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.ChooseRaceScreenOptions
{
    public class DwarfOption : RaceOptions
    {
        public DwarfOption() : base(ERace.Dwarf) {}

        public override bool Match(string option)
        {
            return option == "3";
        }

        public override string OptionText()
        {
            return "(3) - Dwarf - Drunk people who live under earth and like to mine.";
        }
    }
}
