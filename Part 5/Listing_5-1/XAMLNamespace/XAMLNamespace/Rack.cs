using Avalonia.Controls.Shapes;
using Avalonia.Media;
using Avalonia.Styling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLNamespace
{
    class Rack : Path, IStyleable
    {
        Type IStyleable.StyleKey => typeof(Path);

        public Rack()
        {
            Data = StreamGeometry.Parse("M30 300C24.4772 300 20 295.52284 20 290C20 " +
                "284.4771600000001 24.4772 280 30 280H120V60C120 48.954 128.9544 40 " +
                "140 40H160C171.0456 40 180 48.954 180 60V280H270C275.522 280 280 " +
                "284.4771600000001 280 290C280 295.52284 275.522 300 270 300H180H120H30z");
            Stretch = Stretch.Fill;
            Height = 100;
            Width = 120;
            Stroke = new SolidColorBrush(Colors.Black);
            StrokeThickness = 1;
            Fill = new SolidColorBrush(Colors.Gray);
        }
    }
}
