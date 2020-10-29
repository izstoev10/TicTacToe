using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    public class CheckWinnerTests    
    {
        [Test]
        public void CheckWinnerIsTrue()
        {
            //Arrange
            var winner = new Game();

            //Act   
            //var checkForWin = winner.CheckForWinner();


            //Assert     
            Assert.That(winner.boardArray[0, 0], Is.EqualTo((int)MarkType.Free));
            Assert.That(winner.boardArray[0, 1], Is.EqualTo((int)MarkType.Free));
            Assert.That(winner.boardArray[0, 2], Is.EqualTo((int)MarkType.Free));
            Assert.IsTrue(winner.isGameFinished = true);
        }
    }
}

