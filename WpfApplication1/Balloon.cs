using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace WpfApplication1
{
    // ENCAPSULATIE

    class Balloon
    {
        private int x = 10;
        private int y = 100;
        private int diameter = 10;
        TextBlock textBlock = new TextBlock();
        Ellipse ellipse = new Ellipse();

        static Random rndGen = new Random();

        public Balloon(Canvas canvas)
        {
            diameter = rndGen.Next();
            x = rndGen.Next();
            y = rndGen.Next();
            
            UpdateEllipse(canvas);
        }

        public Balloon(Canvas canvas, int diameter)
        {
            this.diameter = diameter;
             x = rndGen.Next(50,1000);
            y = rndGen.Next(50,1000);

            UpdateEllipse(canvas);
        }

        public Balloon(Canvas canvas, int diameter, int height)
        {
            this.diameter = diameter;
            x = rndGen.Next(10,3000);
            y = rndGen.Next(10,3000);

            UpdateEllipse(canvas);
        }

        void UpdateEllipse(Canvas canvas)
        {
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.StrokeThickness = 10;
            ellipse.Fill = new SolidColorBrush(Colors.LightBlue);
            ellipse.Stroke = new SolidColorBrush(Colors.Pink);
            canvas.Children.Add(ellipse);
            textBlock.Text = "HAPPY BIRTHDAY LOES!";
            textBlock.Margin = new Thickness(x, y, 100, 500);
            textBlock.FontFamily = new FontFamily("Kristen ITC");
            canvas.Children.Add(textBlock);
        }

        public void Grow()
        {
            diameter += 10;
            ellipse.Width = diameter;
            ellipse.Height = diameter;
        }

        public void Move()
        {
            y -= 10;
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }

    public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
              
            }
        }

    }
}
