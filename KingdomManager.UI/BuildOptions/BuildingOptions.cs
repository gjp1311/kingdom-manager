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
            int price = _building.Price * _buildCount;
            if (game.Player.Gold >= price)
            {
                var times = Enumerable.Range(0, _buildCount).ToList();
                times.ForEach(q => { game.Player.City.Buildings.Add(_building.Build()); });
                game.Player.Gold -= price;
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
            return $"({_building.Id}) {_buildCount} {_building.Name}s - {_building.Price * _buildCount} gp - {_building.Description}";
        }
    }
}
