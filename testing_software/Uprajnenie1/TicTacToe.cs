namespace TicTacToe{

    public class game
    {
        int curPlayer = 1; // 1->x , 2->O

        int[,] board = new int[3, 3];

        public int getCurrentPlayer(){
            return curPlayer;
        }

        public int getNextPlayer(){
            curPlayer--;
            return curPlayer;
        }

        public bool play(int x, int y)
        {
            if (board[x,y] == '\0')
            {
                board[x, y] = curPlayer;
                
                if (curPlayer == 1)
                {
                    curPlayer++;
                }
                else
                {
                    curPlayer--;
                }
            }
            else
            {
                Console.WriteLine("This square is not empty");
            }

            return true;
        }
    }

}