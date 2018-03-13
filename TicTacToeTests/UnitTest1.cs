using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeTests
{
    [TestClass]
    public class UnitTest1
    {

        //CreatBoard Test Method
        [TestMethod]
        public void CreateBoardTest()
        {
            //create a new instance of the Game object
            Game game = new Game();
            //create a new board matrix using the Game CreateBoard method
            char[,] newBoard = Game.CreateBoard();

            //create a variable to hold the number of spaces on the board
            int boardSpaces = newBoard.Length;

            //check if there are 9 spaces on the board
            //CHANGE TO MEET TEST CONDITIONS AS NECESSARY
            Assert.AreEqual(9, boardSpaces);
        }

        //CurrentPlayer Test Method
        [TestMethod]
        public void CurrentPlayerTest()
        {
            //create a new instance of the Game object
            Game game = new Game();

            //The variable that will be passed to the CurrentPlayer method to determine which characters to return
            //CHANGE TO MEET TEST CONDITIONS AS NECESSARY
            int currentPlayer = 1;

            //if currentPlayer is 1, returnedChar should be X
            //if currentPlayer is 2, returnedChar should be O
            char returnedChar = game.CurrentPlayer(currentPlayer);

            //check that returnedChar is what you expect it to be
            //CHANGE TO MEET TEST CONDITIONS AS NECESSARY
            Assert.AreEqual('X', returnedChar);
        }

        //ChangePlayer Test Method
        [TestMethod]
        public void ChangePlayerTest()
        {
            //create a new instance of the Game object
            Game game = new Game();

            //Variable to represent the player that just had a turn
            //CHANGE TO MEET TEST CONDITIONS AS NECESSARY
            int lastPlayer = 1;

            //if lastPlayer is 1, nextPlayer should be 2
            //if lastPlayer is 2, nextPlayer should be 1
            int nextPlayer = game.ChangePlayer(lastPlayer);

            //check that nextPlayer is what you expect it to be
            //CHANGE TO MEET TEST CONDITIONS AS NECESSARY
            Assert.AreEqual(2, nextPlayer);
        }

        //MakeMove Test Method
        [TestMethod]
        public void MakeMoveTest()
        {
            //create a new instance of the Game object
            Game game = new Game();

            //create a new game board
            char[,] board = Game.CreateBoard();

            //put a char in the first index of the board for testing purposes
            board[0, 0] = 'X';

            //execute the MakeMove method and store the result in moveMade
            //CHANGE TO MEET TEST CONDITIONS AS NECESSARY
            bool moveMade = game.MakeMove(board, 0, 0, 'X');

            //check that moveMade is what you expect it to be
            //CHANGE TO MEET TEST CONDITIONS AS NECESSARY
            Assert.AreEqual(false, moveMade);
        }

        //SpaceInUse Test Method
        [TestMethod]
        public void SpaceInUseTest()
        {
            //create a new instance of the Game object
            Game game = new Game();

            //create a new game board
            char[,] board = Game.CreateBoard();

            //put a char in the first index of the board for testing purposes
            //CHANGE TO MEET TEST CONDITIONS AS NECESSARY
            board[0, 0] = 'X';

            //execute the SpaceInUse method and store the result in moveMade
            //CHANGE TO MEET TEST CONDITIONS AS NECESSARY
            bool spaceOccupied = game.SpaceInUse(board, 0, 0);

            //check that moveMade is what you expect it to be
            //CHANGE TO MEET TEST CONDITIONS AS NECESSARY
            Assert.AreEqual(true, spaceOccupied);
        }
    }
}
