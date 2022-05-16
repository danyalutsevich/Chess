using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess.Pieces
{
    class King : Piece
    {
        public King(int x, int y, string? team) : base(x, y, team)
        {
            if (team == "[")
            {
                this.texture = Textures._King;
            }
            else if (team == "]")
            {
                this.texture = Textures.King_;
            }
        }

        public override void ShowAvailableMoves()
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (!(i == 0 && j == 0))
                    {
                        try
                        {
                            var cell = Chess.board[x + i][y + j];
                            var piece = Chess.pieces[x + i][y + j];
                            if (piece.team != this.team)
                            {
                                cell.BackColor = Color.Green;
                            }
                        }
                        catch
                        {

                        }

                    }
                }
            }
        }
    }

}
