using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    public class NewGame
    {
        public bool player1Turn;
        public bool isGameEnded;

        public MarkType[] results { get; private set; }

        public int[,] result = new int[3, 3];

        public void StartNewGame(Grid Container)
        {
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(0); j++)
                {
                    result[i, j] = (int)MarkType.Free;
                }
            }

            //Set current player to player 1
            this.player1Turn = true;

            //Get all values left from finished game and clear them
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {
                //Change background, foreground and content the default
                button.Content = string.Empty;
                button.Background = Brushes.White;
                button.Foreground = Brushes.Blue;
            });

            this.isGameEnded = false;
        }
    }
}
