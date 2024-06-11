using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;
using System;

namespace DependencyProject_1
{
    public class RedLamp : Border, IStyleable
    {
        Type IStyleable.StyleKey => typeof(Border);

        public RedLamp()
        {
            Background = new SolidColorBrush(Colors.Red);
            BorderBrush = new SolidColorBrush(Colors.Black);
            BorderThickness = new Avalonia.Thickness(1);
            CornerRadius = new Avalonia.CornerRadius(4);
            Width = 100;
            Height = 40;
        }
    }
}
