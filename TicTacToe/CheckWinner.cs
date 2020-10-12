using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    public class CheckWinner
    {
        public NewGame game;

        public void CheckForWinner(NewGame game)
        {
            this.game = new NewGame();

            //Determine the size of the table
            int arrLength = this.game.result.GetLength(0);

            int winnerByColsX, winnerByColsO, winnerByDiagO, winnerByDiag2O, winnerByDiagX,
                winnerByDiag2X, winnerByRowsX, winnerByRowsO, currentCellRow, currentCellCol;

            winnerByDiag2O = winnerByDiag2X = winnerByDiagO = winnerByDiagX = 0;

            for (int row = 0; row < arrLength; row++)
            {
                //Reset values after every row 
                winnerByRowsX = 0;
                winnerByRowsO = 0;
                winnerByColsX = 0;
                winnerByColsO = 0;
                for (int col = 0; col < arrLength; col++)
                {
                    currentCellRow = this.game.result[row, col];
                    currentCellCol = this.game.result[col, row];

                    //Check diag where i = j
                    winnerByDiagO += (row == col && currentCellRow == (int)MarkType.Circle) ? 1 : 0;
                    winnerByDiagX += (row == col && currentCellRow == (int)MarkType.Cross) ? 1 : 0;

                    //Check reverse diag
                    winnerByDiag2O += (currentCellCol == currentCellRow && currentCellRow == (int)MarkType.Circle) ? 1 : 0;
                    winnerByDiag2X += (currentCellCol == currentCellRow && currentCellRow == (int)MarkType.Cross) ? 1 : 0;

                    //Check horizontal lines
                    winnerByRowsO += (currentCellRow == (int)MarkType.Circle) ? 1 : 0;
                    winnerByRowsX += (currentCellRow == (int)MarkType.Cross) ? 1 : 0;

                    //Check vertical lines
                    winnerByColsO += (currentCellCol == (int)MarkType.Circle) ? 1 : 0;
                    winnerByColsX += (currentCellCol == (int)MarkType.Cross) ? 1 : 0;


                }
                //Check if there is a winner
                if (winnerByDiag2O == arrLength
                    || winnerByDiag2X == arrLength
                    || winnerByDiagO == arrLength
                    || winnerByDiagX == arrLength
                    || winnerByRowsO == arrLength
                    || winnerByRowsX == arrLength
                    || winnerByColsO == arrLength
                    || winnerByColsX == arrLength
                    )
                {
                    this.game.isGameEnded = true;
                    MessageBox.Show("Congratulations, you have won");
                    break;
                }
            }
        }
    }
}
