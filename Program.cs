using System;
using System.Reflection.Metadata;

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
            char userLetter = tic.ChooseLetter();
            char computerLetter = (userLetter == 'X') ? 'O' : 'X';
            // To move desired location
            int userMove = tic.getUserMove(board);
            tic.makeMove(board, userMove, userLetter);
            tic.ShowBoard(board);
            //Computer Move
            int computerMove = tic.getComputerMove(board, computerLetter, userLetter);
            Console.WriteLine("Check if Won: " + tic.isWinner(board, userLetter));

        }
    }
}
