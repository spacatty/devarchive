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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace uwpBrowserPrototypeMetveeva
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            browserSelf.Refresh();
        }
        private void urlBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter && urlBox.Text != null)
            {
                Uri webURL = new Uri(urlBox.Text); browserSelf.Navigate(webURL);
            }

        }

        private void browserSelf_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            if (browserSelf.CanGoBack)
            {
                goBack.IsEnabled = true;
            }
            else
            {
                goBack.IsEnabled = false;
            }
            if (browserSelf.CanGoForward)
            {
                goForward.IsEnabled = true;
            }
            else
            {
                goForward.IsEnabled = false;
            }
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            browserSelf.GoBack();
        }

        private void goForward_Click(object sender, RoutedEventArgs e)
        {
            browserSelf.GoForward();
        }
    }
}
