using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyProject_1.SubFolder
{
    public class BlueLamp : Border, IStyleable
    {
        Type IStyleable.StyleKey => typeof(Border);

        public BlueLamp()
        {
            Background = new SolidColorBrush(Colors.Blue);
            BorderBrush = new SolidColorBrush(Colors.Black);
            BorderThickness = new Avalonia.Thickness(1);
            CornerRadius = new Avalonia.CornerRadius(4);
            Width = 100;
            Height = 40;
        }

    }
}
