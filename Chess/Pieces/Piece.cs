using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    public abstract class Piece
    {
        public int x { get; set; }
        public int y { get; set; }

        public string? team { get; set; }

        public Piece(int x, int y, string? team)
        {
            this.x = x;
            this.y = y;
            this.team = team;
        }

        public abstract void ShowAvailableMoves();

        public abstract void Move(int x, int y);

        public abstract void UpdateTexture();

    }
}
