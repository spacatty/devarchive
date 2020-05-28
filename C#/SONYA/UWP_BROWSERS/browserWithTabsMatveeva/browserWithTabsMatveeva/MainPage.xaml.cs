using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace browserWithTabsMatveeva
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TabView_AddTabButtonClick_1(Microsoft.UI.Xaml.Controls.TabView sender, object args)
        {
            var newTab = new Microsoft.UI.Xaml.Controls.TabViewItem();
            newTab.IconSource = new Microsoft.UI.Xaml.Controls.SymbolIconSource() { Symbol = Symbol.Document };
            newTab.Header = "Blank Page";
            Frame frame = new Frame();
            newTab.Content = frame;
            frame.Navigate(typeof(BlankPage1), newTab);

            sender.TabItems.Add(newTab);
        }

        private void TabView_TabCloseRequested(Microsoft.UI.Xaml.Controls.TabView sender, Microsoft.UI.Xaml.Controls.TabViewTabCloseRequestedEventArgs args)
        {
            if (sender.TabItems.Count() > 1) { sender.TabItems.Remove(args.Tab); }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var newTab = new Microsoft.UI.Xaml.Controls.TabViewItem();
            newTab.IconSource = new Microsoft.UI.Xaml.Controls.SymbolIconSource() { Symbol = Symbol.Document };
            newTab.Header = "Blank Page";
            Frame frame = new Frame();
            newTab.Content = frame;
            frame.Navigate(typeof(BlankPage1), newTab);
            tabView.TabItems.Add(newTab);
        }
    }
}
