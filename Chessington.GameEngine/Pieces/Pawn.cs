using Chessington.GameEngine.Pieces;
using Chessington.GameEngine;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }


        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var pawnMovesList = new List<Square>();
            var pawnLocation = board.FindPiece(this);
            
            if (Player == Player.White)
            {
                var moveOneSquare = Square.At(pawnLocation.Row - 1, pawnLocation.Col);
                if (moveOneSquare.isSquareOnBoard() && board.GetPiece(moveOneSquare) == null)
                {
                    pawnMovesList.Add(moveOneSquare);

                    var moveTwoSquares = Square.At(pawnLocation.Row - 2, pawnLocation.Col);
                    if (moveTwoSquares.isSquareOnBoard() && FirstTurn &&
                        board.GetPiece(moveTwoSquares) == null)
                    {
                        pawnMovesList.Add(moveTwoSquares);
                    }
                }

                var diagonalMoves = new List<Square>
                {
                    Square.At(pawnLocation.Row - 1, pawnLocation.Col - 1), 
                    Square.At(pawnLocation.Row - 1, pawnLocation.Col + 1)
                };
                foreach (var move in diagonalMoves)
                {
                    if (move.isSquareOnBoard() && board.GetPiece(move) != null && board.GetPiece(move).Player == Player.Black)
                    {
                        pawnMovesList.Add(move);
                    }
                }
            }
            else
            {
                var moveOneSquare = Square.At(pawnLocation.Row + 1, pawnLocation.Col);
                if (moveOneSquare.isSquareOnBoard() && board.GetPiece(moveOneSquare) == null)
                {
                    pawnMovesList.Add(moveOneSquare);

                    var moveTwoSquares = Square.At(pawnLocation.Row + 2, pawnLocation.Col);
                    if (moveTwoSquares.isSquareOnBoard() && FirstTurn &&
                        board.GetPiece(moveTwoSquares) == null)
                    {
                        pawnMovesList.Add(moveTwoSquares);
                    }
                }
                
                var diagonalMoves = new List<Square>
                {
                    Square.At(pawnLocation.Row + 1, pawnLocation.Col - 1), 
                    Square.At(pawnLocation.Row + 1, pawnLocation.Col + 1)
                };
                foreach (var move in diagonalMoves)
                {
                    if (move.isSquareOnBoard() && board.GetPiece(move) != null && board.GetPiece(move).Player == Player.White)
                    {
                        pawnMovesList.Add(move);
                    }
                }
            }

            return pawnMovesList;
        }
    }
}