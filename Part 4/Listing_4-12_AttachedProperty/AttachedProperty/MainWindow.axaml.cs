using Avalonia;
using Avalonia.Controls;
using System;

namespace AttachedProperty
{
    public partial class MainWindow : Window
    {
        // to stop change notification dispose of this subscription token
        private IDisposable _changeNotificationSubscriptionToken;

        public MainWindow()
        {
            InitializeComponent();

            // subscribe
            _changeNotificationSubscriptionToken = 
                AttachedProperties
                    .ButtonHeightProperty
                    .Changed
                    .Subscribe(OnButtonHeightChanged);
        }

        // this method is called when the Attached property changes
        private void OnButtonHeightChanged(AvaloniaPropertyChangedEventArgs<double> changeParams)
        {
            // if the object on which this attached property changes
            // is not this very window, do not do anything
            if (changeParams.Sender != this)
            {
                return;
            }

            // check the old and new values of the attached property. 
            double oldValue = changeParams.OldValue.Value;
            double newValue = changeParams.NewValue.Value;
        }


    }
}
