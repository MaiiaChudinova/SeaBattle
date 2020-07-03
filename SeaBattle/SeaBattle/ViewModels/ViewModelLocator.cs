using Microsoft.Extensions.DependencyInjection;
using SeaBattle.Services.Events;
using SeaBattle.Services.Messages;
using SeaBattle.Services.Paging;
using SeaBattle.ViewModels.Pages;

namespace SeaBattle.ViewModels
{
    public class ViewModelLocator
    {
        private static ServiceProvider _provider;

        public MainViewModel MainViewModel => _provider.GetRequiredService<MainViewModel>();

        public LoginPageViewModel LoginPageViewModel => _provider.GetRequiredService<LoginPageViewModel>();

        public WelcomePageViewModel WelcomePageViewModel => _provider.GetRequiredService<WelcomePageViewModel>();

        public ShipAllocationPageViewModel ShipAllocationPageViewModel => _provider.GetRequiredService<ShipAllocationPageViewModel>();

        public FieldViewModel FieldViewModel => _provider.GetRequiredService<FieldViewModel>();

        public FieldRowViewModel FieldRowViewModel => _provider.GetRequiredService<FieldRowViewModel>();

        public static void InitializeLocator()
        {
            var services = new ServiceCollection();

            // Register DI
            services.AddTransient<MainViewModel>();
            services.AddTransient<LoginPageViewModel>();
            services.AddTransient<ShipAllocationPageViewModel>();
            services.AddTransient<FieldRowViewModel>();
            services.AddTransient<FieldViewModel>();
            services.AddScoped<WelcomePageViewModel>();

            services.AddSingleton<PageService>();
            services.AddSingleton<EventBusService>();
            services.AddSingleton<MessageBusService>();

            _provider = services.BuildServiceProvider();

            foreach (var item in services)
            {
                _provider.GetRequiredService(item.ServiceType);
            }
        }
    }
}