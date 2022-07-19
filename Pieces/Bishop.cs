using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChessGame.Pieces
{
    internal class Bishop: Piece
    {
        public Bishop(Color color) : base(color)
        {
            this.MoveDirections = new Direction[] { Direction.Diagonal };
            this.MoveRange = 8;


        }
    }
}
