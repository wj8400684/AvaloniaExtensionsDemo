using System;
using Avalonia.Markup.Xaml;

namespace AvaloniaSwitch.Extensions.String;

public class IsNullOrWhiteSpaceExtension : MarkupExtension
{
    public object? True { get; set; }

    public object? False { get; set; }
    
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return new IsNullOrWhiteSpaceDisplayCvt
        {
            True = True,
            False = False
        };
    }
}