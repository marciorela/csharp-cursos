﻿using BoardGame;

namespace Chess {
    public abstract class ChessPiece : Piece {

        public Color Color { get; private set; }
        public int MoveCount { get; private set; }

        public ChessPiece(Board board, Color color) : base(board) {
            Color = color;
        }

        public ChessPosition ChessPosition {
            get { return ChessPosition.FromPosition(base.Position); }
        }

        protected bool IsThereOpponentPiece(Position position) {
            ChessPiece p = (ChessPiece)Board.Piece(position);
            return p != null && p.Color != Color;
        }

        internal void IncreaseMoveCount() {
            MoveCount++;
        }

        internal void DecreaseMoveCount() {
            MoveCount--;
        }
    }
}
