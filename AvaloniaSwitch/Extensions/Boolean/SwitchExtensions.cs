using System;
using Avalonia.Markup.Xaml;
using AvaloniaSwitch.Extensions.Boollean;

namespace AvaloniaSwitch.Extensions.Boolean;

public sealed class SwitchExtensions : MarkupExtension
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