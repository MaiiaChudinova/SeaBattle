using DevExpress.Mvvm;
using SeaBattle.Models;
using System.Diagnostics;
using System.Windows.Input;

namespace SeaBattle.ViewModels
{
    public class FieldRowViewModel : BindableBase
    {
        public FieldCellState[] CellStates { get; set; } = new FieldCellState[FieldViewModel.FieldSize];

        public FieldCellState Item { get; set; }

        /*
        public ICommand ChangeStateCommand => new DelegateCommand<string>((index) =>
        {
            FieldCellState cell = CellStates[int.Parse(index)];

            if (cell == FieldCellState.Known)
                cell = FieldCellState.Unknown;

            if (cell == FieldCellState.Unknown)
                cell = FieldCellState.Known;

            Debug.WriteLine("Lalalal");
        });
        */
        public ICommand ChangeStateCommand => new DelegateCommand(() =>
        {
            if (Item == FieldCellState.Known)
                Item = FieldCellState.Unknown;

            else if (Item == FieldCellState.Unknown)
                Item = FieldCellState.Known;

            Debug.WriteLine("Lalalal");
        });
    }
}
