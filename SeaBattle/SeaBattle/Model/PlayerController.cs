namespace SeaBattle
{
    /// <summary>
    /// A class defining basic structure of player (human/AI) game-controller
    /// </summary>
    public abstract class PlayerController
    {
        protected Field myField;
        protected Field enemyField;
        protected InteractionController controller;

        #region Abstract methods

        /// <summary>
        /// Player makes a move based on his/her view of enemy's field
        /// </summary>
        /// <returns> Tuple of coordinates to shoot on enemy's field </returns>
        public abstract (int x, int y) MakeMove();

        #endregion

        #region Protected methods

        #endregion

        #region Public methods

        public void SendMove(int x, int y)
        {
            controller.AcceptMove(this, x, y);
        }

        public void ReceiveUpdate(int x, int y, FieldCellState newState, PlayerController victim)
        {
            // плохо, возможно стоит избежать создания нового объекта путем исправления структуры на класс
            if (this != victim) enemyField[x, y] = new FieldCell(x, y, newState);
            else myField[x, y] = new FieldCell(x, y, newState);
        }

        #endregion
    }
}
