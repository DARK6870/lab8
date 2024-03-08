using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace lab7
{
    public partial class ChartWindow : Window
    {
        public List<WeatherModel> weather { get; set; }

        public ChartWindow(List<WeatherModel> weather)
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Temperature",
                    Values = new ChartValues<double>(weather.Select(w => w.Temp ?? 0)),
                    PointGeometrySize = 6,
                    StrokeThickness = 4,
                    Fill = Brushes.Transparent
                }
            };

            DateLabels = weather.Select(w => w.Date?.ToString("dd/MM/yyyy") ?? "").ToArray();

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] DateLabels { get; set; }
    }
}
