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
        Brush strokeBrush = Brushes.Red;
        Brush bgBrush = new LinearGradientBrush(Colors.Red, Colors.Pink, 90);
        static Random rndGen = new Random();

        public Balloon(Canvas canvas)
        {
            diameter = rndGen.Next();
            x = rndGen.Next();
            y = rndGen.Next();
            
            UpdateEllipse();
            canvas.Children.Add(ellipse);
            canvas.Children.Add(textBlock);
        }

        public Balloon(Canvas canvas, int diameter)
        {
            this.diameter = diameter;
             x = rndGen.Next(50,1000);
            y = rndGen.Next(50,1000);

            UpdateEllipse();
            canvas.Children.Add(ellipse);
            canvas.Children.Add(textBlock);
        }

        public Balloon(Canvas canvas, int diameter, int height)
        {
            this.diameter = diameter;
            x = rndGen.Next(10,3000);
            y = rndGen.Next(10,3000);

            UpdateEllipse();
            canvas.Children.Add(textBlock);
            canvas.Children.Add(ellipse);
           
        }

        void UpdateEllipse()
        {
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.StrokeThickness = 10;
            ellipse.Fill = bgBrush;
            ellipse.Stroke =strokeBrush;
           
            textBlock.Text = "HOI";
            textBlock.Margin = new Thickness(x, y, 100, 500);
            textBlock.FontFamily = new FontFamily("Kristen ITC");
            textBlock.Foreground = new SolidColorBrush(Colors.Aquamarine);
            
            textBlock.FontSize = 10;
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
            textBlock.Margin = new Thickness(x + diameter / 4, y + diameter / 4, 0, 0);
        }
        public Brush Background
        {
            get
            {
                return bgBrush;
            }
            set
            {
                bgBrush = value;
                UpdateEllipse();
                
            }
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
                UpdateEllipse();
              
            }
        }

    }
}
