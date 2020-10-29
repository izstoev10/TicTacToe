using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    public class Game : IGame
    {
        public MarkType[] cellValue { get; private set; }

        public int[,] boardArray = new int[3, 3];

        public bool isGameFinished { get; set; }

        public bool playerOneTurn { get; private set; }

        private Button sender;

        public void Button_Click(Button sender, RoutedEventArgs e, Grid Container)
        {
            this.sender = sender;
            this.MakeMove(Container);
        }

        public void setSender(Button sender)
        {
            this.sender = sender;
        }

        //update board array
        //call function to check if there is a winner
        public void MakeMove(Grid Container)
        {
            //Handles the button click event
            //Start a new game on the first click after a finished game 
            if (isGameFinished == true)
            {
                NewGame(Container);
                return;
            }
            //Cast the sender to Button

            //Find the button from array
            var col = Grid.GetColumn(this.sender);
            var row = Grid.GetRow(this.sender);

            //Check if cell is free and don't do if it has a value  
            if (boardArray[row, col] != (int)MarkType.Free)
                return;

            //Set the value based on player's turn
            boardArray[row, col] = playerOneTurn ? (int)MarkType.Cross : (int)MarkType.Circle;

            this.sender.Content = playerOneTurn ? "X" : "O";

            //Chnage Circles to green
            if (!playerOneTurn)
                this.sender.Foreground = Brushes.Green;

            //Toggle players turns
            playerOneTurn ^= true;

            CheckForWinner();

        }

        public bool CheckForWinner()
        {

            //Determine the size of the table
            int arrLength = this.boardArray.GetLength(0);

            int winnerByColsX, winnerByColsO, winnerByDiagO, winnerByDiag2O, winnerByDiagX,
                winnerByDiag2X, winnerByRowsX, winnerByRowsO, currentCellRow, currentCellCol, firstCorner, secondCorner;

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
                    currentCellRow = this.boardArray[row, col];
                    currentCellCol = this.boardArray[col, row];
                    firstCorner = this.boardArray[0, arrLength - 1];
                    secondCorner = this.boardArray[arrLength - 1, 0];

                    //Check diag where i = j
                    winnerByDiagO += (row == col && currentCellRow == (int)MarkType.Circle) ? 1 : 0;
                    winnerByDiagX += (row == col && currentCellRow == (int)MarkType.Cross) ? 1 : 0;

                    //Check reverse diag
                    winnerByDiag2O += ((firstCorner == secondCorner) && (row + col == arrLength - 1) && currentCellRow == (int)MarkType.Circle) ? 1 : 0;
                    winnerByDiag2X += ((firstCorner == secondCorner) && (row + col == arrLength - 1) && currentCellRow == (int)MarkType.Cross) ? 1 : 0;

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
                    return true;

                }
            }
            return false;
        }

        //clear the board
        //set isGameFinished to false
        public void NewGame(Grid Container)
        {
            for (int i = 0; i < boardArray.GetLength(0); i++)
            {
                for (int j = 0; j < boardArray.GetLength(0); j++)
                {
                    boardArray[i, j] = (int)MarkType.Free;
                }
            }

            //Change background, foreground and content the default
                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    button.Content = string.Empty;
                    button.Background = Brushes.White;
                    button .Foreground = Brushes.Blue;
                });

            isGameFinished = false;
        }
    }
}
