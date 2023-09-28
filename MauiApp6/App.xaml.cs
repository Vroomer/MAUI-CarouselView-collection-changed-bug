namespace MauiApp6;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

        MainPage = new AppShell();
    }
}
