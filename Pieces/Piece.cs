namespace SimpleChessGame.Pieces
{
    public enum Direction {Horizontal, Vertical, Diagonal}

    internal abstract class Piece
    {
        public int MoveRange { get; private set; }
        public Direction[] MoveDirections { get; private set; }


    }
}
