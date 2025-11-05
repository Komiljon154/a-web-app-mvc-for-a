using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using MusicHub.Wpf.Services;
using MusicHub.Wpf.ViewModels;
using MusicHub.Wpf.Views;

namespace MusicHub.Wpf;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private readonly ServiceProvider _serviceProvider;

    public App()
    {
        var services = new ServiceCollection();
        ConfigureServices(services);
        _serviceProvider = services.BuildServiceProvider();
    }

    private void ConfigureServices(IServiceCollection services)
    {
        services.AddHttpClient<ApiClient>(client =>
        {
            client.BaseAddress = new Uri("https://localhost:7123/api/");
        });

        services.AddSingleton<MainViewModel>();
        services.AddSingleton<ArtistsViewModel>();
        services.AddSingleton<BookingsViewModel>();

        services.AddSingleton<MainWindow>();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        var mainWindow = _serviceProvider.GetService<MainWindow>();
        mainWindow?.Show();
    }
}
