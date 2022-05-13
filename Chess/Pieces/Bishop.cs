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

        }

        public override void ShowAvailableMoves()
        {

            int x = this.x - 1;
            int y = this.y + 1;

            try
            {

                while (Chess.pieces[x][y].team == "")
                {
                    x--;
                    y++;

                    Chess.board[x][y].BackColor = Color.Green;

                    if (Chess.pieces[x][y].team != this.team && Chess.pieces[x][y].team != "")
                    {
                        break;
                    }

                }

            }
            catch { }

        }

        public override void Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void UpdateTexture()
        {
            throw new NotImplementedException();
        }
    }

}
