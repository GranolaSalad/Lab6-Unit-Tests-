using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        //Create Board Method
        public static Char[,] CreateBoard()
        {
            //Create and return a new 3x3 array called "Board"
            char[,] board = new char[3, 3];
            return board;
        }

        public char CurrentPlayer(int currentPlayer)
        {
            //if it's player 1's turn
            if (currentPlayer == 1)
                //make the player symbol 'X'
                return 'X';
            //if it's player 2's turn
            else
                //make the player symbol 'O'
                return 'O';
        }

        //Change Player Method
        public int ChangePlayer(int lastPlayer)//pass it the player who just had a turn
        {
            //if player 1 just had a turn
            if (lastPlayer == 1)
                //let player 2 have a turn
                return 2;
            //if player 2 just had a turn
            else
                //let player 1 have a turn
                return 1;
        }

        //Make Move Method
        public void MakeMove(char[,] board, int row, int col, char playerSymbol)
        {
            //if the space the player is trying to select is already full
            if (SpaceInUse(board, row, col) == true)
                //say who controls that space
                Console.Write("That space is already " + board[row, col]);
            //if the space is empty
            else
                //put the current player's symbol on the board
                board[row, col] = playerSymbol;
        }

        //Space In Use Method
        public bool SpaceInUse (char[,] board, int row, int col)
        {
            //if the space is not null (in use)
            if (board[row,col] =='X'|| board[row,col] == 'O')
                //return that the space is already filled
                return true;
            //if the space is empty
            else
                //return that the space is empty
                return false;
        }
    }
}
