using DevExpress.Mvvm;
using SeaBattle.Models;

namespace SeaBattle.ViewModels
{
    public class FieldViewModel : BindableBase
    {
        public const int FieldSize = 10;
        private FieldCellState[,] field = new FieldCellState[FieldSize, FieldSize];

    }
}
