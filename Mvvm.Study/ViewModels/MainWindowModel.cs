using System.Windows.Controls;
using System.Windows.Input;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Mvvm.Study.ViewModels;

public partial class MainWindowModel : ObservableObject
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(ClickCommand))]
    string title = string.Empty;

    bool CanExe() => !string.IsNullOrWhiteSpace(Title);

    [RelayCommand(CanExecute = nameof(CanExe))]
    void Click()
    {

    }

    [RelayCommand]
    async Task DelayClick()
    {
        await Task.Delay(2000);
    }

    [RelayCommand]
    async Task HoverClick()
    {
        await Task.Delay(2000);
    }

    [ObservableProperty]
    string postionString = string.Empty;

    [RelayCommand]
    void MouseMove(MouseEventArgs e)
    {
        var postion = e.GetPosition(e.Source as Button);
        PostionString = $"X:{postion.X:F2},Y:{postion.Y:F2}";
    }
}
