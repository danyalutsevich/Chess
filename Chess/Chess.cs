using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

using Chess.Pieces;

namespace Chess
{
    public partial class Chess : Form
    {

        Piece SelectedPiece;

        public static Piece[][]? pieces { get; set; }

        public static PictureBox[][]? board;

        public Chess()
        {
            InitializeComponent();

            pieces = new Piece[8][];

            board = new PictureBox[8][];

            for (int i = 0; i < 8; i++)
            {
                board[i] = new PictureBox[8];
            }

            for (int i = 0; i < 8; i++)
            {
                pieces[i] = new Piece[8];
            }

            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                {
                    pieces[i][0] = new Rook(i, 0, "[");
                    pieces[i][1] = new Knight(i, 1, "[");
                    pieces[i][2] = new Bishop(i, 2, "[");
                    pieces[i][3] = new Queen(i, 3, "[");
                    pieces[i][4] = new King(i, 4, "[");
                    pieces[i][5] = new Bishop(i, 5, "[");
                    pieces[i][6] = new Knight(i, 6, "[");
                    pieces[i][7] = new Rook(i, 7, "[");
                }
                else if (i == 7)
                {
                    pieces[i][0] = new Rook(i, 0, "]");
                    pieces[i][1] = new Knight(i, 1, "]");
                    pieces[i][2] = new Bishop(i, 2, "]");
                    pieces[i][3] = new Queen(i, 3, "]");
                    pieces[i][4] = new King(i, 4, "]");
                    pieces[i][5] = new Bishop(i, 5, "]");
                    pieces[i][6] = new Knight(i, 6, "]");
                    pieces[i][7] = new Rook(i, 7, "]");
                }
                else if (i == 1)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        pieces[i][j] = new Pawn(i, j, "[");
                    }
                }
                else if (i == 6)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        pieces[i][j] = new Pawn(i, j, "]");
                    }
                }
                else
                {
                    for (int j = 0; j < 8; j++)
                    {
                        pieces[i][j] = new Empty(i, j, "");
                    }
                }
            }

            using (var sw = new StreamWriter("board.txt"))
            {
                sw.Write(JsonSerializer.Serialize(pieces, pieces.GetType()));
            }
        }

        private void Chess_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i][j] = panelDeck.Controls.Find($"cell{i}{j}", true)[0] as PictureBox;
                }
            }

        }

        private void Board_Click(object sender, EventArgs e)
        {
            var xs = (sender as PictureBox).Name[4];
            var ys = (sender as PictureBox).Name[5];

            int x = int.Parse(xs.ToString());
            int y = int.Parse(ys.ToString());

            labelX.Text = x.ToString();
            labelY.Text = y.ToString();

            if (((PictureBox)sender).BackColor.Equals(Color.Green))
            {
                if (SelectedPiece is not null || SelectedPiece is not Empty)
                {
                    ClearBoard();
                    SelectedPiece.Move(x, y);
                }
            }
            else
            {
                var piece = pieces[x][y];
                if (piece is not Empty)
                {
                    ClearBoard();
                    piece.ShowAvailableMoves();
                    SelectedPiece = piece;
                }
            }

        }

        public void ClearBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        board[i][j].BackColor = Color.White;
                    }
                    else
                    {
                        board[i][j].BackColor = Color.Black;
                    }
                }
            }
        }
    }

}
