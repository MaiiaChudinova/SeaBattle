using SeaBattle.Models;
using System;
using System.Windows.Controls;

namespace SeaBattle.Services.Paging
{
    public class PageService
    {
        public event Action<PageType> OnPageChanged;

        public void ChangePage(PageType pageType) => OnPageChanged?.Invoke(pageType);
    }
}
