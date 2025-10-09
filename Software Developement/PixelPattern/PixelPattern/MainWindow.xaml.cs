using PixelPattern.Classes;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PixelPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int size = 6;
        private List<ColorCanvas> boxes = new List<ColorCanvas>();
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            canvas.Children.Clear();
            boxes.Clear();

            double cellSize = 500.0 / size;
            int index = 0;

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    ColorCanvas box;
                    int strategy = random.Next(4);

                    if (strategy == 0)
                    {
                        box = new ColorMixer();
                    }
                    else if (strategy == 1)
                    {
                        box = new RedCycler();
                    }
                    else if (strategy == 2)
                    {
                        box = new BlueCycler();
                    }
                    else
                    {
                        box = new NeighbourCycler();
                    }

                    box.Width = cellSize;
                    box.Height = cellSize;
                    box.Left = x * cellSize;
                    box.Top = y * cellSize;

                    byte r = (byte)random.Next(256);
                    byte g = (byte)random.Next(256);
                    byte b = (byte)random.Next(256);

                    box.Color = Color.FromRgb(r, g, b);
                    box.CreateRectangle();
                    boxes.Add(box);
                    canvas.Children.Add(box.Rectangle);

                    index++;
                }
            }

            for (int i = 0; i < boxes.Count; i++)
            {
                List<ColorCanvas> neighbors = new List<ColorCanvas>();

                for (int j = 0; j < boxes.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    double dx = boxes[i].Left - boxes[j].Left;
                    double dy = boxes[i].Top - boxes[j].Top;

                    if (Math.Abs(dx) <= cellSize + 0.1 && Math.Abs(dy) <= cellSize + 0.1)
                    {
                        if (!(dx == 0 && dy == 0))
                        {
                            neighbors.Add(boxes[j]);
                        }
                    }
                }

                boxes[i].Neighbors = neighbors;
            }
        }

        private void btnStep_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < boxes.Count; i++)
            {
                boxes[i].Update();
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            InitializeGrid();
        }
    }
}
