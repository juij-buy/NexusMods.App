using System.Reactive;
using NexusMods.Abstractions.UI;
using NexusMods.App.UI.Controls.Navigation;
using NexusMods.Icons;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace NexusMods.App.UI.LeftMenu.Items;

public class LeftMenuItemDesignViewModel : AViewModel<INewLeftMenuItemViewModel>, INewLeftMenuItemViewModel
{
    [Reactive] public string Text { get; set; } = "Design Item";
    [Reactive] public IconValue Icon { get; set; } = IconValues.Settings;
    public ReactiveCommand<NavigationInformation, Unit> NavigateCommand { get; } = 
        ReactiveCommand.Create<NavigationInformation>((info) => { });
    public bool IsActive { get; } = false;
    public bool IsSelected { get; } = false;
}