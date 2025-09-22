using Drawing.Classes;
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

namespace Drawing
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainCanvas.Children.Add(new Lines(50, 50, 200, 200));
            MainCanvas.Children.Add(new Quad(300, 100, 80));
            MainCanvas.Children.Add(new Circles(500, 200, 50));
            MainCanvas.Children.Add(new QuadFunc(0.01, 0, 0, 400, 300));
        }
    }
}
