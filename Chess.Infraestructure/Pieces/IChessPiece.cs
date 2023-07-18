using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Infraestructure.Pieces
{
    public interface IChessPiece
    {
        public void CalculateAvailableMoves();
    }
}
