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
            
            for (var i = 1; i < 8; i++)
            {
                var squareToMoveTo = Square.At(bishopLocation.Row + i, bishopLocation.Col + i);

                if (squareToMoveTo.isSquareOnBoard() == true)
                {
                    if (board.GetPiece(squareToMoveTo) == null && squareToMoveTo.isSquareOnBoard() == true)
                    {
                        bishopMovesList.Add(squareToMoveTo);
                    }
                    else if (board.GetPiece(squareToMoveTo).Player != this.Player &&
                             squareToMoveTo.isSquareOnBoard() == true)
                    {
                        bishopMovesList.Add(squareToMoveTo);
                        break;
                    }
                    else if (board.GetPiece(squareToMoveTo).Player == this.Player &&
                             squareToMoveTo.isSquareOnBoard() == true)
                    {
                        break;
                    }
                }

                var otherSquareToMoveTo = Square.At(bishopLocation.Row + i, bishopLocation.Col - i);

                if (otherSquareToMoveTo.isSquareOnBoard() == true)
                {
                    if (board.GetPiece(otherSquareToMoveTo) == null && otherSquareToMoveTo.isSquareOnBoard() == true)
                    {
                        bishopMovesList.Add(otherSquareToMoveTo);
                    }
                    else if (board.GetPiece(otherSquareToMoveTo).Player != this.Player &&
                             otherSquareToMoveTo.isSquareOnBoard() == true)
                    {
                        bishopMovesList.Add(otherSquareToMoveTo);
                        break;
                    }
                    else if (board.GetPiece(otherSquareToMoveTo).Player == this.Player &&
                             otherSquareToMoveTo.isSquareOnBoard() == true)
                    {
                        break;
                    }
                }

                var xSquareToMoveTo = Square.At(bishopLocation.Row - i, bishopLocation.Col + i);

                if (xSquareToMoveTo.isSquareOnBoard() == true)
                {
                    if (board.GetPiece(xSquareToMoveTo) == null && xSquareToMoveTo.isSquareOnBoard() == true)
                    {
                        bishopMovesList.Add(xSquareToMoveTo);
                    }
                    else if (board.GetPiece(xSquareToMoveTo).Player != this.Player &&
                             xSquareToMoveTo.isSquareOnBoard() == true)
                    {
                        bishopMovesList.Add(xSquareToMoveTo);
                        break;
                    }
                    else if (board.GetPiece(xSquareToMoveTo).Player == this.Player &&
                             xSquareToMoveTo.isSquareOnBoard() == true)
                    {
                        break;
                    }
                }

                var ySquareToMoveTo = Square.At(bishopLocation.Row - i, bishopLocation.Col - i);

                if (ySquareToMoveTo.isSquareOnBoard() == true)
                {
                    if (board.GetPiece(ySquareToMoveTo) == null && ySquareToMoveTo.isSquareOnBoard() == true)
                    {
                        bishopMovesList.Add(ySquareToMoveTo);
                    }
                    else if (board.GetPiece(ySquareToMoveTo).Player != this.Player &&
                             ySquareToMoveTo.isSquareOnBoard() == true)
                    {
                        bishopMovesList.Add(ySquareToMoveTo);
                        break;
                    }
                    else if (board.GetPiece(ySquareToMoveTo).Player == this.Player &&
                             ySquareToMoveTo.isSquareOnBoard() == true)
                    {
                        break;
                    }
                }
            }

            return bishopMovesList;
        }
    }
}