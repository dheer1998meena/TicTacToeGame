using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            TicTacToe tic = new TicTacToe();
            // To create a new board 
            char [] board = tic.CreateBoard();
            // To show board 
            tic.ShowBoard(board);
            // To choose a letter by a user
            tic.ChooseLetter();
        }
    }
}
