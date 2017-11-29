using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship_WIP
{
    public partial class TestForm : Form
    {
        private int row;
        private int column;
        private Game G;
        private RadioButton[,] leftButtons = new RadioButton[10, 10];
        private RadioButton[,] rightButtons = new RadioButton[10, 10];
        private RadioButton SelectedBtn;


        public TestForm(Game g)
        {
            G = g;
            InitializeComponent();
            AddLeftButtons();
            AddRighttButtons();
            this.FormHeader(G.P1);
            G.P1.PrintMyBoard(LeftBoard);
            LeftBoard.Enabled = false;
        }

        private void LeftGrid_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            row = this.LeftBoard.GetRow(btn);
            column = this.LeftBoard.GetColumn(btn);
            SelectedBtn = btn;

            Console.Write($"LeftGrid  Row: {row}  Column: {column}\n");
        }

        private void RightGrid_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            row = this.RightBoard.GetRow(btn);
            column = this.RightBoard.GetColumn(btn);
            SelectedBtn = btn;

            Console.Write($"RightGrid  Row: {row}  Column: {column}\n");
        }

        private void FireButton_Click(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            TakeATurn();
        }

        private void TakeATurn()
        {
            if (SelectedBtn != null)
            {
                if (G.P1.IsTurn)
                {
                    this.FormHeader(G.P1);
                    LeftBoard.Enabled = false;
                    G.P1.PrintMyBoard(LeftBoard);
                    G.P2.PrintEnemyBoard(RightBoard);
                    G.P2.CheckHit(row, column);
                    // selectedTile.Image = Display.UpdateImage(selectedTile);     or a static extension method
                    //  SelectedBtn.BackColor = System.Drawing.Color.Black;

                    SelectedBtn.Enabled = false;
                    SelectedBtn.Checked = false;
                    G.SwitchTurn();
                    this.FormHeader(G.P2);
                    G.P1.PrintEnemyBoard(LeftBoard);
                    G.P2.PrintMyBoard(RightBoard);
                    LeftBoard.Enabled = true;
                    RightBoard.Enabled = false;
                    SelectedBtn = null;
                }
                else
                {

                    this.FormHeader(G.P2);

                    RightBoard.Enabled = false;
                    Cursor.Current = Cursors.WaitCursor;
                    G.P2.PrintMyBoard(RightBoard);
                    G.P1.PrintEnemyBoard(LeftBoard);
                    Cursor.Current = Cursors.Default;
                    G.P1.CheckHit(row, column);
                    // selectedTile.Image = Display.UpdateImage(selectedTile);     or a static extension method
                    // SelectedBtn.BackColor = System.Drawing.Color.Black;

                    SelectedBtn.Enabled = false;
                    SelectedBtn.Checked = false;
                    G.SwitchTurn();
                    this.FormHeader(G.P1);
                    Cursor.Current = Cursors.WaitCursor;
                    G.P1.PrintMyBoard(LeftBoard);
                    G.P2.PrintEnemyBoard(RightBoard);
                    Cursor.Current = Cursors.Default;
                    RightBoard.Enabled = true;
                    LeftBoard.Enabled = false;
                    SelectedBtn = null;
                }
            }
            else
            {
                MessageBox.Show("Must select a coordinate to fire at!");
            }
        }
    }
}
