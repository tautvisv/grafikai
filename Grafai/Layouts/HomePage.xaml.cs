using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Grafai.Layouts
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : UserControl
    {
        public struct ImageData
        {
            public ImageData(string name, string url)
            {
                this.name = name;
                this.url = url;
            }
            public string name;
            public string url;
        }
        Frame layout;
        public HomePage(Frame layout)
        {
            InitializeComponent();
            this.layout = layout;
            ImageData[] menuItems = new ImageData[] { new ImageData("Linijinė diagrama","Images/Actions-office-chart-line-icon.png"),
            new ImageData("Stulpelinė diagrama","Images/bar_chart_icon.jpg"), new ImageData("Skritulinė diagrama","Images/pie_chart.png"),
            new ImageData("Taškinė diagrama","Images/Reports Area Chart.jpg"), new ImageData("Eilutinė diagrama","Images/Reports Scatter Chart.jpg")};

            ImageData[] recentItems = new ImageData[] { new ImageData("Linijinė diagrama", "Images/Actions-office-chart-line-icon.png"), new ImageData("Eilutinė diagrama", "Images/Reports Scatter Chart.jpg"), new ImageData("Linijinė diagrama", "Images/Actions-office-chart-line-icon.png") };

            InitializeComponent();
            int counter = 0;
            foreach (ImageData element in menuItems)
            {
                ChartItem Box = new ChartItem(layout, element.name, element.url);
                MainList.Children.Add(Box);
                Grid.SetRow(Box, counter / 3);
                Grid.SetColumn(Box, counter % 3);
                counter++;
            }
            foreach (ImageData element in recentItems)
            {
                ChartItem Box = new ChartItem(layout, element.name, element.url, 100);
                RecentItems.Children.Add(Box);
            }
        }
    }
}
