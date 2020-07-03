using DevExpress.Mvvm;
using SeaBattle.Models;
using SeaBattle.Services.Events;
using SeaBattle.Services.Messages;
using SeaBattle.Services.Paging;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SeaBattle.ViewModels.Pages
{
    public class WelcomePageViewModel : BindableBase
    {
        private readonly PageService _pageService;
        private readonly EventBusService _eventBus;
        private readonly MessageBusService _messageBus;

        public UserModel CurrentUser { get; set; }

        public WelcomePageViewModel(PageService pageService, EventBusService eventBus, MessageBusService messageBus)
        {
            _pageService = pageService;
            _eventBus = eventBus;
            _messageBus = messageBus;

            _eventBus.Subscribe<SuccessfulLoginEvent>(async @event => Debug.WriteLine($"User has successfully logged in"));

            _messageBus.Receive<LoginInfoMessage>(this, async message =>
            {
                CurrentUser = message.User;
            });
        }

        public ICommand LogoutCommand => new DelegateCommand(() =>
        {
            _pageService.ChangePage(PageType.Login);
        });

        public ICommand PlayCommand => new DelegateCommand(() =>
        {
            _pageService.ChangePage(PageType.ShipAllocation);
        });
    }
}
