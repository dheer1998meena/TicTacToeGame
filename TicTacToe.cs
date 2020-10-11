using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToe
    {
        public const int HEAD = 0;
        public const int TAIL = 1;
        public enum Player { USER, COMPUTER };
        // To create a new board
        public char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }

        // To choose a letter  by  a user
        public char ChooseLetter()
        {
            Console.WriteLine("Choose a letter among X and O");
            string userLetter = Console.ReadLine();
            return char.ToUpper(userLetter[0]);
        }

        //  To show Board 
        public void ShowBoard(char[] board)
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

        // Check for Free Space
        public void makeMove(char[] board, int index, char letter)
        {
            bool spaceFree = isSpaceFree(board, index);
            if (spaceFree) board[index] = letter;
        }

        // Play Toss Using Coin
        public void Toss()
        {
            string choice = null;
            bool val = true;
            while (val)
            {
                Console.WriteLine("What will you choose -- heads(1)/tails(0)?");
                choice = (Console.ReadLine());
                if (choice[0].Equals('1') || choice[0].Equals('0'))
                {
                    val = false;
                }
                else
                {
                    Console.WriteLine("Please provide valid input(0/1).");
                    val = true;
                }
            }
            int choice2 = Convert.ToInt32(choice);      //coming out of the loop when the choice matches with that entered 
            Random rn = new Random();                   //initialising random function
            if (rn.Next(0, 2) == choice2)               //getting randomly 2 values and matches with the entered choice
            {
                Console.WriteLine("You got your desired side.So, will play first");
            }
            else
            {
                Console.WriteLine("Computer will play first");
            }
        }

        // Check Result After Every Move
        public bool isWinner(char[] b, char ch)
        {
            return ((b[1] == ch && b[2] == ch && b[3] == ch) || //across the top horizontal
                (b[4] == ch && b[5] == ch && b[6] == ch) || //across the middle horizontal
                (b[7] == ch && b[8] == ch && b[9] == ch) || //across the bottom horizontal
                (b[1] == ch && b[4] == ch && b[7] == ch) || //across the left vertical
                (b[2] == ch && b[5] == ch && b[8] == ch) || //across the middle vertical
                (b[3] == ch && b[6] == ch && b[9] == ch) || //across the right vertical
                (b[1] == ch && b[5] == ch && b[9] == ch) || //across the first diagonal
                (b[7] == ch && b[5] == ch && b[3] == ch)); //across the second diagonal

        }

        // Computer move
        public int getComputerMove(char [] board , char computerLetter,char userLetter)
        {
            int winningMove = getWinningMove(board , computerLetter);
            if (winningMove != 0)
                return winningMove;
            int userWinningMove = getWinningMove(board, userLetter);
            if (userWinningMove != 0)
                return userWinningMove;
            return 0;
        }
        public int getWinningMove(char[] board ,char letter)
        {
            for (int index =1; index<board.Length; index++)
            {
                char[] copyOfBoard = getCopyOfBoard(board);
                if (isSpaceFree(copyOfBoard, index))
                {
                    makeMove(copyOfBoard, index, letter);
                    if (isWinner(copyOfBoard, letter))
                        return index;
                }
            }
            return 0;
        }
        public char [] getCopyOfBoard(char [] board)
        {
            char[] boardCopy = new char[10];
            System.Array.Copy(board,0, boardCopy, 0, board.Length);
            return boardCopy;
        }


    }
}
    

