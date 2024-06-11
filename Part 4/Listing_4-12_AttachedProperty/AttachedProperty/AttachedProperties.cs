using Avalonia;
using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttachedProperty
{
    public static class AttachedProperties
    {
        #region ButtonHeight Attached Avalonia Property

        // Attached Property Getter
        public static double GetButtonHeight(AvaloniaObject obj)
        {
            return obj.GetValue(ButtonHeightProperty);
        }

        // Attached Property Setter
        public static void SetButtonHeight(AvaloniaObject obj, double value)
        {
            obj.SetValue(ButtonHeightProperty, value);
        }

        // Static field that of AttachedProperty<double> type. This field contains the
        // Attached Propertie's hashtable, the default value and the rest of the required 
        // functionality
        public static readonly AttachedProperty<double> ButtonHeightProperty =
            AvaloniaProperty.RegisterAttached<object, Control, double>
            (
                "ButtonHeight", // property name
                100 // property default value
            );

        #endregion ButtonHeight Attached Avalonia Property
    }
}
