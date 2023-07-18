using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Infraestructure.Game;

namespace Chess.Infraestructure.Pieces
{
    public class Piece
    {

        public int Value;
        public string Color;
        public string Name;
        public char Notation;
        public Coordinates Coordinates { get; set; }
        public List<Coordinates> AvailableMoves { get; set; }

    }
}
