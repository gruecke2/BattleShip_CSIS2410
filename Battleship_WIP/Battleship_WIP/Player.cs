using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_WIP
{
    public class Player
    {
        public bool IsTurn { get; set; }
        public List<Ship> Armada = new List<Ship>();
        private int TurnNumber = 1;
        public string Name { get; set; }
        public WaterTile[,] PlayerBoard = new WaterTile[10,10];
        public short Hits = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        public Player()
        {
            Armada.Add(new Ship(TileType.Destroyer, this));
            Armada.Add(new Ship(TileType.Submarine, this));
            Armada.Add(new Ship(TileType.Cruiser, this));
            Armada.Add(new Ship(TileType.Battleship, this));
            Armada.Add(new Ship(TileType.Carrier, this));
            SetUpNewBoard();
        }

        /// <summary>
        /// Sets up an empty WaterTiel[,] to represent the player's board.
        /// </summary>
        public void SetUpNewBoard()
        {
            for(int y = 0; y < 10; y++)
            {
                for(int x = 0; x < 10; x++)
                {
                    PlayerBoard[x, y] = new WaterTile()
                    {
                        TileType = TileType.Empty
                    };
                }
            }
        }

        /// <summary>
        /// Checks for hits at coordinates (x, y)
        /// </summary>
        /// <param name="x">Column number (starts at 0)</param>
        /// <param name="y">Row number (starts at 0) </param>
        public void CheckHit(int x, int y)
        {
            Ship ship = WhichShip(PlayerBoard[x, y]);
            if (PlayerBoard[x, y].BeenShot == false)
            {
                PlayerBoard[x, y].BeenShot = true;
                if (PlayerBoard[x, y].HasShip)
                {
                    ship.Health--;
                    Hits++;
                    PlayerBoard[x, y].TileType = TileType.Hit;
                    if (ship.Health == 0)
                    {
                        Console.Write($"You sunk {this.Name}'s {ship.ToString()}\n");
                        Armada.Remove(ship);
                    }
                }
                else
                {
                    PlayerBoard[x, y].TileType = TileType.Miss;
                }
            }
            TurnNumber++;   
        }

        /// <summary>
        /// Checks if there is already a ship where new ship wants to be placed.
        /// </summary>
        /// <param name="s">New ship to place</param>
        /// <param name="x">Origin column of new ship</param>
        /// <param name="y">Origin row of new ship</param>
        /// <returns></returns>
        private bool ClearPlacement(Ship s, int x, int y)
        {
            if (s.HorizontalShip)
            {
                for (int i = 0; i < s.Health; i++)
                {
                    if (PlayerBoard[y, x + i].HasShip) return false;
                }
            }
            else
            {
                for (int i = 0; i < s.Health; i++)
                {
                    if (PlayerBoard[i + y, x].HasShip) return false; 
                }
            }

            return true;
        }

        /// <summary>
        /// Sets a new ship on the PlayerBoard
        /// </summary>
        /// <param name="s">Ship to place</param>
        /// <param name="x">Column</param>
        /// <param name="y">Row</param>
        public void SetShip(Ship s, int x, int y)
        {
            if (s.HorizontalShip)
            {
                try
                {
                    if (ClearPlacement(s, x, y))
                    {
                        for (int i = 0; i < s.Health; i++)
                        {

                            PlayerBoard[y, x + i].HasShip = true;
                            PlayerBoard[y, x + i].TileType = s.VesselType;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Ship cannot overlap another ship!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Must put ship in bounds" + e.Message);
                    
                    Display.PromptShips(this);
                }
            }
            else
            {
                try
                {
                    if (ClearPlacement(s, x, y))
                    {
                        for (int i = 0; i < s.Health; i++)
                        {
                            PlayerBoard[i + y, x].HasShip = true;
                            PlayerBoard[i + y, x].TileType = s.VesselType;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ship cannot overlap another ship!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Must put ship in bounds" + e.Message);
                }
            }
        }
        
        /// <summary>
        /// Returns which ship occupies a entered WaterTile
        /// </summary>
        /// <param name="tile"></param>
        /// <returns></returns>
        public Ship WhichShip(WaterTile tile)
        {
             return Armada.Find(x => x.VesselType.Equals(tile.TileType));
        }

    }
}
