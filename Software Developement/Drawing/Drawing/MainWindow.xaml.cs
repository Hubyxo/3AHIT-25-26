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
            Random rndm = new Random();

            for(int i = 0; i < 10; i++)
            {
              MainCanvas.Children.Add(new Quad(rndm.Next(0, 400), rndm.Next(0, 400), rndm.Next(20, 100)));
              MainCanvas.Children.Add(new Circles(rndm.Next(0, 400), rndm.Next(0, 400), rndm.Next(20, 100)));
              MainCanvas.Children.Add(new Lines(rndm.Next(0, 400), rndm.Next(0, 400), rndm.Next(0, 400), rndm.Next(0, 400)));
              MainCanvas.Children.Add(new QuadFunc(rndm.NextDouble(), rndm.NextDouble(), rndm.NextDouble(), rndm.Next(0, 400), rndm.Next(0, 400)));
            }
        }
    }
}
