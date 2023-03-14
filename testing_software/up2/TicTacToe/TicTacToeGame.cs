using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public const string WINNER_TEXT_X = "X e победител";
        public const string WINNER_TEXT_O = "O e победител";
        public const string WINNER_TEXT_DRAW = "Резултатът е равен";
        public const string WINNER_TEXT_NO_WINNER_YET = "Няма победител";
        public const int BOARD_SIZE = 3;
        public const int PLAYER_X = 1;
        public const int PLAYER_O = -1;
        public const int EMPTY_CELL = 0;

        private int[,] board;
        private int currentPlayer;

        public TicTacToeGame()
        {
            board = new int[BOARD_SIZE, BOARD_SIZE];
            currentPlayer = PLAYER_O;
        }

        public String play(int x, int y)
        {
            if (isValidMove(x, y) == true)
            {
                int nextPlayer = getNextPlayer();
                board[y, x] = nextPlayer;

                changePlayer();
            }

            String currentGameStatus = getCurrentGameStatus();

            return currentGameStatus;
        }

        public string getCurrentGameStatus()
        {
            bool hasWinner;

            // проверка за победител по редовете
            for (int j = 0; j < BOARD_SIZE; j++)
            {
                hasWinner = true;

                for (int i = 0; i < BOARD_SIZE - 1; i++)
                {
                    if (board[j, i] != board[j, i + 1] || board[j, i] == EMPTY_CELL)
                    {
                        hasWinner = false;
                        break;
                    }
                }

                if (hasWinner == true)
                {
                    if (board[j, 0] == PLAYER_X)
                        return WINNER_TEXT_X;
                    else
                        return WINNER_TEXT_O;
                }
            }

            // проверка за победител по колони
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                hasWinner = true;

                for (int j = 0; j < BOARD_SIZE - 1; j++)
                {
                    if (board[j, i] != board[j + 1, i] || board[j, i] == EMPTY_CELL)
                    {
                        hasWinner = false;
                        break;
                    }
                }

                if (hasWinner == true)
                {
                    if (board[0, i] == PLAYER_X)
                        return WINNER_TEXT_X;
                    else
                        return WINNER_TEXT_O;
                }
            }

            // Проверка за победител по диагоналите
            // Проверка на главния диагонал
            hasWinner = true;
            for (int i = 0; i < BOARD_SIZE - 1; i++)
            {
                if (board[i, i] != board[i + 1, i + 1] || board[i, i] == EMPTY_CELL)
                {
                    hasWinner = false;
                    break;
                }
            }

            if (hasWinner == true)
            {
                if (board[0, 0] == PLAYER_X)
                    return WINNER_TEXT_X;
                else
                    return WINNER_TEXT_O;
            }

            // Проверка на второстепенния диагонал
            hasWinner = true;
            for (int i = 0; i < BOARD_SIZE - 1; i++)
            {
                if (board[i, BOARD_SIZE - 1 - i] != board[i + 1, BOARD_SIZE - 1 - i - 1] || board[i, BOARD_SIZE - 1 - i] == EMPTY_CELL)
                {
                    hasWinner = false;
                    break;
                }
            }

            if (hasWinner == true)
            {
                if (board[BOARD_SIZE - 1, 0] == PLAYER_X)
                    return WINNER_TEXT_X;
                else
                    return WINNER_TEXT_O;
            }

            // проверка за още свободни клетки
            for (int j = 0; j < BOARD_SIZE; j++)
            {
                for (int i = 0; i < BOARD_SIZE; i++)
                {
                    if (board[j, i] == EMPTY_CELL)
                        return WINNER_TEXT_NO_WINNER_YET;
                }
            }

            // при липса на свободни клетки и 
            // победител, резулатът е равен
            return WINNER_TEXT_DRAW;
        }

        private void changePlayer()
        {
            currentPlayer = -currentPlayer;
        }

        public int getNextPlayer()
        {
            return -currentPlayer;
        }

        public int getCurrentPlayer()
        {
            return currentPlayer;
        }

        public bool isValidMove(int x, int y)
        {
            if (x < 0 || x > BOARD_SIZE - 1 || y < 0 || y > BOARD_SIZE - 1)
                throw new IndexOutOfRangeException();

            if (board[y, x] != EMPTY_CELL)
                throw new InvalidOperationException();

            return true;
        }

        public void clearCell(int x, int y)
        {

        }

        public void restartGame()
        {
            
        }
    }
}

