namespace SeaBattle
{
    public class SampleDataContext
    {
        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Game;

        public int MaxShipWidth { get; set; } = 120;

        public int CellSize { get; set; } = 30;

    }
}
