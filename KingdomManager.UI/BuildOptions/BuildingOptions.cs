using System;
using System.Collections.Generic;
using System.Text;
using KingdomManager.Core;
using KingdomManager.Domain;
using System.Linq;

namespace KingdomManager.UI.BuildOptions
{
    public abstract class BuildingOptions : IOption
    {

        private Building _building;
        private readonly int _buildCount = 100;

        public BuildingOptions(int id)
        {
            _building = Database.Buildings.Where(q => q.Id == id).FirstOrDefault();
        }

        public void Do(Game game, BaseScreen currentScreen)
        {
            if (_building != null && game.Player.Gold >= _building.Price)
            {
                game.Player.City.Buildings.Add(_building.Build());
                game.Player.Gold -= _building.Price;
                currentScreen = new BuildScreen(game);
                currentScreen.Draw();
            }
            else
            {
                currentScreen = new BuildScreen(game);
                currentScreen.Draw("Not enough gold!");
            }
        }

        public bool Match(string option)
        {
            return option == _building.Id.ToString();
        }

        public string OptionText()
        {
            return $"({_building.Id}){_building.Name}: {_building.Price}gp {_building.Description}";
        }
    }
}
