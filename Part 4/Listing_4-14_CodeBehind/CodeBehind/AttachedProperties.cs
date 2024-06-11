using Avalonia;
using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBehind
{
    public static class AttachedProperties
    {
        #region CornerRadius Attached Avalonia Property

        // Attached Property Getter
        public static double GetCornerRadius(AvaloniaObject obj)
        {
            return obj.GetValue(CornerRadiusProperty);
        }

        // Attached Property Setter
        public static void SetCornerRadius(AvaloniaObject obj, double value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }

        // Static field that of AttachedProperty<double> type. This field contains the
        // Attached Propertie's hashtable, the default value and the rest of the required 
        // functionality
        public static readonly AttachedProperty<double> CornerRadiusProperty =
            AvaloniaProperty.RegisterAttached<object, Control, double>
            (
                "CornerRadius", // property name
                15 // property default value
            );

        #endregion CornerRadius Attached Avalonia Property
    }

}
