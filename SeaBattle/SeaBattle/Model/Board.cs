namespace SeaBattle
{
    /// <summary>
    /// A class representing single player's battlefield
    /// </summary>
    public class Board
    {
        #region Private fields

        private FieldCell[,] field;

        #endregion

        #region Constructor

        public Board()
        {
            field = new FieldCell[fieldSize, fieldSize];

            // initializing fully unchecked board
            for (int i = 0; i < fieldSize; ++i)
                for (int j = 0; j < fieldSize; ++j)
                    field[i, j] = new FieldCell(i, j);
        }

        #endregion

        #region Public properties
        #endregion

        #region Public methods


        #endregion

        #region Constants

        public const int fieldSize = 10;

        #endregion
    }
}
