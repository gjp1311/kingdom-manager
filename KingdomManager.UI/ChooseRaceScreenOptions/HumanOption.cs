using KingdomManager.Core;
using KingdomManager.Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.ChooseRaceScreenOptions
{
    public class HumanOption : RaceOptions
    {
        public HumanOption() : base(ERace.Human) { }

        public override bool Match(string option)
        {
            return option == "1";
        }

        public override string OptionText()
        {
            return "(1) - Human - Common people with nothing unusual";
        }
    }
}
