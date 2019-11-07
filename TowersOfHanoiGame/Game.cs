using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoiGame
{
    class Game
    {
        public static void Main(string[] args)
        {
            HanoiGame game = new HanoiGame();

            game.Setup();
            game.Play();

            Console.ReadKey();
        }
    }
}

