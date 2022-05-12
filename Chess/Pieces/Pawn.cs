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
            firstMove = false;
        }
    }
}
