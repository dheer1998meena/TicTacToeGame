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
            tic.Toss();
            // To choose a letter by a user
            char chooseLetter = tic.ChooseLetter();
            // To move desired location
            int userMove = tic.getUserMove(board);
            tic.makeMove(board, userMove, chooseLetter);
            tic.ShowBoard(board);
            Console.WriteLine("Check if Won: " + tic.isWinner(board, chooseLetter));


        }
    }
}
