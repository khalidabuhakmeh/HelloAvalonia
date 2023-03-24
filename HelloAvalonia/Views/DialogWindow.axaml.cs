using System;
using HelloAvalonia.ViewModels;

namespace HelloAvalonia.Views;

public partial class DialogWindow : WindowBase<DialogWindowViewModel>
{
    public DialogWindow()
    {
        InitializeComponent();
    }
    
    public Action HideInteraction => Hide;
}