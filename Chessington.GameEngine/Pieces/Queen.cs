using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var queenMovesList = new List<Square>();
            var queenLocation = board.FindPiece(this);

            for (var i = 0; i < 8; i++)
            {
                var queenMoves = new List<Square> {
                    Square.At(queenLocation.Row, i),
                    Square.At(i, queenLocation.Col),
                    Square.At(queenLocation.Row + i, queenLocation.Col + i),
                    Square.At(queenLocation.Row + i, queenLocation.Col - i),
                    Square.At(queenLocation.Row - i, queenLocation.Col + i),
                    Square.At(queenLocation.Row - i, queenLocation.Col - i)
                };

                foreach (var move in queenMoves)
                {
                    if (move.isSquareOnBoard() == true)
                    {
                        queenMovesList.Add(move);
                    }
                }
            }
            
            queenMovesList.RemoveAll(item => item == queenLocation);

            return queenMovesList;
        }
    }
}