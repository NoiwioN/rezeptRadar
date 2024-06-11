using Microsoft.Extensions.Logging;

namespace RezeptRadar
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
                    fonts.AddFont("TAHOMA.TTF", "TahomaRegular");
                    fonts.AddFont("TAHOMABD.TTF", "TahomaBold");
                    fonts.AddFont("ELEPHNTI.TTF", "ElephantCursive");
                    fonts.AddFont("ELEPHNT.TTF", "ElephantRegular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
