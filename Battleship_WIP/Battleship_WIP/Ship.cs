using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_WIP
{
    public class Ship
    {
        public TileType VesselType { get; }
        private bool IsSunk { get; set; }
        public bool HorizontalShip { get; set; }
        private Player OwnedBy { get; }
        public int Health { get; set; }
        public List<WaterTile> OccupiedSlots { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tType"></param>
        /// <param name="owner"></param>
        public Ship(TileType tType, Player owner)
        {
            VesselType = tType;
            OwnedBy = owner;
            Health = (int)tType;

            //Current bad fix for Sub health calculation
            if (tType == TileType.Submarine)
            {
                Health += 2;
            }

            IsSunk = false;
        }

        /// <summary>
        /// Returns the VesselType
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return VesselType.ToString();
        }

        /// <summary>
        /// Using a bool to represent a vertical vs. horizontal ship
        /// </summary>
        public void FlipShip()
        {
            HorizontalShip = !HorizontalShip;
        }
    }
    /// <summary>
    /// Enum Vessel has names of ship types and their coordinate # values
    /// </summary>
    public enum TileType {Empty = 0, Destroyer = 2, Submarine = 1, Cruiser = 3, Battleship = 4, Carrier = 5, Hit = 7, Miss = 8 };
}
