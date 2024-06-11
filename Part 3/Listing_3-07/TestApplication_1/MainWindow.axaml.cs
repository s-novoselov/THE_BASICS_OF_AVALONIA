using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TestApplication_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var openWindowButton = this.FindControl<Button>("OpenWindowButton");
            openWindowButton.Click += OpenWindowButton_Click;

            var openModalWindowButton = this.FindControl<Button>("OpenModalWindowButton");
            openModalWindowButton.Click += OpenModalWindowButton_Click;
        }

        private void OpenWindowButton_Click(object? sender, RoutedEventArgs e)
        {
            // Create the window object
            Window sampleWindow = new Window2();
            sampleWindow.Width = 300;
            sampleWindow.Height = 250;

            // open the window
            sampleWindow.Show();
        }

        private void OpenModalWindowButton_Click(object? sender, RoutedEventArgs e)
        {
            // Create the window object
            Window sampleWindow = new Window2();
            sampleWindow.Width = 300;
            sampleWindow.Height = 250;

            // open the window
            sampleWindow.ShowDialog(this);
        }

    }
}
