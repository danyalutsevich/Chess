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

            if (team == "[")
            {
                if (Chess.pieces[x + 1][y] is Empty)
                {
                    Chess.board[x + 1][y].BackColor = Color.Green;
                }
                if (firstMove)
                {
                    if (Chess.pieces[x + 2][y] is Empty)
                    {
                        Chess.board[x + 2][y].BackColor = Color.Green;
                    }
                }
            }
            else if (team == "]")
            {
                if (Chess.pieces[x - 1][y] is Empty)
                {
                    Chess.board[x - 1][y].BackColor = Color.Green;
                }
                if (firstMove)
                {
                    if (Chess.pieces[x - 2][y] is Empty)
                    {
                        Chess.board[x - 2][y].BackColor = Color.Green;
                    }
                }
            }

        }

        public override void Move(int x, int y)
        {
            Chess.board[this.x][this.y].Image = Textures.Empty;

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
