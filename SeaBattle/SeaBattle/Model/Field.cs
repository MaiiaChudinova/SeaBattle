using System;

namespace SeaBattle
{
    /// <summary>
    /// A class representing single player's battlefield
    /// </summary>
    public class Field
    {
        #region Private fields

        private FieldCell[,] field;

        #endregion

        #region Constructor

        public Field()
        {
            field = new FieldCell[fieldSize, fieldSize];

            // initializing fully unchecked board
            for (int i = 0; i < fieldSize; ++i)
                for (int j = 0; j < fieldSize; ++j)
                    field[i, j] = new FieldCell(i, j);
        }

        #endregion

        #region Public properties

        public FieldCell this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= fieldSize ||
                    j < 0 || j >= fieldSize)
                    throw new IndexOutOfRangeException($"Index ({i},{j}) out of range = 0..{fieldSize - 1}");

                return field[i, j];
            }

            set
            {
                if (i < 0 || i >= fieldSize ||
                    j < 0 || j >= fieldSize)
                    throw new IndexOutOfRangeException($"Index ({i},{j}) out of range = 0..{fieldSize - 1}");

                field[i, j] = value;
            }
        }

        #endregion

        #region Public methods


        #endregion

        #region Constants

        public const int fieldSize = 10;

        #endregion
    }
}
