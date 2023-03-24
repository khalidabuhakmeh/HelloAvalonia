using System;
using HelloAvalonia.ViewModels;
using Lamar;

namespace HelloAvalonia.Views;

public partial class MainWindow : WindowBase<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
    }
        
    [SetterProperty]
    public DialogWindow? Dialog { get; set; }

    public Action ShowDialogInteraction => 
        () => Dialog?.ShowDialog(this);
}