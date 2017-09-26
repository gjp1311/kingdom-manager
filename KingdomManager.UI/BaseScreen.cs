using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomManager.UI
{
    public abstract class BaseScreen
    {
        protected List<IOption> options;
        protected List<string> choices;
        public abstract void Draw(string msg = "");
        public void Read()
        {
            string response = Console.ReadLine();
            if (CheckResponse(response) && options != null && options.Count > 0)
            {
                options.ForEach(q =>
                {
                    if (q.Match(response))
                        q.Do();
                });
            }
            else
            {
                Console.Clear();
                Draw("Wrong Answer!");
            }
        }

        private bool CheckResponse(string response)
        {
            if (choices == null) return false;
            response = response.ToLower();
            return choices.Contains(response);
        }
    }
}
