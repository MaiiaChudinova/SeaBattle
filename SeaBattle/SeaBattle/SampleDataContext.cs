namespace SeaBattle
{
    /// <summary>
    /// This class is anarchy
    /// It contains everything (or almost everything) that all the VM's will contain together
    /// No order in these properties
    /// </summary>
    public class SampleDataContext
    {
        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.ShipAllocation;

        // should be CellSize * MaxShipSize (in cells)
        public int MaxShipWidth { get; set; } = 120;

        public int CellSize { get; set; } = 30;

        public int MinHeight { get; set; } = 500;

        public int MinWidth { get; set; } = 760;

        public string Title { get; set; } = $" Seabattle v{version}";

        private static string version = "1.0";
    }
}
