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

            for (var i = queenLocation.Col + 1; i < 8; i++)
            {
                var squareToMoveTo = Square.At(queenLocation.Row, i);

                if (board.GetPiece(squareToMoveTo) == null && squareToMoveTo.isSquareOnBoard() == true)
                {
                    queenMovesList.Add(squareToMoveTo);
                }
                else if (board.GetPiece(squareToMoveTo).Player != this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    queenMovesList.Add(squareToMoveTo);
                    break;
                }
                else if (board.GetPiece(squareToMoveTo).Player == this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    break;
                }
            }

            for (var i = queenLocation.Col - 1; i > -1; i--)
            {
                var squareToMoveTo = Square.At(queenLocation.Row, i);

                if (board.GetPiece(squareToMoveTo) == null && squareToMoveTo.isSquareOnBoard() == true)
                {
                    queenMovesList.Add(squareToMoveTo);
                }
                else if (board.GetPiece(squareToMoveTo).Player != this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    queenMovesList.Add(squareToMoveTo);
                    break;
                }
                else if (board.GetPiece(squareToMoveTo).Player == this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    break;
                }
            }

            for (var i = queenLocation.Row + 1; i < 8; i++)
            {
                var squareToMoveTo = Square.At(i, queenLocation.Col);

                if (board.GetPiece(squareToMoveTo) == null && squareToMoveTo.isSquareOnBoard() == true)
                {
                    queenMovesList.Add(squareToMoveTo);
                }
                else if (board.GetPiece(squareToMoveTo).Player != this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    queenMovesList.Add(squareToMoveTo);
                    break;
                }
                else if (board.GetPiece(squareToMoveTo).Player == this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    break;
                }
            }

            for (var i = queenLocation.Row - 1; i > -1; i--)
            {
                var squareToMoveTo = Square.At(i, queenLocation.Col);

                if (board.GetPiece(squareToMoveTo) == null && squareToMoveTo.isSquareOnBoard() == true)
                {
                    queenMovesList.Add(squareToMoveTo);
                }
                else if (board.GetPiece(squareToMoveTo).Player != this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    queenMovesList.Add(squareToMoveTo);
                    break;
                }
                else if (board.GetPiece(squareToMoveTo).Player == this.Player && squareToMoveTo.isSquareOnBoard() == true)
                {
                    break;
                }
            }
            
            for (var i = 1; i < 8; i++)
            {
                var squareToMoveTo = Square.At(queenLocation.Row + i, queenLocation.Col + i);

                if (squareToMoveTo.isSquareOnBoard() == true)
                {
                    if (board.GetPiece(squareToMoveTo) == null)
                    {
                        queenMovesList.Add(squareToMoveTo);
                    }
                    else if (board.GetPiece(squareToMoveTo).Player != this.Player)
                    {
                        queenMovesList.Add(squareToMoveTo);
                        break;
                    }
                    else if (board.GetPiece(squareToMoveTo).Player == this.Player)
                    {
                        break;
                    }
                }

                var otherSquareToMoveTo = Square.At(queenLocation.Row + i, queenLocation.Col - i);

                if (otherSquareToMoveTo.isSquareOnBoard() == true)
                {
                    if (board.GetPiece(otherSquareToMoveTo) == null)
                    {
                        queenMovesList.Add(otherSquareToMoveTo);
                    }
                    else if (board.GetPiece(otherSquareToMoveTo).Player != this.Player)
                    {
                        queenMovesList.Add(otherSquareToMoveTo);
                        break;
                    }
                    else if (board.GetPiece(otherSquareToMoveTo).Player == this.Player)
                    {
                        break;
                    }
                }

                var xSquareToMoveTo = Square.At(queenLocation.Row - i, queenLocation.Col + i);

                if (xSquareToMoveTo.isSquareOnBoard() == true)
                {
                    if (board.GetPiece(xSquareToMoveTo) == null)
                    {
                        queenMovesList.Add(xSquareToMoveTo);
                    }
                    else if (board.GetPiece(xSquareToMoveTo).Player != this.Player)
                    {
                        queenMovesList.Add(xSquareToMoveTo);
                        break;
                    }
                    else if (board.GetPiece(xSquareToMoveTo).Player == this.Player)
                    {
                        break;
                    }
                }

                var ySquareToMoveTo = Square.At(queenLocation.Row - i, queenLocation.Col - i);

                if (ySquareToMoveTo.isSquareOnBoard() == true)
                {
                    if (board.GetPiece(ySquareToMoveTo) == null)
                    {
                        queenMovesList.Add(ySquareToMoveTo);
                    }
                    else if (board.GetPiece(ySquareToMoveTo).Player != this.Player)
                    {
                        queenMovesList.Add(ySquareToMoveTo);
                        break;
                    }
                    else if (board.GetPiece(ySquareToMoveTo).Player == this.Player)
                    {
                        break;
                    }
                }
            }

            return queenMovesList;

        }
    }
}