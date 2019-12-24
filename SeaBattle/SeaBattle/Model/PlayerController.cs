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

        #region Constructor

        protected PlayerController(InteractionController controller, ShipDistribution myShip)
        {
            myField = new Field();
            enemyField = new Field();
            this.controller = controller;
            myShip = new ShipDistribution();
        }

        #endregion

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



        // OMG CODE SO UGLY...
        public void PlaceShip(int x, int y, bool alignHorizontally, Ship ship, ShipDistribution myShip)
        {
            if (alignHorizontally)
            {
                for (int j = 0; j < ship.Size; ++j)
                    myShip[x, y + j] = ship;
            }
            else
            {
                for (int i = 0; i < ship.Size; ++i)
                    myShip[x + i, y] = ship;
            }
        }

        #endregion
    }
}
