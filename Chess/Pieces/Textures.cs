using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess.Pieces
{
    class Textures 
    {
        public static Bitmap _Pawn;
        public static Bitmap _Rook;
        public static Bitmap _Knight;
        public static Bitmap _Bishop;
        public static Bitmap _Queen;
        public static Bitmap _King;

        public static Bitmap Pawn_;
        public static Bitmap Rook_;
        public static Bitmap Knight_;
        public static Bitmap Bishop_;
        public static Bitmap Queen_;
        public static Bitmap King_;

        public static Bitmap Empty;
        
        static Textures()
        {
            _Pawn = new Bitmap("Textures/Pawn[.png");
            _Rook = new Bitmap("Textures/Rook[.png");
            _Knight = new Bitmap("Textures/Knight[.png");
            _Bishop = new Bitmap("Textures/Bishop[.png");
            _Queen = new Bitmap("Textures/Queen[.png");
            _King = new Bitmap("Textures/King[.png");

            Pawn_ = new Bitmap("Textures/Pawn].png");
            Rook_ = new Bitmap("Textures/Rook].png");
            Knight_ = new Bitmap("Textures/Knight].png");
            Bishop_ = new Bitmap("Textures/Bishop].png");
            Queen_ = new Bitmap("Textures/Queen].png");
            King_ = new Bitmap("Textures/King].png");

            Empty = new Bitmap("Textures/Empty.png");
        }
    }

}
