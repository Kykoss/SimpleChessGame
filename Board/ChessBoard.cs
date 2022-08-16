using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SimpleChessGame.Pieces;

namespace SimpleChessGame.Board
{
    internal class ChessBoard
    {
        public BoardField[,] Field { get; private set; } = new BoardField[8,8];
        public Form Window { get; private set; }
        private BoardField ActiveField { get; set; }

        public ChessBoard(Form window)
        {
            this.Window = window;

            int xFormLocation = 25, yFormLocation;

            for (int x = 1; x <= 8; x++)
            {
                yFormLocation = 25;

                for (int y = 1; y <= 8; y++)
                {
                    this.Field[x - 1, y - 1] = new BoardField(xFormLocation, yFormLocation, x, y);

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

        private BoardField GetFieldFromCoordinates (string coordinate)
        {
            int xIndex = char.Parse(coordinate.Substring(0, 1)) - 65;
            int yIndex = int.Parse(coordinate.Substring(1, 1)) - 1;

            try
            {
                return this.Field[xIndex, yIndex];
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Button pressedButton = (Button)sender;
            BoardField selectedField = this.GetFieldFromCoordinates(pressedButton.Name);

            if (this.ActiveField != null)
            {
                if (selectedField != this.ActiveField)
                    MovementHandler.Move(this.ActiveField, selectedField);

                foreach (BoardField field in this.Field)
                {
                    field.Button.Enabled = (field.Piece != null);
                }

                this.ActiveField = null;
            }
            else
            {
                this.ActiveField = this.GetFieldFromCoordinates(pressedButton.Name);

                foreach (BoardField field in this.Field)
                {
                    field.Button.Enabled = (field == selectedField);
                } 

                foreach (BoardField field in MovementHandler.GetPossibleMoves(this, selectedField))
                {
                    field.Button.Enabled = true;
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
