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
        public FieldCellType state;

        #region Constructors
        public FieldCell(int x, int y, FieldCellType state)
        {
            this.x = x;
            this.y = y;
            this.state = state;
        }

        /// <summary>
        /// Constructor used "by default" (when initializing)
        /// </summary>
        /// <param name="x">Horizontal coordinate (starting from left)</param>
        /// <param name="y">Vertical coordinate (starting from top)</param>
        public FieldCell(int x, int y) : this(x, y, FieldCellType.Uncheked) { }

        #endregion
    }
}
