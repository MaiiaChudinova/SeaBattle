using System;

namespace SeaBattle
{ 
    /// <summary>
    /// A class representing located ship
    /// </summary>
    public class ShipDistribution
    {
        #region Private fields

        private Ship[,] ship;

        #endregion

        #region Constructor

        public ShipDistribution()
        {
            ship = new Ship[Field.fieldSize, Field.fieldSize];

            for (int i = 0; i < Field.fieldSize; ++i)
                for (int j = 0; j < Field.fieldSize; ++j)
                    ship[i, j] = null;
        }

        #endregion

        #region Public methods

        // PLACE THIS CODE IN PLAYERCONTROLLER

        //public void PlaceShip(int x, int y, bool alignHorizontally, Ship sh)
        //{
        //    if (alignHorizontally)
        //    {
        //        for (int j = 0; j < sh.Size; ++j)
        //            ship[x, y + j] = sh;
        //    }
        //    else
        //    {
        //        for (int i = 0; i < sh.Size; ++i)
        //            ship[x + i, y] = sh;
        //    }
        //}

        //public void RemoveShip(int x, int y, Ship sh)
        //{
        //    if (ship[x, y] == null) throw new Exception($"Nothing to remove in cell ({x},{y}).");

        //    if (ship[x, y + 1] == sh)
        //    {
        //        for (int j = 0; j < sh.Size; ++j)
        //            ship[x, y + j] = null;
        //    }
        //    else
        //    {
        //        for (int i = 0; i < sh.Size; ++i)
        //            ship[x + i, y] = null;
        //    }
        //}

        #endregion

        #region Public properties

        public Ship this[int i, int j]
        {
            get
            {
                /// TODO: optimize usage of this code snippet
                ///
                if (i < 0 || i >= Field.fieldSize ||
                    j < 0 || j >= Field.fieldSize)
                    throw new IndexOutOfRangeException($"Index ({i},{j}) out of range = 0..{Field.fieldSize - 1}");
                ///

                return ship[i, j];
            }

            set 
            {
                if (i < 0 || i >= Field.fieldSize ||
                    j < 0 || j >= Field.fieldSize)
                    throw new IndexOutOfRangeException($"Index ({i},{j}) out of range = 0..{Field.fieldSize - 1}");

                ship[i, j] = value;
            }
        }

        #endregion

    }
}
