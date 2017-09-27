using KingdomManager.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI
{
    public abstract class BaseScreen
    {
        protected List<IOption> options;
        protected List<string> choices;
        protected Game _game;

        public BaseScreen(Game game)
        {
            _game = game;
            options = new List<IOption>();
        }

        public abstract void Draw(string msg = "");
        public void Read(string msg)
        {
            Console.WriteLine(); Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($@"{msg}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($@">");

            string response = Console.ReadLine();
            if (options != null)
            {
                options.ForEach(q =>
                {
                    if (q.Match(response))
                    {
                        q.Do(_game, this);
                        return;
                    }
                });
            }
            Console.Clear();
            Draw("Wrong Answer!");
        }

        private bool CheckResponse(string response)
        {
            if (choices == null) return false;
            response = response.ToLower();
            return choices.Contains(response);
        }

        protected void DrawOptions()
        {
            if (options != null)
            {
                options.ForEach(q =>
                {
                    Console.WriteLine(q.OptionText());
                });
            }
        }
    }
}
