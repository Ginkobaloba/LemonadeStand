using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Program
    {
        static void Main(string[] args)
        {
            Introduction introduction = new Introduction();
            Game game = new Game();
            game.RunGame();
        }
    }
}
