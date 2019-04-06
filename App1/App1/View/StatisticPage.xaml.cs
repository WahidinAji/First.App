using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatisticPage : ContentPage
    {
        public StatisticPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var entries = new[]
             {
                 new Microcharts.Entry(15)
                 {
                     Label = "UWP",
                     ValueLabel = "20",
                     Color = SKColor.Parse("#2c3e50")
                 },
                 new Microcharts.Entry(50)
                 {
                     Label = "Android",
                     ValueLabel = "50",
                     Color = SKColor.Parse("#77d065")
                 },
                 new Microcharts.Entry(30)
                 {
                     Label = "iOS",
                     ValueLabel = "30",
                     Color = SKColor.Parse("#b455b6")
                 },
                 new Microcharts.Entry(15)
                 {
                     Label = "Shared",
                     ValueLabel = "15",
                     Color = SKColor.Parse("#3498db")
                 }
            };

            var chart = new LineChart()
            {
                Entries = entries,
            };
            this.charView.Chart = chart;

            var chart2 = new BarChart()
            {
                Entries = entries,
            };
            this.charView2.Chart = chart2;

            var chart3 = new PointChart()
            {
                Entries = entries,
            };
            this.charView3.Chart = chart3;
        }
    }
}