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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        private static readonly Random getRandom = new Random();
        public double clicksCount { get; set; } = 0;
        public double actualMultiplier { get; set; } = 1;
        public double actualScore { get; set; } = 0;

        public GamePage()
        {
            this.InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clicksCount += 1;
            if (clicksCount % 10 == 0){
                actualMultiplier = Math.Round(getRandom.NextDouble(), 2);
            }
            actualScore += Math.Round(actualScore * actualMultiplier + clicksCount, 0);
            cClicks.Text = clicksCount.ToString();
            cMultipler.Text = actualMultiplier.ToString();
            cScore.Text = actualScore.ToString();
        }
    }
}
