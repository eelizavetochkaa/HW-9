using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_9
{
    public class Team
    {
        private string name;

        public Team(string name)
        {
            this.name = name;
        }

        public void PlayGame(IGame game)
        {
            Console.Write($"Команда {name} играет в ");
            game.Play();
        }

    }
}
