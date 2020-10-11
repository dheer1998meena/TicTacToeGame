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

        //  To show Board 
        public void ShowBoard(char [] board)
        {
            Console.WriteLine("\n " + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + board[7] + " | " + board[8] + " | " + board[9]);
        }

        // To move a desired location
        public int getUserMove(char[] board)
        {
            int[] validCells = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while (true)
            {
                Console.WriteLine("Choose a position among 1 to 9");
                int index = Convert.ToInt32(Console.ReadLine());
                if (Array.Find<int>(validCells, element => element == index) != 0 && isSpaceFree(board, index))
                    return index;
            }
        }
        public bool isSpaceFree(char[] board, int index)
        {
            return board[index] == ' ';
        }

        public void makeMove(char[] board, int index, char letter)
        {
            bool spaceFree = isSpaceFree(board, index);
            if (spaceFree) board[index] = letter;
        }
    }
}
