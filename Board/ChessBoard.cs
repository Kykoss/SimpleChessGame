using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SimpleChessGame.Pieces;

namespace SimpleChessGame.Board
{
    internal class ChessBoard
    {
        private List<BoardField> Field { get; set; } = new List<BoardField>();
        public Form Window { get; private set; }

        public bool ActiveTurn { get; set; } = false;

        public ChessBoard(Form window)
        {
            this.Window = window;

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

        internal void DrawBoard()
        {
            foreach (BoardField field in this.Field)
            {
                this.Window.Controls.Add(field.Button);
                field.Button.Click += this.OnButtonClick;
            }

            this.InitBoard();
        }

        internal void InitBoard()
        {
            foreach (BoardField field in this.Field)
            {
                if (field.YCoordinate <= 2 || field.YCoordinate >= 7)
                {
                    field.SetPiece(PieceFactory.GetPiece(field));
                    field.Button.Enabled = true;
                }
                    
            }
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Button pressedButton = (Button)sender;
            this.ActiveTurn = !this.ActiveTurn;
            BoardField selectedField = null;

            if (this.ActiveTurn)
            {
                foreach (BoardField field in this.Field)
                {
                    if (field.Button == pressedButton)
                    {
                        field.Button.Enabled = true;
                        selectedField = field;
                    }
                }

                foreach (BoardField field in MovementHandler.GetPossibleMoves(this, selectedField))
                {
                    //TODO: Natürlich noch nicht korrekt
                    field.Button.Enabled = true;
                }
            }
            else
            {
                foreach (BoardField field in this.Field)
                {
                    field.Button.Enabled = (field.Piece != null);

                }
            }
        }

        ~ChessBoard()
        {
            foreach (BoardField field in this.Field)
            {
                this.Window.Controls.Remove(field.Button);
            }
        }
    }
}
