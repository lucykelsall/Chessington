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
            List<Square> pawnMovesList = new List<Square>();
            var pawnLocation = board.FindPiece(this);
            
            if (this.Player == Player.White)
            {
                var availableSquare = Square.At(pawnLocation.Row - 1, pawnLocation.Col);
                pawnMovesList.Add(availableSquare);
            }
            else
            {
                var availableSquare = Square.At(pawnLocation.Row + 1, pawnLocation.Col);
                pawnMovesList.Add(availableSquare);
            }

            return pawnMovesList;
        }
    }
}