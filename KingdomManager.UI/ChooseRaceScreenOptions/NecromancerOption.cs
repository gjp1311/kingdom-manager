using KingdomManager.Core;
using KingdomManager.Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.ChooseRaceScreenOptions
{
    public class NecromancerOption : RaceOptions
    {
        public NecromancerOption() : base(ERace.Necromancers) { }
        public override bool Match(string option)
        {
            return option == "5";
        }

        public override string OptionText()
        {
            return "(5) - Necros - Use undead as slaves and soldiers";
        }
    }
}
