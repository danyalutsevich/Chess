using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess.Pieces
{
    public abstract class Piece
    {
        public int x { get; set; }
        public int y { get; set; }

        public string? team { get; set; }
        public Bitmap texture { get; set; }

        public Piece(int x, int y, string? team)
        {
            this.x = x;
            this.y = y;
            this.team = team;
        }

        public abstract void ShowAvailableMoves();

        public virtual void UpdateTexture()
        {
            if (team == "[")
            {
                Chess.board[x][y].Image = this.texture;
            }
            else if (team == "]")
            {
                Chess.board[x][y].Image = this.texture;
            }
        }

        public virtual void Move(int x, int y)
        {
            Chess.board[this.x][this.y].Image = Textures.Empty;

            Chess.pieces[this.x][this.y] = new Empty(this.x, this.y, "");

            this.x = x;
            this.y = y;

            Chess.pieces[x][y] = this;


            UpdateTexture();

        }

    }
}
