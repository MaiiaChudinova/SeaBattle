namespace SeaBattle
{
    /// <summary>
    /// An enum respresenting field cell's state (for a concrete player)
    /// </summary>
    public enum FieldCellState
    {
        /// <summary>
        /// A point player knows nothing about
        /// Mark that every cell enemy sees unchecked is displayed the same to us 
        /// unless it has a ship in it (then the cell has state <see cref="Undamaged"/>)
        /// </summary>
        Uncheked,

        /// <summary>
        /// A point which is guaranteed to be free from ship
        /// </summary>
        Empty, 

        /// <summary>
        /// A point which was hit by a player and contained ship that was still alive
        /// </summary>
        HitShot,
        
        /// <summary>
        /// A point which was hit by a player and now contains killed ship
        /// </summary>
        HitKilled,

        /// <summary>
        /// A point which contains allied ship that has not been hit yet
        /// </summary>
        Undamaged
    }
}
