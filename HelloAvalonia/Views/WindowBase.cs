using Avalonia.Controls;
using HelloAvalonia.ViewModels;
using Lamar;

namespace HelloAvalonia.Views;

public abstract class WindowBase<T> : Window
    where T: ViewModelBase
{
    [SetterProperty]
    public T ViewModel
    {
        get => (T)DataContext!;
        set => DataContext = value;
    }
}