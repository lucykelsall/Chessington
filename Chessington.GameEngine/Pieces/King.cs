using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var kingMovesList = new List<Square>();
            var kingLocation = board.FindPiece(this);

            var kingMoves = new List<Square> {
                Square.At(kingLocation.Row - 1, kingLocation.Col - 1),
                Square.At(kingLocation.Row - 1, kingLocation.Col),
                Square.At(kingLocation.Row - 1, kingLocation.Col + 1),
                Square.At(kingLocation.Row, kingLocation.Col - 1),
                Square.At(kingLocation.Row, kingLocation.Col + 1),
                Square.At(kingLocation.Row + 1, kingLocation.Col - 1),
                Square.At(kingLocation.Row + 1, kingLocation.Col),
                Square.At(kingLocation.Row + 1, kingLocation.Col + 1),
            };

            foreach (var move in kingMoves)
            {
                if (move.isSquareOnBoard() == true && 
                    (board.GetPiece(move) == null || board.GetPiece(move).Player != Player))
                {
                    kingMovesList.Add(move);
                }
            }

            return kingMovesList;
        }
    }
}