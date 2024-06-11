using Avalonia;
using Avalonia.Controls;
using System;

namespace StyleProperty
{
    public partial class MainWindow : Window
    {
        // to stop change notification dispose of this subscription token
        private IDisposable _changeNotificationSubscriptionToken;

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            //subscribe
            _changeNotificationSubscriptionToken =
                   ButtonHeightProperty
                       .Changed
                       .Subscribe(OnButtonHeightChanged);
        }

        private void OnButtonHeightChanged(AvaloniaPropertyChangedEventArgs<double> changeParams)
        {
            // if the object on which this Style property changes
            // is not this very window, do not do anything
            if (changeParams.Sender != this)
            {
                return;
            }

            // check the old and new values of the Style property. 
            double oldValue = changeParams.OldValue.Value;

            double newValue = changeParams.NewValue.Value;
        }

        public double ButtonHeight
        {
            // getter 
            get { return GetValue(ButtonHeightProperty); }

            // setter
            set { SetValue(ButtonHeightProperty, value); }
        }

        public static readonly StyledProperty<double> ButtonHeightProperty =
        AvaloniaProperty.Register<MainWindow, double>
        (
            nameof(ButtonHeight)
        );
    }
}
