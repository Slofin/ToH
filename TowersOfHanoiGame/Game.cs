using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoiGame
{
    class Game
    {
        static void Main(string[] args)
        {
            HanoiGame game = new HanoiGame();
            game.Run();

            Console.WriteLine("完成，請按下任意鍵離開...");
            Console.ReadKey();
        }
    }
}

