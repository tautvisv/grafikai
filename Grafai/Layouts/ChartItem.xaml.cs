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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ChartItem : UserControl
    {
        Frame layout;
        public ChartItem(Frame layout, string name, string data, int height = 0)
        {
            InitializeComponent();
            this.layout = layout;
            chartName.Text = name;
            var uriSource = new Uri(@"/Grafai;component/"+data, UriKind.Relative);
            chartIcon.Source = new BitmapImage(uriSource);
            if (height > 0)
            {
                chartIcon.Height = height;
            }
        }
        private void changeBackground(object sender, MouseEventArgs e)
        {
            Main.Background = Brushes.PapayaWhip;
        }

        private void restoreBackground(object sender, MouseEventArgs e)
        {
            Main.Background = Brushes.WhiteSmoke;
        }
        private void openMainWindow(object sender, MouseEventArgs e)
        {
            layout.Navigate(new WorkFrame());
            
        }
    }
}
