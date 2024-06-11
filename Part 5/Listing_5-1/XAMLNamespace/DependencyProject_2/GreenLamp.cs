using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;
using System;

namespace DependencyProject_2
{
    public class GreenLamp : Border, IStyleable
    {
        Type IStyleable.StyleKey => typeof(Border);

        public GreenLamp()
        {
            Background = new SolidColorBrush(Colors.Green);
            BorderBrush = new SolidColorBrush(Colors.Black);
            BorderThickness = new Avalonia.Thickness(1);
            CornerRadius = new Avalonia.CornerRadius(4);
            Width = 100;
            Height = 40;
        }
    }
}
