using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Infraestructure.Pieces;

namespace Chess.Infraestructure.Game
{
    public class Square
    {
        public Coordinates Coordinates;
        public Piece? piece;
    }
}
