namespace SeaBattle
{
    /// <summary>
    /// A class responsible for logic interaction between objects
    /// inhrited from <see cref="PlayerController"/>
    /// </summary>
    public class InteractionController
    {
        #region Private fields

        private PlayerController p1;
        private PlayerController p2;

        private class ShipDistribution
        {
            private Ship[,] putShip;

            public ShipDistribution() 
            {
                putShip = new Ship[Field.fieldSize, Field.fieldSize];
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
                        putShip[x, j] = sh;
                else
                    for (int i = 0; i < sh.Size; ++i)
                        putShip[i, y] = sh;
            }

            public bool ContainsShip(int x, int y) => putShip[x, y] != null;
        }


        #endregion

        #region Constructor


        #endregion

    }
}
