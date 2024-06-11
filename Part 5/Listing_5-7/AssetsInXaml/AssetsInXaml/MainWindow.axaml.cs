using Avalonia;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;

namespace AssetsInXaml
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // get the asset loader from Avalonia container
            var assetLoader = AvaloniaLocator.Current.GetService<IAssetLoader>();

            // get the Image control from XAML
            Image Image1 = this.FindControl<Image>("Image1");

            // set the image Source using assetLoader
            Image1.Source =
                new Bitmap
                (
                    assetLoader?.Open(
                        new Uri("avares://AssetsInXaml/Assets/RobotArm.png")));

            // get the Image control from XAML
            Image Image2 = this.FindControl<Image>("Image2");

            // set the image Source using assetLoader
            Image2.Source =
                new Bitmap
                (
                    assetLoader?.Open(
                        new Uri("avares://DependencyProject/Assets/Chip.png")));
        }
    }
}
