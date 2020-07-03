using DevExpress.Mvvm;
using SeaBattle.Models;
using SeaBattle.Services.Events;
using SeaBattle.Services.Messages;
using SeaBattle.Services.Paging;
using System.Windows.Input;

namespace SeaBattle.ViewModels.Pages
{
    public class LoginPageViewModel : BindableBase
    {
        private readonly PageService _pageService;
        private readonly EventBusService _eventBus;
        private readonly MessageBusService _messageBus;

        public string CurrentUserName { get; set; }

        public LoginPageViewModel(PageService pageService, EventBusService eventBus, MessageBusService messageBus)
        {
            _pageService = pageService;
            _eventBus = eventBus;
            _messageBus = messageBus;
        }

        public ICommand LoginCommand => new AsyncCommand(async () =>
        {
            _pageService.ChangePage(PageType.Welcome);

            await _messageBus.SendTo<WelcomePageViewModel>(new LoginInfoMessage() { User = new UserModel() { Name = CurrentUserName } });
            await _eventBus.Publish(new SuccessfulLoginEvent());
        });
    }
}
