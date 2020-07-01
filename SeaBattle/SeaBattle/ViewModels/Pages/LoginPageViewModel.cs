using DevExpress.Mvvm;
using SeaBattle.Services;
using SeaBattle.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SeaBattle.ViewModels.Pages
{
    public class LoginPageViewModel : BindableBase
    {
        private readonly PageService _pageService;
        private readonly EventBusService _eventBus;
        private readonly MessageBusService _messageBus;

        public string LogText { get; set; }

        public LoginPageViewModel(PageService pageService, EventBusService eventBus, MessageBusService messageBus)
        {
            _pageService = pageService;
            _eventBus = eventBus;
            _messageBus = messageBus;
        }

        public ICommand ChangePage => new AsyncCommand(async () =>
        {
            _pageService.ChangePage(new WelcomePage());

            await _eventBus.Publish(new LeaveFromLoginPageEvent());
        });

        public ICommand SendLog => new AsyncCommand(async () =>
        {
            await _messageBus.SendTo<LoginPageViewModel>(new TextMessage(LogText));
        });
    }
}
