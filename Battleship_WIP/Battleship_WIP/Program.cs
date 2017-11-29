using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship_WIP
{
    static class Program
    {
        public static void Main()
        {
            Game game = new Game();
            Player p1 = game.P1;
            Player p2 = game.P2;

            int counter = 0;
            foreach(Ship el in p1.Armada)
            {
                p1.SetShip(el, counter++, 0);
            }

            p1.IsTurn = true;
            p2.IsTurn = false;


            TestForm window = new TestForm(game);

            
            Application.Run(window);
        }
    }
}
