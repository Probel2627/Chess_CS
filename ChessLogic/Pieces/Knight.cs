namespace ChessLogic
{
    public class Knight : Piece
    {
        public override PieceType Type => PieceType.Knight;
        public override Player Color { get; }

        public Knight(Player color)
        {
            Color = color;
        }

        public override Piece Copy()
        {
            Knight copy = new Knight(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }

        private static IEnumerable<Position> PotentialToPositions(Position from)  //Help method 
        {
            foreach (Direction vDir in new Direction[] { Direction.North, Direction.South }) //vertical Direction
            {
                foreach (Direction hDir in new Direction[] { Direction.West, Direction.East }) // horizontal Direction
                {
                    yield return from + 2 * vDir + hDir; //give all 8 potential positions
                    yield return from + 2 * hDir + vDir;
                }
            }
        }

        private IEnumerable<Position> MovePositions(Position from, Board board) //method to keep only legal methods for move
        {
            return PotentialToPositions(from).Where(pos => Board.IsInside(pos)
                && (board.IsEmpty(pos) || board[pos].Color != Color));
        }

        public override IEnumerable<Move> GetMoves(Position from, Board board) //just call move positions and then use select to create a moves
        {
            return MovePositions(from, board).Select(to => new NormalMove(from, to));
        }
    }
}
