using System;
using System.Collections.Generic;
using System.Text;
using KingdomManager.Core;
using KingdomManager.Domain;

namespace KingdomManager.UI.ChooseRaceScreenOptions
{
    public abstract class RaceOptions : IOption
    {
        private ERace _race;

        public RaceOptions(ERace race)
        {
            _race = race;
        }

        public void Do(Game game, BaseScreen currentScreen)
        {
            game.Player.Race = _race;
            currentScreen = new GameScreen(game);
            currentScreen.Draw();
        }

        public abstract bool Match(string option);

        public abstract string OptionText();
    }
}
