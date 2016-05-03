using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CoffeEdu
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Coffee : Page
    {
        public Coffee()
        {
            this.InitializeComponent();
        }

        private void ButtonArabica_Click(object sender, RoutedEventArgs e)
        {
            ContentArabica.Visibility = Visibility.Visible;
            ContentRobusta.Visibility = Visibility.Collapsed;
            ContentLuwak.Visibility = Visibility.Collapsed;
        }

        private void ButtonRobusta_Click(object sender, RoutedEventArgs e)
        {
            ContentRobusta.Visibility = Visibility.Visible;
            ContentArabica.Visibility = Visibility.Collapsed;
            ContentLuwak.Visibility = Visibility.Collapsed;
        }

        private void ButtonLuwak_Click(object sender, RoutedEventArgs e)
        {
            ContentLuwak.Visibility = Visibility.Visible;
            ContentRobusta.Visibility = Visibility.Collapsed;
            ContentArabica.Visibility = Visibility.Collapsed;
        }
    }
}
