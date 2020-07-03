using DevExpress.Mvvm;
using SeaBattle.Services.Paging;

namespace SeaBattle.ViewModels.Pages
{
    public class ShipAllocationPageViewModel : BindableBase
    {
        private readonly PageService _pageService;

        public ShipAllocationPageViewModel(PageService pageService)
        {
            _pageService = pageService;
        }
    }
}
