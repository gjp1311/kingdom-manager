using KingdomManager.Core;
using KingdomManager.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.ChooseRaceScreenOptions
{
    public class ElfOption : RaceOptions
    {
        public ElfOption() : base(ERace.Elf) { }

        public override bool Match(string option)
        {
            return option == "2";
        }

        public override string OptionText()
        {
            return "(2) - Elf - Immortal beings with magic affinity";
        }
    }
}
