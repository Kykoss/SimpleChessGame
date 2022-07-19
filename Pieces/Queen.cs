using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChessGame.Pieces
{
    internal class Queen: Piece
    {
        public Queen(Color color) : base(color)
        {
            this.MoveDirections = new Direction[] { Direction.Horizontal, Direction.Vertical, Direction.Diagonal };
            this.MoveRange = 8;
        }
    }
}
