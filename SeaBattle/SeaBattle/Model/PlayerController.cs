namespace SeaBattle
{
    /// <summary>
    /// A class defining basic structure of player (human/AI) game-controller
    /// </summary>
    public abstract class PlayerController
    {
        protected Field myField;
        protected Field enemyField;

        #region Abstract methods

        /// <summary>
        /// Player should make a move based on his/her view of enemy's field
        /// </summary>
        /// <returns> Tuple of coordinates to shoot on enemy's field </returns>
        public abstract (int x, int y) makeMove();

        #endregion

        #region Protected methods

        protected bool HitMakesSense(int x, int y) => enemyField[x, y].state == FieldCellState.Uncheked;

        #endregion

        #region Public methods

        public bool IsCellShot(int x, int y) => myField[x, y].state == FieldCellState.Undamaged;


        public void TakeHit(int x, int y)
        {
            
        }

        #endregion
    }
}
