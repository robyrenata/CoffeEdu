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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CoffeEdu
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            CD_Frame.Navigate(typeof(Home));
            TitleTextBlock.Text = "Home";

            BackButton.Visibility = Visibility.Collapsed;
            Home.IsSelected = true;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            CD_SplitView.IsPaneOpen = !CD_SplitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Home.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                CD_Frame.Navigate(typeof(Home));
                TitleTextBlock.Text = "Home";
            }
            else if (Coffee.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                CD_Frame.Navigate(typeof(Coffee));
                TitleTextBlock.Text = "Coffee";
            }
            else if (About.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                CD_Frame.Navigate(typeof(About));
                TitleTextBlock.Text = "About Dev";
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (CD_Frame.CanGoBack)
            {
                CD_Frame.GoBack();
                Home.IsSelected = true;
            }
        }
    }
}
