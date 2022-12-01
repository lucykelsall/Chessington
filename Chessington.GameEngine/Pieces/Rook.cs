using Chessington.GameEngine.Pieces;
using Chessington.GameEngine;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;

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

            for (var i = rookLocation.Col + 1; i < 8; i++)
            {
                var squareToMoveTo = Square.At(rookLocation.Row, i);

                if (board.GetPiece(squareToMoveTo) == null && squareToMoveTo.isSquareOnBoard() == true)
                {
                    rookMovesList.Add(squareToMoveTo);
                }
                else if (board.GetPiece(squareToMoveTo).Player != this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    rookMovesList.Add(squareToMoveTo);
                    break;
                }
                else if (board.GetPiece(squareToMoveTo).Player == this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    break;
                }
            }

            for (var i = rookLocation.Col - 1; i > -1; i--)
            {
                var squareToMoveTo = Square.At(rookLocation.Row, i);

                if (board.GetPiece(squareToMoveTo) == null && squareToMoveTo.isSquareOnBoard() == true)
                {
                    rookMovesList.Add(squareToMoveTo);
                }
                else if (board.GetPiece(squareToMoveTo).Player != this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    rookMovesList.Add(squareToMoveTo);
                    break;
                }
                else if (board.GetPiece(squareToMoveTo).Player == this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    break;
                }
            }
            for (var i = rookLocation.Row + 1; i < 8; i++)
            {
                var squareToMoveTo = Square.At(i, rookLocation.Col);

                if (board.GetPiece(squareToMoveTo) == null && squareToMoveTo.isSquareOnBoard() == true)
                {
                    rookMovesList.Add(squareToMoveTo);
                }
                else if (board.GetPiece(squareToMoveTo).Player != this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    rookMovesList.Add(squareToMoveTo);
                    break;
                }
                else if (board.GetPiece(squareToMoveTo).Player == this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    break;
                }
            }

            for (var i = rookLocation.Row - 1; i > -1; i--)
            {
                var squareToMoveTo = Square.At(i, rookLocation.Col);

                if (board.GetPiece(squareToMoveTo) == null && squareToMoveTo.isSquareOnBoard() == true)
                {
                    rookMovesList.Add(squareToMoveTo);
                }
                else if (board.GetPiece(squareToMoveTo).Player != this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    rookMovesList.Add(squareToMoveTo);
                    break;
                }
                else if (board.GetPiece(squareToMoveTo).Player == this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    break;
                }
            }

            return rookMovesList;
        }
    }
}