using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChessGame.Pieces
{
    internal class King: Piece
    {
        public King(Color color) : base(color)
        {
            //this.MoveDirections = [Direction.Horizontal, Direction.Vertical];
            this.MoveRange = 1;


        }
    }
}
