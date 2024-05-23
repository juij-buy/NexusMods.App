﻿using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace NexusMods.App.UI.Overlays.MetricsOptIn;

public class MetricsOptInDesignerViewModel : AOverlayViewModel<IMetricsOptInViewModel>, IMetricsOptInViewModel
{
    [Reactive]
    public ICommand Allow { get; set; }

    [Reactive]
    public ICommand Deny { get; set; }

    [Reactive]
    public bool AllowClicked { get; set; }

    [Reactive]
    public bool DenyClicked { get; set; }

    public MetricsOptInDesignerViewModel()
    {
        Allow = ReactiveCommand.Create(() =>
        {
            AllowClicked = true;
            Close();
        });
        Deny = ReactiveCommand.Create(() =>
        {
            DenyClicked = true;
            Close();
        });
    }
    public bool MaybeShow()
    {
        throw new NotImplementedException();
    }
}
