using System;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HelloAvalonia.Models;
using Lamar;

namespace HelloAvalonia.ViewModels;

public partial class DialogWindowViewModel : ViewModelBase
{
    [SetterProperty] 
    public ICatsImageService? Cats { get; set; }

    [ObservableProperty] private Bitmap? _catImage;

    [RelayCommand]
    private async Task Opened()
    {
        if (Cats is { })
        {
            var bitmap = await Cats.GetRandomImage();
            CatImage = bitmap;
        }
    }

    [RelayCommand]
    private void Hide(Action? interaction)
    {
        CatImage = null;
        interaction?.Invoke();
    }
}