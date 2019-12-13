namespace SeaBattle
{
    /// <summary>
    /// An enum respresenting field cell's state (for a concrete player)
    /// </summary>
    public enum FieldCellType
    {
        /// <summary>
        /// A point player knows nothing about
        /// </summary>
        Uncheked,

        /// <summary>
        /// A point which was NOT hit, but is guaranteed to be free from enemy's ship
        /// </summary>
        CheckedNotHit,

        /// <summary>
        /// A point which was hit by a player, but did not contain enemy's ship
        /// </summary>
        HitMissed,

        /// <summary>
        /// A point which was hit by a player and contained enemy's ship that was still alive
        /// </summary>
        HitShot,
        
        /// <summary>
        /// A point which was hit by a player and now contains killed enemy's ship
        /// </summary>
        HitKilled
    }
}
