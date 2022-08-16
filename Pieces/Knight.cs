using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChessGame.Pieces
{
    internal class Knight: Piece
    {
        public Knight(Color color) : base(color)
        {
            this.MoveRange = 7;


        }
    }
}
