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
            this.onClick.buttonAction(sender, Container, game);

            this.winner = new CheckWinner();
            this.winner.CheckForWinner(game);
        }
    }
}
