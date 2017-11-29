using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship_WIP
{
    /// <summary>
    /// Temporary class for ConsoleDisplay purposes. Will be changed to influence the RadioButton arrays on the GUI instead
    /// </summary>
    public static class Display
    {

        public static void PrintMyBoard(this Player p, TableLayoutPanel table)
        {
            WaterTile[,] board = p.PlayerBoard;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(0); j++)
                {
                    switch(board[i, j].TileType)
                    {
                        case (TileType.Empty):
                            //Console.Write("|_0_|");
                            
                            break;
                        case (TileType.Destroyer):
                            //Console.ForegroundColor = shipColor;
                            //Console.Write("|_D_|");
                            //Console.ResetColor();
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.AliceBlue;
                            break;
                        case (TileType.Submarine):
                            //Console.ForegroundColor = shipColor;
                            //Console.Write("|_S_|");
                            //Console.ResetColor();
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.Violet;
                            break;
                        case (TileType.Cruiser):
                            //Console.ForegroundColor = shipColor;
                            //Console.Write("|_C_|");
                            //Console.ResetColor();
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.PaleGreen;
                            break;
                        case (TileType.Battleship):
                            //Console.ForegroundColor = shipColor;
                            //Console.Write("|_B_|");
                            //Console.ResetColor();
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.Orange;
                            break;
                        case (TileType.Carrier):
                            //Console.ForegroundColor = shipColor;
                            //Console.Write("|_Y_|");
                            //Console.ResetColor();
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.Goldenrod;
                            break;
                        case (TileType.Hit):
                            //Console.ForegroundColor = ConsoleColor.Red;
                            //Console.Write("|_X_|");
                            //Console.ResetColor();
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.Red;
                            break;
                        case (TileType.Miss):
                            //Console.ForegroundColor = ConsoleColor.Gray;
                            //Console.Write("|_M_|");
                            //Console.ResetColor();
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.GhostWhite;
                            break;
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        public static void PrintEnemyBoard(this Player p, TableLayoutPanel table)
        {
            WaterTile[,] board = p.PlayerBoard;
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(0); j++)
                {
                    switch (board[i, j].TileType)
                    {
                        case (TileType.Hit):
                            //Console.ForegroundColor = ConsoleColor.Red;
                            //Console.Write("|_X_|");
                            //Console.ResetColor();
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.Red;
                            break;
                        case (TileType.Miss):
                            //Console.ForegroundColor = ConsoleColor.Gray;
                            //Console.Write("|_M_|");
                            //Console.ResetColor();
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.GhostWhite;
                            break;
                        default:
                            table.GetControlFromPosition(j, i).BackColor = System.Drawing.Color.Transparent;
                            break;

                    }
                }
            }
        }

        public static void FormHeader(this Form form, Player p)
        {
            form.Text = $"{p.Name}'s Turn";
        }

        public static void PromptShips(Player player)
        {
            string[] tokens = new string[2];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Place {player.Armada[i]}... ");
                tokens = Console.ReadLine().Split();
                player.SetShip(player.Armada[i], int.Parse(tokens[0]), int.Parse(tokens[1]));
            }
        }


    }
}
