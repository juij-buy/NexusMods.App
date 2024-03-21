using System.Collections.ObjectModel;
using NexusMods.Abstractions.Loadouts;
using NexusMods.App.UI.Controls.Diagnostics;
using NexusMods.App.UI.WorkspaceSystem;

namespace NexusMods.App.UI.Pages.Diagnostics;

public interface IDiagnosticListViewModel : IPageViewModelInterface
{
    public LoadoutId LoadoutId { get; set; }

    public ReadOnlyObservableCollection<IDiagnosticEntryViewModel> DiagnosticEntries { get; }
}