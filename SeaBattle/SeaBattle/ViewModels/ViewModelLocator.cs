using Microsoft.Extensions.DependencyInjection;
using SeaBattle.Services;
using SeaBattle.ViewModels.Pages;

namespace SeaBattle.ViewModels
{
    public class ViewModelLocator
    {
        private static ServiceProvider _provider;

        public MainViewModel MainViewModel => _provider.GetRequiredService<MainViewModel>();

        public LoginPageViewModel LoginPageViewModel => _provider.GetRequiredService<LoginPageViewModel>();

        public WelcomePageViewModel WelcomePageViewModel => _provider.GetRequiredService<WelcomePageViewModel>();

        public static void InitializeLocator()
        {
            var services = new ServiceCollection();

            services.AddTransient<MainViewModel>();
            services.AddTransient<LoginPageViewModel>();  // might be opposite to the next
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