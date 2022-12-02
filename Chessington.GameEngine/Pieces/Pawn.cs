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
            
            if (this.Player == Player.White)
            {
                var moveOneSquare = Square.At(pawnLocation.Row - 1, pawnLocation.Col);
                if (moveOneSquare.isSquareOnBoard() && board.GetPiece(moveOneSquare) == null)
                {
                    pawnMovesList.Add(moveOneSquare);

                    var moveTwoSquares = Square.At(pawnLocation.Row - 2, pawnLocation.Col);
                    if (moveTwoSquares.isSquareOnBoard() && this.FirstTurn == true &&
                        board.GetPiece(moveTwoSquares) == null)
                    {
                        pawnMovesList.Add(moveTwoSquares);
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
                    if (moveTwoSquares.isSquareOnBoard() && this.FirstTurn == true &&
                        board.GetPiece(moveTwoSquares) == null)
                    {
                        pawnMovesList.Add(moveTwoSquares);
                    }
                }
            }

            return pawnMovesList;
        }
    }
}