using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChessGame.Pieces
{
    internal class Pawn: Piece
    {
        internal bool HasMoves { get; private set; } = false;

        public Pawn(Color color) : base(color)
        {
            //this.MoveDirections = [Direction.Horizontal, Direction.Vertical];
            this.MoveRange = 1;

        }
    }
}
