namespace SeaBattle
{
    /// <summary>
    /// A struct representing a point on a battlefield.
    /// Constains information about point state.
    /// </summary>
    public struct FieldCell
    {
        /// <summary>
        /// Horizontal coordinate, starting left
        /// </summary>
        public int x;

        /// <summary>
        /// Vertical coordinate, starting top
        /// </summary>
        public int y;

        /// <summary>
        /// Cell's state (from a player's point of view)
        /// </summary>
        public FieldCellState state;

        #region Constructor

        /// <summary>
        /// Constructor used "by default"
        /// </summary>
        /// <param name="x">Horizontal coordinate (starting from left)</param>
        /// <param name="y">Vertical coordinate (starting from top)</param>
        public FieldCell(int x, int y, FieldCellState state = FieldCellState.Uncheked)
        {
            this.x = x;
            this.y = y;
            this.state = state;
        }
        
        #endregion
    }
}
