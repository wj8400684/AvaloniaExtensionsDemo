using System;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Markup.Xaml;

namespace AvaloniaSwitch.Extensions;

public class AndExtension: MarkupExtension
{
    public IBinding? Left { get; set; }

    public IBinding? Right { get; set; }
    
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return new MultiBinding
        {
            Converter = BoolConverters.And,
            Bindings = [Left, Right]
        };
    }
}