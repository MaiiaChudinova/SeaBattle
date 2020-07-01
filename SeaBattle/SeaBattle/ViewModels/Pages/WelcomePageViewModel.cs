using DevExpress.Mvvm;
using SeaBattle.Services;
using SeaBattle.Views.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SeaBattle.ViewModels.Pages
{
    public class WelcomePageViewModel : BindableBase
    {
        private readonly PageService _pageService;
        private readonly EventBusService _eventBus;
        private readonly MessageBusService _messageBus;

        public ObservableCollection<string> Logs { get; set; } = new ObservableCollection<string>();


        public WelcomePageViewModel(PageService pageService, EventBusService eventBus, MessageBusService messageBus)
        {
            _pageService = pageService;
            _eventBus = eventBus;
            _messageBus = messageBus;

            _eventBus.Subscribe<LeaveFromLoginPageEvent>(async @event => Debug.WriteLine($"You left from login page"));

            _messageBus.Receive<TextMessage>(this, async message =>
            {
                await Task.Delay(3000);
                Logs.Add(message.Text);
            });
            _messageBus.Receive<TextMessage>(new object(), async message => Logs.Add(message.Text));
        }

        public ICommand AppendLog => new DelegateCommand(() =>
        {
            Logs.Add(Guid.NewGuid().ToString());
        });

        public ICommand ChangePage => new DelegateCommand(() =>
        {
            _pageService.ChangePage(new LoginPage());
        });
    }
}
