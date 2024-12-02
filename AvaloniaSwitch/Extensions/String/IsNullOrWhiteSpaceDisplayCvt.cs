using System;
using System.Globalization;

namespace AvaloniaSwitch.Extensions.String;

public class IsNullOrWhiteSpaceDisplayCvt : MarkupValueCvt<IsNullOrWhiteSpaceDisplayCvt>
{
    public object? True { get; set; }

    public object? False { get; set; }

    public override object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null)
            return False;

        return string.IsNullOrWhiteSpace(value.ToString()) ? True : False;
    }

    protected override void Configure(IsNullOrWhiteSpaceDisplayCvt t)
    {
        t.True = True;
        t.False = False;
    }
}