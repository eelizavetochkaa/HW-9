using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface IGame
{
    void Play();
}

namespace ДЗ_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team russia = new Team("Россия");
            Team france = new Team("Франция");
            Team china = new Team("Китай");
            Team kazakhstan = new Team("Казахстан");

            IGame[] games = new IGame[]
            {
            new BeachGame(),
            new MousetrapGame(),
            new SeaGame(),
            new FishingGame(),
            new PostmenGame(),
            new HillGame()
            };

            foreach (var game in games)
            {
                russia.PlayGame(game);
                france.PlayGame(game);
                china.PlayGame(game);
                kazakhstan.PlayGame(game);
            }

            Console.ReadKey();
        }
    }
}
