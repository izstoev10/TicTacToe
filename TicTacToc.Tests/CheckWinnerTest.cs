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
        public void AssumeFirstHorizontalIsTrue()
        {
            //Arrange
            var winner = new Game();

            winner.boardArray[0, 0] = (int)MarkType.Cross;
            winner.boardArray[0, 1] = (int)MarkType.Cross;
            winner.boardArray[0, 2] = (int)MarkType.Cross;

            //Assert     
            Assert.AreEqual(winner.boardArray[0, 0], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[0, 1], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[0, 2], (int)MarkType.Cross);
            Assert.IsTrue(winner.isGameFinished = true);
        }

        [Test]
        public void AssumeSecondHorizontalIsTrue()
        {
            //Arrange
            var winner = new Game();

            winner.boardArray[1, 0] = (int)MarkType.Cross;
            winner.boardArray[1, 1] = (int)MarkType.Cross;
            winner.boardArray[1, 2] = (int)MarkType.Cross;

            //Assert     
            Assert.AreEqual(winner.boardArray[1, 0], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[1, 1], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[1, 2], (int)MarkType.Cross);
            Assert.IsTrue(winner.isGameFinished = true);
        }

        [Test]
        public void AssumeThirdHorizontalIsTrue()
        {
            //Arrange
            var winner = new Game();

            winner.boardArray[2, 0] = (int)MarkType.Cross;
            winner.boardArray[2, 1] = (int)MarkType.Cross;
            winner.boardArray[2, 2] = (int)MarkType.Cross;

            //Assert     
            Assert.AreEqual(winner.boardArray[2, 0], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[2, 1], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[2, 2], (int)MarkType.Cross);
            Assert.IsTrue(winner.isGameFinished = true);
        }

        [Test]
        public void AssumeFirstVerticalIsTrue()
        {
            //Arrange
            var winner = new Game();

            winner.boardArray[0, 0] = (int)MarkType.Cross;
            winner.boardArray[1, 0] = (int)MarkType.Cross;
            winner.boardArray[2, 0] = (int)MarkType.Cross;

            //Assert     
            Assert.AreEqual(winner.boardArray[0, 0], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[1, 0], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[2, 0], (int)MarkType.Cross);
            Assert.IsTrue(winner.isGameFinished = true);
        }

        [Test]
        public void AssumeSecondVerticalIsTrue()
        {
            //Arrange
            var winner = new Game();

            winner.boardArray[0, 1] = (int)MarkType.Cross;
            winner.boardArray[1, 1] = (int)MarkType.Cross;
            winner.boardArray[2, 1] = (int)MarkType.Cross;

            //Assert     
            Assert.AreEqual(winner.boardArray[0, 1], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[1, 1], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[2, 1], (int)MarkType.Cross);
            Assert.IsTrue(winner.isGameFinished = true);
        }

        [Test]
        public void AssumeThirdVerticalIsTrue()
        {
            //Arrange
            var winner = new Game();

            winner.boardArray[0, 2] = (int)MarkType.Cross;
            winner.boardArray[1, 2] = (int)MarkType.Cross;
            winner.boardArray[2, 2] = (int)MarkType.Cross;

            //Assert     
            Assert.AreEqual(winner.boardArray[0, 2], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[1, 2], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[2, 2], (int)MarkType.Cross);
            Assert.IsTrue(winner.isGameFinished = true);
        }

        [Test]
        public void AssumeFirstDiagonalIsTrue()
        {
            //Arrange
            var winner = new Game();

            winner.boardArray[0, 0] = (int)MarkType.Cross;
            winner.boardArray[1, 1] = (int)MarkType.Cross;
            winner.boardArray[2, 2] = (int)MarkType.Cross;

            //Assert     
            Assert.That(winner.boardArray[0, 0] == (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[1, 1], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[2, 2], (int)MarkType.Cross);
            Assert.IsTrue(winner.isGameFinished = true);
        }

        [Test]
        public void AssumeSecondDiagonalIsTrue()
        {
            //Arrange
            var winner = new Game();

            winner.boardArray[2, 0] = (int)MarkType.Cross;
            winner.boardArray[1, 1] = (int)MarkType.Cross;
            winner.boardArray[0, 2] = (int)MarkType.Cross;

            //Assert     
            Assert.That(winner.boardArray[2, 0] == (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[1, 1], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[0, 2], (int)MarkType.Cross);
            Assert.IsTrue(winner.isGameFinished = true);
        }

        [Test]
        public void AssumeThereIsNoWinner()
        {
            //Arrange
            var winner = new Game();

            winner.boardArray[0, 0] = (int)MarkType.Cross;
            winner.boardArray[0, 1] = (int)MarkType.Cross;
            winner.boardArray[0, 2] = (int)MarkType.Cross;

            //Assert     
            Assert.That(winner.boardArray[0, 0] == (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[0, 1], (int)MarkType.Cross);
            Assert.AreEqual(winner.boardArray[0, 2], (int)MarkType.Cross);
            Assert.IsTrue(winner.isGameFinished = true);
        }


    }
}

