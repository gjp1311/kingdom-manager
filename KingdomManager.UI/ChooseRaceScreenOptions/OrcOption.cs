using KingdomManager.Core;
using KingdomManager.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.ChooseRaceScreenOptions
{
    public class OrcOption : RaceOptions
    {
        public OrcOption() : base(ERace.Orcs) { }
        public override bool Match(string option)
        {
            return option == "4";
        }

        public override string OptionText()
        {
            return "(4) - Orcs - Brutal and tribal people.";
        }
    }
}
