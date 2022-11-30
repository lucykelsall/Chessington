using Chessington.GameEngine.Pieces;
using Chessington.GameEngine;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var bishopMovesList = new List<Square>();
            var bishopLocation = board.FindPiece(this);

            for (var i = 0; i < 8; i++)
            {
                var bishopMoves = new List<Square> { 
                    Square.At(bishopLocation.Row + i, bishopLocation.Col + i), 
                    Square.At(bishopLocation.Row + i, bishopLocation.Col - i),
                    Square.At(bishopLocation.Row - i, bishopLocation.Col + i),
                    Square.At(bishopLocation.Row - i, bishopLocation.Col - i)
                };

                foreach (var move in bishopMoves)
                {
                    if (move.isSquareOnBoard() == true)
                    {
                        bishopMovesList.Add(move);
                    }
                }
            }

            bishopMovesList.RemoveAll(item => item == bishopLocation);

            return bishopMovesList;
        }
    }
}