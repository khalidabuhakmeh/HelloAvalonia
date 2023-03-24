using Avalonia;
using System;
using Avalonia.Controls;
using Avalonia.Svg.Skia;
using Avalonia.Xaml.Interactivity;
using HelloAvalonia.ViewModels;
using Lamar;

namespace HelloAvalonia;

class Program
{
    public static IContainer Container { get; }

    static Program()
    {
        Container = new Container(cfg =>
        {
            cfg.Scan(scan =>
            {
                scan.AssemblyContainingType<Program>();
                scan.AddAllTypesOf<ViewModelBase>();
                scan.AddAllTypesOf<IControl>();
                scan.WithDefaultConventions();
            });
        });
    }
        
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    private static AppBuilder BuildAvaloniaApp()
    {
        GC.KeepAlive(typeof(SvgImageExtension).Assembly);
        GC.KeepAlive(typeof(Avalonia.Svg.Skia.Svg).Assembly);
        GC.KeepAlive(typeof(Interaction));
            
        return AppBuilder
            .Configure<App>()
            .UsePlatformDetect()
            .LogToTrace();
    }
}