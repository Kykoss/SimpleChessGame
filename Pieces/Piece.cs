using System.Drawing;
using System.Windows.Forms;

namespace SimpleChessGame.Pieces
{
    public enum Direction {Horizontal, Vertical, Diagonal}
    public enum Color {White, Black}

    internal abstract class Piece
    {
        public Color Color { get; protected set; }

        public int MoveRange { get; protected set; }
        public Direction[] MoveDirections { get; protected set; }

        public Image Symbol { get; protected set; }

        internal Piece(Color color)
        {
            this.Color = color;
            this.Symbol = GetSymbol();
        }

        private Image GetSymbol()
        {
            try
            {
                return Image.FromFile(string.Format("..\\..\\Pieces\\Images\\{0}_{1}.png", this.GetType().Name, this.Color));
            }
            catch (System.IO.FileNotFoundException)
            {
                return null;
            }
        }
    }
}
