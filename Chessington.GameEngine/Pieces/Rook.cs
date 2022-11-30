using Chessington.GameEngine.Pieces;
using Chessington.GameEngine;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var rookMovesList = new List<Square>();
            var rookLocation = board.FindPiece(this);

            for (var i = 0; i < 8; i++)
            {
                rookMovesList.Add(Square.At(rookLocation.Row, i));
                rookMovesList.Add(Square.At(i, rookLocation.Col));
            }

            rookMovesList.RemoveAll(item => item == rookLocation);

            return rookMovesList;
        }
    }
}