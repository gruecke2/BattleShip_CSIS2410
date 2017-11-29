using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_WIP
{
    public class WaterTile
    {
        public TileType TileType { get; set; }
        public bool HasShip { get; set; }
        public bool BeenShot { get; set; }

        /// <summary>
        /// Returns true if a WaterTile isn't empty
        /// </summary>
        /// <returns></returns>
        public bool ContainsShip()
        {
            if (this.TileType != TileType.Empty)
            {
                return true;
            }
            return false;
        }
    }
}
