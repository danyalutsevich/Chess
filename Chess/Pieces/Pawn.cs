using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess.Pieces
{
    class Pawn : Piece
    {
        private bool firstMove;

        public Pawn(int x, int y, string? team) : base(x, y, team)
        {
            firstMove = true;
        }

        public override void ShowAvailableMoves()
        {
            int Direction = 0;

            if (team == "[")
            {
                Direction = 1;
            }
            else if (team == "]")
            {
                Direction = -1;
            }

            try
            {
                if (Chess.pieces[x + Direction][y] is Empty)
                {
                    Chess.board[x + Direction][y].BackColor = Color.Green;
                }
                if (firstMove)
                {
                    if (Chess.pieces[x + Direction * 2][y] is Empty)
                    {
                        Chess.board[x + Direction * 2][y].BackColor = Color.Green;
                    }
                }
                if (Chess.pieces[x + Direction][y + 1] is not Empty)
                {
                    Chess.board[x + Direction][y + 1].BackColor = Color.Green;
                }
                if (Chess.pieces[x + Direction][y - 1] is not Empty)
                {
                    Chess.board[x + Direction][y - 1].BackColor = Color.Green;
                }
            }
            catch { }

        }

        public override void Move(int x, int y)
        {
            Chess.board[this.x][this.y].Image = Textures.Empty;

            Chess.pieces[this.x][this.y] = new Empty(this.x,this.y,"");

            this.x = x;
            this.y = y;

            Chess.pieces[x][y] = this;

            firstMove = false;

            UpdateTexture();

        }

        public override void UpdateTexture()
        {

            if (team == "[")
            {
                Chess.board[x][y].Image = Textures._Pawn;
            }
            else if (team == "]")
            {
                Chess.board[x][y].Image = Textures.Pawn_;
            }

        }

    }
}
