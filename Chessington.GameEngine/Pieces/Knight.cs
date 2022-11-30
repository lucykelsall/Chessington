﻿using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var knightMovesList = new List<Square>();
            var knightLocation = board.FindPiece(this);

            var knightMoves = new List<Square> {
                Square.At(knightLocation.Row + 1, knightLocation.Col + 2),
                Square.At(knightLocation.Row + 1, knightLocation.Col - 2),
                Square.At(knightLocation.Row + 2, knightLocation.Col + 1),
                Square.At(knightLocation.Row + 2, knightLocation.Col - 1),
                Square.At(knightLocation.Row - 1, knightLocation.Col + 2),
                Square.At(knightLocation.Row - 1, knightLocation.Col - 2),
                Square.At(knightLocation.Row - 2, knightLocation.Col + 1),
                Square.At(knightLocation.Row - 2, knightLocation.Col - 1),
            };

            foreach (var move in knightMoves)
            {
                if (move.isSquareOnBoard() == true)
                {
                    knightMovesList.Add(move);
                }
            }

            knightMovesList.RemoveAll(item => item == knightLocation);

            return knightMovesList;
        }
    }
}