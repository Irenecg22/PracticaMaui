using LiveChartsCore.SkiaSharpView.Maui;
using MauiPractica.Services;
using MauiPractica.View;
using MauiPractica.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiPractica
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()       // solo UNA vez
                .UseLiveCharts()         // inicialización correcta de LiveCharts
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<EmpleadoService>();
            builder.Services.AddTransient<DepartamentoService>();
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<MainView>();
            builder.Services.AddTransient<DepartamentoViewModel>();
            builder.Services.AddTransient<DepartamentoView>();
       

            builder.Services.AddTransient<DepartamentoDetalleView>();
            builder.Services.AddTransient<DepartamentoDetalleViewModel>();
            builder.Services.AddTransient<DepartamentoDetalleViewModel>();
            builder.Services.AddTransient<MainDetalleView>();
            builder.Services.AddTransient<MainDetalleViewModel>();
            builder.Services.AddTransient<SettingsViewModel>();
            builder.Services.AddTransient<SettingsView>();



            return builder.Build();
        }
    }
}
