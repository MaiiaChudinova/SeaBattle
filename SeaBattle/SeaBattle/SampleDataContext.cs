using PropertyChanged;
using System.ComponentModel;
using System.Threading.Tasks;

namespace SeaBattle
{
    /// <summary>
    /// This class is anarchy
    /// It contains everything (or almost everything) that all the VM's will contain together
    /// No order in these properties
    /// </summary>
    //[AddINotifyPropertyChangedInterface]
    public class SampleDataContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public SampleDataContext()
        {
            Task.Run(async () =>
            {
                int i = 0;
                while (true)
                {
                    await Task.Delay(200);
                    Test = (i++).ToString();
                }
            });
        }

        public string Test 
        {
            get; set;
        }

        private Player playerModel = new Player();
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Welcome;

        // should be CellSize * MaxShipSize (in cells)
        public int MaxShipWidth { get; set; } = 120;

        public int CellSize { get; set; } = 30;

        public int MinHeight { get; set; } = 500;

        public int MinWidth { get; set; } = 760;

        public string Title { get; set; } = $" Seabattle v{version}";

        private static string version = "1.0";

        public string PlayerName 
        { 
            get { return playerModel.Name; } 
            set { playerModel.Name = value; }
        }
    }
}
