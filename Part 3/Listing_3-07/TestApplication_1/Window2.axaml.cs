using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TestApplication_1
{
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
