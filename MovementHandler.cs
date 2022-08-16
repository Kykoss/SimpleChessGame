using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleChessGame.Board;
using SimpleChessGame.Pieces;
using System.Windows.Forms;

namespace SimpleChessGame
{
    internal static class MovementHandler
    {
        public static List<BoardField> GetPossibleMoves(ChessBoard board, BoardField field)
        {
            Piece piece = field.Piece;
            BoardField foundField;
            List<BoardField> possbileFields = new List<BoardField>();
            int newX, newY;            

            foreach (Direction direction in piece.MoveDirections)
            {
                newX = field.XCoordinate;
                newY = field.YCoordinate;

                for (int i = -piece.MoveRange; i <= piece.MoveRange; i++)
                {
                    switch (direction)
                    {
                        case Direction.Horizontal:
                            newX = field.XCoordinate + i;
                            break;
                        case Direction.Vertical:
                            newY = field.YCoordinate + i;
                            break;
                        case Direction.Diagonal:
                            //Special
                            break;
                    }

                    if (newX > 8 || newY > 8 || newX < 1 || newY < 1)
                        continue;

                    foundField = board.Field[newX - 1, newY - 1];

                    // TODO: Meh

                    possbileFields.Add(foundField);

                    /*if (foundField != field && 
                        foundField.Piece != null &&
                        foundField.Piece.Color == field.Piece.Color)
                    {
                        if (i < 0)
                        {
                            i = -1;
                            continue;
                        }
                        else
                            break;
                    } */

                    
                }
            } 

            return possbileFields;
        }

        public static void Move(BoardField fromField, BoardField toField)
        {
            toField.SetPiece(fromField.Piece);
            fromField.SetPiece(null);
        }
    }
}
