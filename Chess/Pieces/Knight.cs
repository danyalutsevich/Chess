using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess.Pieces
{

    class Knight : Piece
    {
        public Knight(int x, int y, string? team) : base(x, y, team)
        {

            if(team == "[")
            {
                texture = Textures._Knight;
            }
            else if (team == "]")
            {
                texture = Textures.Knight_;
            }

        }

        private static int[] xMoves = { -2, -1, 1, 2, 2, 1, -1, -2 };
        private static int[] yMoves = { 1, 2, 2, 1, -1, -2, -2, -1 };

        public override void ShowAvailableMoves()
        {

            for (int i = 0; i < xMoves.Length; i++)
            {
                try
                {
                    var X = this.x + xMoves[i];
                    var Y = this.y + yMoves[i];

                    if (Chess.pieces[X][Y].team != this.team)
                    {
                        Chess.board[X][Y].BackColor = Color.Green;
                    }
                }
                catch
                {

                }
            }
        }
    }
}
