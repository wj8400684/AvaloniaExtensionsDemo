using System;
using System.Globalization;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Markup.Xaml;

namespace AvaloniaSwitch.Extensions;

public abstract class MarkupValueCvt<T> : MarkupExtension, IValueConverter where T : MarkupValueCvt<T>, new()
{
    public abstract object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture);

    public virtual object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return BindingOperations.DoNothing;
    }
    
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        var t= new T();
        Configure(t);
        return t;
    }

    protected virtual void Configure(T t)
    {
        
    }
}