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

            if (team == "[")
            {
                texture = Textures._Pawn;
            }
            else if (team == "]")
            {
                texture = Textures.Pawn_;
            }
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
                
                // Kill enemy
                var enemyRight = Chess.pieces[x + Direction][y + 1];
                var enemyLeft = Chess.pieces[x + Direction][y - 1];
                if (enemyRight is not Empty && enemyRight.team != team)
                {
                    Chess.board[x + Direction][y + 1].BackColor = Color.Green;
                }
                if (enemyLeft is not Empty && enemyLeft.team != team)
                {
                    Chess.board[x + Direction][y - 1].BackColor = Color.Green;
                }
            }
            catch { }

        }

        public override void Move(int x, int y)
        {

            base.Move(x, y);
            firstMove = false;
            if (x == 0 || x == 7)
            {
                Chess.pieces[x][y] = new Queen(x, y, team);
                Chess.board[x][y].Image = Chess.pieces[x][y].texture;
            }

        }
    }
}
