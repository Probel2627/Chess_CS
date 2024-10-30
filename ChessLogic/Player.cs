namespace ChessLogic

//Represent color + which player turn right now + who won

{
    public enum Player
    {
        None,
        White,
        Black
    }

    public static class PlayerExtensions
    {
        public static Player Opponent(this Player player) //Method Opponent to find opponent
        {
            return player switch
            {
                Player.White => Player.Black,
                Player.Black => Player.White,
                _ => Player.None,
            };
        }
    }
}
