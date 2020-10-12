using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic f                                                                                                                   or MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public NewGame game;
        public CheckWinner winner;
        public ButtonAction onClick;

        
        //Initiate NewGame class

        public MainWindow()
        {
           InitializeComponent();

            this.game = new NewGame();
            this.game.StartNewGame(Container);
        }


        public void Button_Click(object sender, RoutedEventArgs e)
        {
            this.onClick = new ButtonAction();
            this.onClick.Button_Click(sender, Container);

            this.winner = new CheckWinner();
            this.winner.CheckForWinner(game);
        }

        ////Handles the button click event 
        //public void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //Start a new game on the first click after a finished game 
        //    if (this.game.isGameEnded)
        //    {
        //        this.game.StartNewGame(Container);
        //        return;
        //    }

        //    //Cast the sender to Button
        //    var button = (Button)sender;

        //    //Find the button from array
        //    var column = Grid.GetColumn(button);
        //    var row = Grid.GetRow(button);

        //    //Check if cell is free and don't do if it has a value  
        //    if (this.game.result[row, column] != (int)MarkType.Free)
        //        return;

        //    //Set the value based on player's turn
        //    this.game.result[row, column] = this.game.player1Turn ? (int)MarkType.Cross : (int)MarkType.Circle;

        //    button.Content = this.game.player1Turn ? "X" : "O";

        //    //Chnage Circles to green
        //    if (!this.game.player1Turn)
        //        button.Foreground = Brushes.Green;

        //    //Toggle players turns
        //    this.game.player1Turn ^= true;

        //    //Debug 
        //    System.Diagnostics.Debug.WriteLine("");
        //    System.Diagnostics.Debug.WriteLine("-------------");
        //    for (int i = 0; i < this.game.result.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < this.game.result.GetLength(0); j++)
        //        {
        //            System.Diagnostics.Debug.Write(this.game.result[i, j]);
        //            System.Diagnostics.Debug.Write(this.game.player1Turn);
        //        }
        //        System.Diagnostics.Debug.WriteLine("");
        //    }
        //    //Check for a winner
        //    this.winner = new CheckWinner();
        //    this.winner.CheckForWinner(game);
        //}

        //private void CheckForWinner()
        //{
        //    //Determine the size of the table
        //    int arrLength = this.game.result.GetLength(0);

        //    int winnerByColsX, winnerByColsO, winnerByDiagO, winnerByDiag2O, winnerByDiagX,
        //        winnerByDiag2X, winnerByRowsX, winnerByRowsO, currentCellRow, currentCellCol;

        //    winnerByDiag2O = winnerByDiag2X = winnerByDiagO = winnerByDiagX = 0;

        //    for (int row = 0; row < arrLength; row++)
        //    {
        //        //Reset values after every row 
        //        winnerByRowsX = 0;
        //        winnerByRowsO = 0;
        //        winnerByColsX = 0;
        //        winnerByColsO = 0;
        //        for (int col = 0; col < arrLength; col++)
        //        {
        //            currentCellRow = this.game.result[row, col];
        //            currentCellCol = this.game.result[col, row];

        //            //Check diag where i = j
        //            winnerByDiagO += (row == col && currentCellRow == (int)MarkType.Circle) ? 1 : 0;
        //            winnerByDiagX += (row == col && currentCellRow == (int)MarkType.Cross) ? 1 : 0;

        //            //Check reverse diag
        //            winnerByDiag2O += (currentCellCol == currentCellRow && currentCellRow == (int)MarkType.Circle) ? 1 : 0;
        //            winnerByDiag2X += (currentCellCol == currentCellRow && currentCellRow == (int)MarkType.Cross) ? 1 : 0;

        //            //Check horizontal lines
        //            winnerByRowsO += (currentCellRow == (int)MarkType.Circle) ? 1 : 0;
        //            winnerByRowsX += (currentCellRow == (int)MarkType.Cross) ? 1 : 0;

        //            //Check vertical lines
        //            winnerByColsO += (currentCellCol == (int)MarkType.Circle) ? 1 : 0;
        //            winnerByColsX += (currentCellCol == (int)MarkType.Cross) ? 1 : 0;


        //        }
        //        //Check if there is a winner
        //        if (winnerByDiag2O == arrLength
        //            || winnerByDiag2X == arrLength
        //            || winnerByDiagO == arrLength
        //            || winnerByDiagX == arrLength
        //            || winnerByRowsO == arrLength
        //            || winnerByRowsX == arrLength
        //            || winnerByColsO == arrLength
        //            || winnerByColsX == arrLength
        //            )
        //        {
        //            this.game.isGameEnded = true;
        //            MessageBox.Show("Congratulations, you have won");
        //            break;
        //        }
        //    }
        //}
    }
}
