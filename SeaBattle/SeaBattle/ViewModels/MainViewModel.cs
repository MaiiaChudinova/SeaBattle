using DevExpress.Mvvm;
using SeaBattle.Models;
using SeaBattle.Services;
using SeaBattle.Views.Pages;
using System.Windows.Controls;

namespace SeaBattle.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly PageService _pageService;

        public Page CurrentPage { get; set; }

        public MainViewModel(PageService pageService)
        {
            _pageService = pageService;
            _pageService.OnPageChanged += (page) => CurrentPage = page;
            _pageService.ChangePage(new LoginPage());
        }
    }
}
