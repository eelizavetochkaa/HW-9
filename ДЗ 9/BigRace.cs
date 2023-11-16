using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_9
{
    public class BigRace
    {
       private List<IGame> games;

        public BigRace()
        {
            games = new List<IGame>();
        }

        public void AddGame(IGame game)
        {
            games.Add(game);
        }

        public void PlayGames()
        {
            foreach (var game in games)
            {
                game.Play();
            }
        }

    }
}
