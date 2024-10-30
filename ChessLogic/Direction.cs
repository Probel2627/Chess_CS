namespace ChessLogic
{
    public class Direction
    {
        //Basic directions

        public readonly static Direction North = new Direction(-1, 0); //to move up we need to write 1 with minus
        public readonly static Direction South = new Direction(1, 0); //otherwise to move down
        public readonly static Direction East = new Direction(0, 1);
        public readonly static Direction West = new Direction(0, -1);
        public readonly static Direction NorthEast = North + East;
        public readonly static Direction NorthWest = North + West;
        public readonly static Direction SouthEast = South + East;
        public readonly static Direction SouthWest = South + West;



        public int RowDelta { get; }
        public int ColumnDelta { get; }

        public Direction(int rowDelta, int columnDelta)
        {
            RowDelta = rowDelta;
            ColumnDelta = columnDelta;
        }

        public static Direction operator +(Direction dir1, Direction dir2) //add 2 directions together
        {
            return new Direction(dir1.RowDelta + dir2.RowDelta, dir1.ColumnDelta + dir2.ColumnDelta); //takes 2 directions and return combine direction
        }

        public static Direction operator *(int scalar, Direction dir) //scale a direction
        {
            return new Direction(scalar * dir.RowDelta, scalar * dir.ColumnDelta);
        }
    }
}
