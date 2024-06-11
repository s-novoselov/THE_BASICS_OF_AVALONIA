using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SimpleDataGrid
{
    public partial class MainWindow : Window
    {
        public People ThePeople { get; } = new People();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
