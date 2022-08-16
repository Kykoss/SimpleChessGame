using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleChessGame.Pieces
{
    internal class Rook : Piece
    {
        public Rook(Color color) : base(color)
        {
            this.MoveDirections = new Direction[] { Direction.Horizontal, Direction.Vertical };
            this.MoveRange = 7;


        }
    }
}
