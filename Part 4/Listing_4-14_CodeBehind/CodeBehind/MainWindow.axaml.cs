using Avalonia;
using Avalonia.Controls;
using System;

namespace CodeBehind
{
    public partial class MainWindow : Window
    {
        private IDisposable _changeNotificationSubscriptionToken;

        public MainWindow()
        {
            InitializeComponent();

            //subscribe
            _changeNotificationSubscriptionToken =
                AttachedProperties
                   .CornerRadiusProperty
                   .Changed
                   .Subscribe(OnCornerRadiusChanged);
        }

        private void OnCornerRadiusChanged(AvaloniaPropertyChangedEventArgs<double> changeParams)
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

            //Find control
            Border border = this.FindControl<Border>("ButtonBorder");
            border.CornerRadius = new CornerRadius(newValue);
        }

        public static readonly StyledProperty<double> CornerRadiusProperty =
        AvaloniaProperty.Register<MainWindow, double>
        (
            nameof(CornerRadius)
        );
    }
}
