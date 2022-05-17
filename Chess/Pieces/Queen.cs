using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess.Pieces
{
    class Queen : Piece
    {
        public Queen(int x, int y, string? team) : base(x, y, team)
        {
            if (team == "[")
            {
                texture = Textures._Queen;
            }
            else if (team == "]")
            {
                texture = Textures.Queen_;
            }
        }

        public override void ShowAvailableMoves()
        {
            for (int i = -1; i <= 1; i += 1)
            {
                for (int j = -1; j <= 1; j += 1)
                {
                    var X = x;
                    var Y = y;

                    try
                    {
                        while (true)
                        {
                            X += i;
                            Y += j;
                            var piece = Chess.pieces[X][Y];
                            if (piece.team == team)
                            {
                                break;
                            }

                            Chess.board[X][Y].BackColor = Color.Green;

                            if (piece.team != team && piece.team != "")
                            {
                                break;
                            }
                        }
                    }
                    catch { }
                    finally
                    {
                        X = x;
                        Y = y;
                    }
                }
            }
        }
    }
}
