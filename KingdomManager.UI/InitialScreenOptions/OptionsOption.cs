using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI.InitialScreenOptions
{
    public class OptionsOption : IOption
    {
        public void Do()
        {
            throw new NotImplementedException();
        }

        public bool Match(string option)
        {
            return option == "3";
        }
    }
}
