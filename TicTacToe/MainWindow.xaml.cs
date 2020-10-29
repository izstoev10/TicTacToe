using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    public interface IGame
    {
        bool isGameFinished { get; }

        void NewGame(Grid Container);

        void MakeMove(Grid Container);
    }

    public partial class MainWindow : Window
    {
        public Game game;

        public MainWindow()
        {
            InitializeComponent();

            this.game = new Game();
            this.game.NewGame(Container);
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            this.game.setSender((Button)sender);
            this.game.MakeMove(Container);

            //If there is a winner - show message box
            if(game.isGameFinished == true)
            {
                MessageBox.Show("You have won");
            }

        }
    }
}
