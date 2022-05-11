using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Chess : Form
    {
        PictureBox[][] board;

        Piece SelectedPiece;
        
        public Chess()
        {
            InitializeComponent();

            board = new PictureBox[8][];

            for (int i = 0; i < 8; i++)
            {
                board[i] = new PictureBox[8];
            }

        }

        private void Chess_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i][j] = panelDeck.Controls.Find($"cell{i+1}{j+1}", true)[0] as PictureBox;
                }
            }
        }
    }

    class Piece
    {
        public int x { get; set; }
        public int y { get; set; }

        public int color { get; set; }

        public virtual void GetAvailableMoves()
        {

        }

    }

    class Pawn : Piece
    {
        public override void GetAvailableMoves()
        {

        }
    }

    class Empty : Piece
    {
        public override void GetAvailableMoves()
        {

        }
    }

    class Rook : Piece
    {
        public override void GetAvailableMoves()
        {

        }
    }

    class Knight : Piece
    {
        public override void GetAvailableMoves()
        {

        }
    }

    class Bishop : Piece
    {
        public override void GetAvailableMoves()
        {

        }
    }

    class Queen : Piece
    {
        public override void GetAvailableMoves()
        {

        }
    }

    class King : Piece
    {
        public override void GetAvailableMoves()
        {

        }
    }

}
