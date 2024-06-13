using Microsoft.Extensions.Logging;

namespace StudentFinanceApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Jura-VariableFont_wght.ttf","Jura");
                fonts.AddFont("Roboto-Light.ttf","RobotoThin");
                fonts.AddFont("Roboto-Medium.ttf","RobotoMedium");
                fonts.AddFont("Roboto-Thin.ttf","RobotoThin");
                fonts.AddFont("fa-brands-400.ttf", "Icon");


            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}