using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChessGame.Pieces
{
    internal class Pawn: Piece
    {
        public Pawn(Color color) : base(color)
        {
            this.MoveDirections = new Direction[] { Direction.Vertical };
            this.MoveRange = 2;

        }

        public void Move()
        {
            // Move Logic
            
            if (this.MoveRange == 2)
            {
                this.MoveRange = 1;
            }
        }



    }
}
