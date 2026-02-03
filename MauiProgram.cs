using BrewNotes.ViewModels;
using BrewNotes.Views;
using Microsoft.Extensions.Logging;

namespace BrewNotes
{
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            //ViewModels
            builder.Services.AddSingleton<BeanBankViewModel>();
            builder.Services.AddSingleton<AddBeansViewModel>();

            //Shell 
            Routing.RegisterRoute(nameof(AddBeansView), typeof(AddBeansView));
            return builder.Build();
        }
    }
}
