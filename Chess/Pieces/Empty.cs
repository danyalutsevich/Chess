using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Empty : Piece
    {
        public Empty(int x, int y, string? team) : base(x, y, team)
        {
        }

        public override void ShowAvailableMoves()
        {
        }

        public override void Move(int x, int y)
        {
        }

        public override void UpdateTexture()
        {
        }
    }
}
