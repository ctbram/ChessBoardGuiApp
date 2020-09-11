using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        /// <summary>
        /// create Buttons and place them into pnlBoard.
        /// </summary>
        private void PopulateGrid()
        {
            int btnSize = pnlBoard.Width / _myBoard.Size;

            // make pnlBoard square
            pnlBoard.Height = pnlBoard.Width;

            // nexted loop to place the Buttons into the pnlBoard
            for (int i = 0; i < _myBoard.Size; i++)
            {
                for (int j = 0; j < _myBoard.Size; j++)
                {
                    btnGrid[i, j] = new Button
                    {
                        Height = btnSize,
                        Width = btnSize
                    };

                    // add a click event to each Button
                    btnGrid[i, j].Click += Grid_Button_Click;

                    // add the new button to the pnlBoard
                    pnlBoard.Controls.Add(btnGrid[i, j]);

                    // set location of new button
                    btnGrid[i, j].Location = new Point(i * btnSize, j * btnSize);

                    btnGrid[i, j].Text = i + "|" + j;
                    btnGrid[i, j].Tag = new Point(i, j);
                }
            }
        }

        /// <summary>
        /// get the row and col of the button that was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_Button_Click(object sender, EventArgs e)
        {
            // get the row and column of the button that was clicked
            Button clickedButton = (Button)sender;
            Point location = (Point)clickedButton.Tag;

            int row = location.X;
            int col = location.Y;

            Cell currentCell = _myBoard.TheGrid[row, col];

            // determine the next legal moves on the grid
            _myBoard.MarkNextLegalMoves(currentCell, cmbPieces.Text);

            // update the text on each button
            for (int i = 0; i < _myBoard.Size; i++)
            {
                for (int j = 0; j < _myBoard.Size; j++)
                {
                    btnGrid[i, j].Text = "";

                    if (_myBoard.TheGrid[i, j].LegalNextMove)
                    {
                        btnGrid[i, j].Text = "legal";
                    }
                    else if (_myBoard.TheGrid[i, j].CurrentlyOccupied)
                    {
                        btnGrid[i, j].Text = cmbPieces.Text;
                    }
                }
            }
        }

        /// <summary>
        /// Set default combo box choise as the first one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChessBoardGUI_Load(object sender, EventArgs e)
        {
            cmbPieces.SelectedIndex = 0;
        }
    }
}
