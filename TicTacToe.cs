using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToe
    {
        // To create a new board
        public char [] CreateBoard()
        {
            char[] board = new char[10];
            for (int i=0; i<board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }

        // To choose a letter  by  a user
        public char ChooseLetter()
        {
            Console.WriteLine("Choose a letter among X and O");
            string chooseLetter = Console.ReadLine();
            return char.ToUpper(chooseLetter[0]);
        }
    }
}
