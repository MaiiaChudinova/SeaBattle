namespace SeaBattle
{
    /// <summary>
    /// A class representing a ship
    /// </summary>
    public class Ship
    {
        #region Private fields

        private ShipType type;
        private int lives;

        #endregion

        #region Constructors

        public Ship(ShipType type)
        {
            this.type = type;
            lives = (int)type;
        }

        #endregion

        #region Public properties
        public ShipType Type { get => type; }

        public bool IsAlive { get => lives != 0; }

        public bool IsDamaged { get => lives != (int)type && lives != 0; }

        public int Size { get => (int)type; }

        #endregion

        #region Public methods

        public void TakeShot() => --lives;

        #endregion

    }
}
