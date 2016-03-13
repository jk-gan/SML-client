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

namespace HelloUWP2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainNav : Page
    {
        public MainNav()
        {
            this.InitializeComponent();
            myFrame.Navigate(typeof(PoliceStressSignal));
            titleTextBlock.Text = "Police";
            backBtn.Visibility = Visibility.Collapsed;
            police.IsSelected = true;
        }

        private void hamburgerBtn_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
            homeTextBlock.Visibility = Visibility.Visible;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            myFrame.GoBack();
            police.IsSelected = true;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (police.IsSelected)
            {
                myFrame.Navigate(typeof(PoliceStressSignal));
                titleTextBlock.Text = "Police";
                backBtn.Visibility = Visibility.Collapsed;
            }
            else 
            {
                backBtn.Visibility = Visibility.Visible;
            }
        }
    }
}
