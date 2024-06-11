using Avalonia.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRoutedEvent
{
    public static class StaticRoutedEvents
    {
        /// <summary>
        /// create the MyCustomRoutedEvent
        /// </summary>
        public static readonly RoutedEvent<RoutedEventArgs> MyCustomRoutedEvent =
            RoutedEvent.Register<object, RoutedEventArgs>
            (
                "MyCustomRouted",
                RoutingStrategies.Tunnel | RoutingStrategies.Bubble
            );
    }
}
