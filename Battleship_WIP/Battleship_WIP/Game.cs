using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_WIP
{
    public class Game
    {
        public bool gameOver;
        public int turns = 0;
        public Player P1 { get; set; }
        public Player P2 { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Game()
        {
            P1 = new Player();
            P2 = new Player();
            P1.Name = "Player 1";
            P2.Name = "Player 2";
            System.Console.Title = "B A T T L E   S H I P!";
            
        }

        /// <summary>
        /// Checks if the total number of hits equals total ship slot numbers.
        /// </summary>
        /// <returns></returns>
        public void IsGameOver()
        {
            if (P1.Hits == 17 || P2.Hits == 17)
            {
                gameOver = true;
            }
            gameOver = false;
        }

        /// <summary>
        /// Swiches player turns
        /// </summary>
        public void SwitchTurn()
        {
            P1.IsTurn = !P1.IsTurn;
            P2.IsTurn = !P2.IsTurn;
        }

        

    }
}
