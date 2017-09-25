using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI
{
    public interface BaseScreen
    {
        void Draw(string msg = "");
        void Read();
    }
}
