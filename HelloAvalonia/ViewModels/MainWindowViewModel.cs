using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HelloAvalonia.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty, NotifyPropertyChangedFor(nameof(PlayAnimation))]
    private int _count;

    [ObservableProperty]
    private bool _isEnabled = true;

    [ObservableProperty] private string _text = "Click Me";
    public bool PlayAnimation => Count > 0 && Count % 2 == 0;

    [RelayCommand]
    private void Click()
    {
        Count++;
        Text = Count == 1
            ? $"Clicked {Count} time"
            : $"Clicked {Count} times";
    } 

    [RelayCommand]
    private void ShowDialog(Action? showDialogInteraction)
    {
        showDialogInteraction?.Invoke();
    }
}