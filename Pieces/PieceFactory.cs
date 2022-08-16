using SimpleChessGame.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleChessGame.Pieces;

namespace SimpleChessGame.Pieces
{

    internal static class PieceFactory
    {
        internal static Piece GetPiece(BoardField field)
        {
            Color color;

            if (field.YCoordinate <= 2)
                color = Color.Black;
            else
                color = Color.White;

            if (field.YCoordinate == 1 || field.YCoordinate == 8)
            {
                switch (field.XCoordinate)
                {
                    case 1: case 8:
                        return new Rook(color);

                    case 2: case 7:
                        return new Knight(color);

                    case 3: case 6:
                        return new Bishop(color);

                    case 4:
                        return new Queen(color);

                    case 5:
                        return new King(color);
                    default:
                        return null;
                }
            }
            else if (field.YCoordinate == 2 || field.YCoordinate == 7)
            {
             //   return new Pawn(color);
            }

            return null;
        }
    }
}
