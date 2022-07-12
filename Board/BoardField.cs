using SimpleChessGame.Pieces;

namespace SimpleChessGame.Board
{
    internal class BoardField
    {
        internal int XCoordinate { get; private set; }
        internal int YCoordinate { get; private set; }
        public string Name { get; private set; }
        internal int Color { get; private set; }
        internal Piece Piece { get; private set; }

        public BoardField(float formXCoord, float formYCoord, int posX, int posY)
        {
            this.XCoordinate = posX;
            this.YCoordinate = posY;

        }
    }
}
