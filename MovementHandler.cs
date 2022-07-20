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
        public static BoardField[] GetPossibleMoves(ChessBoard board, BoardField field)
        {
            Piece piece = field.Piece;
            BoardField[] possbileFields = null;
            int newX, newY;

            foreach (Direction direction in piece.MoveDirections)
            {
                newX = field.XCoordinate;
                newY = field.YCoordinate;

                for (int i = -piece.MoveRange; i <= piece.MoveRange; i++)
                {
                    //TODO: Hier passt irgendwas noch gar nicht!

                    switch (direction)
                    {
                        case Direction.Horizontal:
                            newX += i;
                            break;
                        case Direction.Vertical:
                            newY += i;
                            break;
                        case Direction.Diagonal:
                            //Special
                            break;
                    }

                    if (newX > 8 || newY > 8 || newX < 1 || newY < 1)
                        continue;

                    MessageBox.Show(newX + " - " + newY);

                }
            } 

            return possbileFields;
        }

        public static void Move(BoardField fromField, BoardField toField)
        {

        }
    }
}
