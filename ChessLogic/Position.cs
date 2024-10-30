namespace ChessLogic


/*
 * if what 0/0 position starts from left up corner, from 0 to 7
 *                ^
 *                |
 *                |
 *                |
 *                |
 *                |
 * _______________|________________>
 *                |Working in this
 *                |axis area
 *                |
 *                |
 *                |
 *                |
 */
{
    public class Position //position on board (square)
    {
        public int Row { get; }
        public int Column { get; }

        public Position(int row, int column) //constructor each takes rw and column + stores in properties
        {
            Row = row; 
            Column = column;
        }

        public Player SquareColor() //check for a color of square
        {
            if ((Row + Column) % 2 == 0) //if sum of row and column is even = square white, if odd = square black
            {
                return Player.White;
            }

            return Player.Black;
        }

        //Override Equals & GetHashCode starts from here

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Column == position.Column;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }

        public static Position operator +(Position pos, Direction dir) //plus operator 
        {
            return new Position(pos.Row + dir.RowDelta, pos.Column + dir.ColumnDelta);
        }
    }
}
