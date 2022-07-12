

namespace SimpleChessGame.Board
{
    internal class Board
    {
        private BoardField[,] Field { get; set; }

        public Board()
        {
            
            for (int y_interator = 0; y_interator <= 8; y_interator++)
            {
                y_interator++;

                for (int x_interator = 0; x_interator <= 8; x_interator++)
                {
                    this.Field[x_interator, y_interator] = new BoardField(1,1,x_interator, y_interator);
                }
            }



        }
    }
}
