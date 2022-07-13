using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleChessGame.Board
{
    internal class ChessBoard
    {
        private List<BoardField> Field { get; set; } = new List<BoardField>();

        public ChessBoard()
        {
            int xFormLocation = 25, yFormLocation;

            for (int x = 1; x <= 8; x++)
            {
                yFormLocation = 25;

                for (int y = 1; y <= 8; y++)
                {
                    this.Field.Add(new BoardField(xFormLocation, yFormLocation, x, y));

                    yFormLocation += 74;
                }

                xFormLocation += 74;
            }
        }

        internal void DrawBoard(Form window)
        {
            foreach (BoardField field in this.Field)
            {
                window.Controls.Add(field.Button);
            }
        }
    }
}
