using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ChessBoardModel;

namespace ChessBoardGuiApp
{
    public partial class frmChessBoardGUI : Form
    {
        // reference to the Board class which defines and holds the valid piece moves on the board.
        private static Board _myBoard = new Board(8);

        // 2D array of Buttons whos values are determined by _myBoard.
        public Button[,] btnGrid = new Button[_myBoard.Size, _myBoard.Size];

        public frmChessBoardGUI()
        {
            InitializeComponent();
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            // create Buttons and place them into pnlBoard.

            int btnSize = pnlBoard.Width / _myBoard.Size;

            // make pnlBoard square
            pnlBoard.Height = pnlBoard.Width;

            // nexted loop to place the Buttons into the pnlBoard
            for (int i = 0; i < _myBoard.Size; i++)
            {
                for (int j = 0; j < _myBoard.Size; j++)
                {
                    btnGrid[i, j] = new Button();
                    btnGrid[i, j].Height = btnSize;
                    btnGrid[i, j].Width = btnSize;

                    // add a click event to each Button
                    btnGrid[i, j].Click += Grid_Button_Click;

                    // add the new button to the pnlBoard
                    pnlBoard.Controls.Add(btnGrid[i, j]);

                    // set location of new button
                    btnGrid[i, j].Location = new Point(i * btnSize, j * btnSize);

                    btnGrid[i, j].Text = i + "|" + j;
                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed a button");
        }
    }
}
