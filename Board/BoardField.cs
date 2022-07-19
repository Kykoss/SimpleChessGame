using System.Windows.Forms;
using System.Drawing;
using SimpleChessGame.Pieces;

namespace SimpleChessGame.Board
{
    internal class BoardField
    {
        internal int XCoordinate { get; private set; }
        internal int YCoordinate { get; private set; }
        public string Name { get; private set; }
        internal Button Button { get; private set; }
        internal int Color { get; private set; }
        internal Piece Piece { get; private set; }

        public BoardField(int formXCoord, int formYCoord, int posX, int posY)
        {
            this.XCoordinate = posX;
            this.YCoordinate = posY;

            this.Button = new Button();
            this.Button.Name = (char)(64 + this.XCoordinate) + this.YCoordinate.ToString();
            this.Button.Size = new Size(75, 75);
            this.Button.Location = new Point(formXCoord, formYCoord);
        }

        internal void SetPiece (Piece piece)
        {
            this.Piece = piece;

            if (piece != null)
                this.Button.Image = this.Piece.Symbol;
            else
                this.Button.Image = null;
        }
    }
}
