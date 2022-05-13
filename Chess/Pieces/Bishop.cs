using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess.Pieces
{

    class Bishop : Piece
    {
        public Bishop(int x, int y, string? team) : base(x, y, team)
        {
            if (team == "[")
            {
                texture = Textures._Bishop;
            }
            else if (team == "]")
            {
                texture = Textures.Bishop_;
            }
        }

        public override void ShowAvailableMoves()
        {
            int x = this.x;
            int y = this.y;
            bool flag = false;

            for (int dx = -1; dx <= 1; dx += 2)
            {
                for (int dy = -1; dy <= 1; dy += 2)
                {
                    x += dx;
                    y += dy;

                    try
                    {
                        while (true)
                        {
                            var piece = Chess.pieces[x][y];

                            if (piece.team == this.team || flag )
                            {
                                break;
                            }

                            if((piece.team != this.team && piece.team != ""))
                            {
                                flag = true;
                            }
                            
                            Chess.board[x][y].BackColor = Color.Green;
                         
                            x += dx;
                            y += dy;
                        }
                    }
                    catch { }
                    finally
                    {
                        x = this.x;
                        y = this.y;
                        flag = false;
                    }
                }
            }
        }
    }
}
