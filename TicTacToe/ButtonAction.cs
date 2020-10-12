using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    public class ButtonAction
    {
        public NewGame game;
        public CheckWinner winner;
        public ButtonAction onClick;

        //Handles the button click event 
        public void buttonAction(object sender, Grid Container, NewGame game)
        {
            this.game = game;
            //Start a new game on the first click after a finished game 
            if (this.game.isGameEnded)
            {
                this.game.StartNewGame(Container);
                return;
            }

            //Cast the sender to Button
            var button = (Button)sender;

            //Find the button from array
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);

            //Check if cell is free and don't do if it has a value  
            if (this.game.result[row, column] != (int)MarkType.Free)
                return;

            //Set the value based on player's turn
            this.game.result[row, column] = this.game.player1Turn ? (int)MarkType.Cross : (int)MarkType.Circle;

            button.Content = this.game.player1Turn ? "X" : "O";

            //Chnage Circles to green
            if (!this.game.player1Turn)
                button.Foreground = Brushes.Green;

            //Toggle players turns
            this.game.player1Turn ^= true;
        }
    }
}
