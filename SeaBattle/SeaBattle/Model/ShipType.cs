namespace SeaBattle
{
    /// <summary>
    /// An enum defining ship type dependently on the number of decks on the ship
    /// </summary>
    
    public enum ShipType
    {
        /// <summary>
        /// a ship with 1 deck
        /// </summary>
        Boat = 1,

        /// <summary>
        /// a ship with 2 decks
        /// </summary>
        Destroyer,

        /// <summary>
        /// a ship with 3 decks
        /// </summary>
        Cruiser,

        /// <summary>
        /// a ship with 4 decks
        /// </summary>
        BattleShip
    }
}
