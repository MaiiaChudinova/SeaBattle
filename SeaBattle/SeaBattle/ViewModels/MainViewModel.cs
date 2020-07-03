using DevExpress.Mvvm;
using SeaBattle.Models;
using SeaBattle.Services.Paging;

namespace SeaBattle.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly PageService _pageService;

        public PageType CurrentPage { get; set; }

        public MainViewModel(PageService pageService)
        {
            _pageService = pageService;
            _pageService.OnPageChanged += (page) => CurrentPage = page;
            _pageService.ChangePage(PageType.Login);
        }
    }
}
