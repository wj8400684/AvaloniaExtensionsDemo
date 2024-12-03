using System;
using System.Globalization;

namespace AvaloniaSwitch.Extensions;

public class BoolDisplayCvt : MarkupValueCvt<BoolDisplayCvt>
{
    public object? True { get; set; }

    public object? False { get; set; }
    
    public override object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool b)
            return b ? True : False;
        
        return value;
    }

    protected override void Configure(BoolDisplayCvt t)
    {
        t.True = True;
        t.False = False;
    }
}