using KingdomManager.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI
{
    public interface IOption
    {
        bool Match(string option);
        void Do(Game game);
    }    
}
