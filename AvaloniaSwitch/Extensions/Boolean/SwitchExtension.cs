using System;
using Avalonia.Markup.Xaml;

namespace AvaloniaSwitch.Extensions;

public sealed class SwitchExtension : MarkupExtension
{
    public object? True { get; set; }

    public object? False { get; set; }
    
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return new BoolDisplayCvt
        {
            True = True,
            False = False
        };
    }
}