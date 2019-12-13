namespace SeaBattle
{
    /// <summary>
    /// A class controlling the game process logic
    /// </summary>
    public class GameController
    {
        #region Private fields

        private Board player1View;
        private Board player2View;

        private class ShipDistribution
        {
            private Ship[,] putShips;

            public ShipDistribution() 
            {
                putShips = new Ship[Board.fieldSize, Board.fieldSize];
            }

            /// <summary>
            /// Placing a ship on the field
            /// </summary>
            /// <param name="x">horizontal coordinate of ship's start point</param>
            /// <param name="y">vertical coordinate of ship's start point</param>
            /// <param name="sh">ship object</param>
            /// <param name="alignHorizontally">a flag defining the orientation of a ship on the field</param>
            public void PlaceShip(int x, int y, Ship sh, bool alignHorizontally)
            {
                if (alignHorizontally)
                    for (int j = 0; j < sh.Size; ++j)
                        putShips[x, j] = sh;
                else
                    for (int i = 0; i < sh.Size; ++i)
                        putShips[i, y] = sh;
            }

            public bool ContainsShip(int x, int y) => putShips[x, y] != null;
        }

        private ShipDistribution player1Ship;
        private ShipDistribution player2Ship;

        #endregion

        #region Constructor

        public GameController()
        {
            player1Ship = new ShipDistribution();
            player2Ship = new ShipDistribution();
        }

        #endregion

    }
}
