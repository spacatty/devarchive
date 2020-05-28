using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Cryptography.Certificates;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AboutPage : Page
    {
        public int backsCount { get; set; } = 0;
        public int entersCount { get; set; } = 0;
        public AboutPage()
        {
            this.InitializeComponent();
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void inputBox_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            revBlock.Text = Reverse(sender.Text);
        }

        private void inputBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                entersCount++;
                logBlockEnters.Text = entersCount.ToString();
            } else if (e.Key == Windows.System.VirtualKey.Back)
            {
                backsCount++;
                logBlockBacks.Text = backsCount.ToString();
            }
        }
    }
}
