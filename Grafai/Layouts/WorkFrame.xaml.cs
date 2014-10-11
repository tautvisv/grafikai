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
    /// Interaction logic for WorkFrame.xaml
    /// </summary>
    public partial class WorkFrame : UserControl
    {
        public WorkFrame()
        {
            InitializeComponent();
            Chart.Navigate(new Chart());
        }
    }
}
