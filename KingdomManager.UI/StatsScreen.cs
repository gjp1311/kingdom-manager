using System;
using System.Linq;
using KingdomManager.Core;

namespace KingdomManager.UI
{
    public class StatsScreen : BaseScreen
    {
        public StatsScreen(Game game) : base(game)
        {
            options.Add(new BackOption<GameScreen>());
        }

        public override void Draw(string msg = "")
        {
            Console.Clear();
            _game.PrintHeader();
            Console.WriteLine("Current Buildings :");
            Database.Buildings.ForEach(q =>
            {
                var count = _game.Player.City.Buildings.Count(b => b.Id == q.Id);
                if (count > 0)
                    Console.WriteLine($"{q.Name} - {count}");
            });
            Console.WriteLine();
            DrawOptions();
            Read(msg);
        }
    }
}
