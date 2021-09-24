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

namespace AUD9._9
{
    /// <summary>
    /// Interaction logic for planta.xaml
    /// </summary>
    public partial class planta : UserControl
    {
        public planta()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //720   x
            //560 y
            


            Rectangle myRect = new Rectangle();
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Top;
            myRect.Stroke =Brushes.Black;
            myRect.Height = 300;
            myRect.Width = 6;
            myRect.Margin = new Thickness(110, 100, 0, 0);
            Grids.Children.Add(myRect);

            Rectangle myRect5 = new Rectangle();
            myRect5.HorizontalAlignment = HorizontalAlignment.Left;
            myRect5.VerticalAlignment = VerticalAlignment.Top;
            myRect5.Stroke = Brushes.Black;
            myRect5.Height = 6;
            myRect5.Width = 500;
            myRect5.Margin = new Thickness(110, 100, 0, 0);
            Grids.Children.Add(myRect5);


            Rectangle myRect3 = new Rectangle();
            myRect3.HorizontalAlignment = HorizontalAlignment.Left;
            myRect3.VerticalAlignment = VerticalAlignment.Top;
            myRect3.Stroke = Brushes.Black;
            myRect3.Height = 300;
            myRect3.Width = 6;
            myRect3.Margin = new Thickness(604, 100, 0, 0);
            Grids.Children.Add(myRect3);

            Rectangle myRect2 = new Rectangle();
            myRect2.HorizontalAlignment = HorizontalAlignment.Left;
            myRect2.VerticalAlignment = VerticalAlignment.Top;
            myRect2.Stroke = Brushes.Black;
            myRect2.Height = 6;
            myRect2.Width = 500;
            myRect2.Margin = new Thickness(110, 394, 0, 0);
            Grids.Children.Add(myRect2);


            

            


            //inicia puertas


            Rectangle myRect8 = new Rectangle();
            myRect8.HorizontalAlignment = HorizontalAlignment.Left;
            myRect8.VerticalAlignment = VerticalAlignment.Top;
            myRect8.Stroke = Brushes.Black;
            myRect8.Fill = Brushes.Gray;
            myRect8.Height = 80;
            myRect8.Width = 6;
            myRect8.Margin = new Thickness(110, 210, 0, 0);
            Grids.Children.Add(myRect8);


            Rectangle myRect6 = new Rectangle();
            myRect6.HorizontalAlignment = HorizontalAlignment.Left;
            myRect6.VerticalAlignment = VerticalAlignment.Top;
            myRect6.Stroke = Brushes.Black;
            myRect6.Fill = Brushes.Gray;
            myRect6.Height = 6;
            myRect6.Width = 80;
            myRect6.Margin = new Thickness(320, 100, 0, 0);
            Grids.Children.Add(myRect6);


            Rectangle myRect9 = new Rectangle();
            myRect9.HorizontalAlignment = HorizontalAlignment.Left;
            myRect9.VerticalAlignment = VerticalAlignment.Top;
            myRect9.Stroke = Brushes.Black;
            myRect9.Fill = Brushes.Gray;
            myRect9.Height = 80;
            myRect9.Width = 6;
            myRect9.Margin = new Thickness(604, 210, 0, 0);
            Grids.Children.Add(myRect9);



            Rectangle myRect7 = new Rectangle();
            myRect7.HorizontalAlignment = HorizontalAlignment.Left;
            myRect7.VerticalAlignment = VerticalAlignment.Top;
            myRect7.Stroke = Brushes.Black;
            myRect7.Fill = Brushes.Gray;
            myRect7.Height = 6;
            myRect7.Width = 80;
            myRect7.Margin = new Thickness(320, 394, 0, 0);
            Grids.Children.Add(myRect7);


            



            

            //cotas

            Line myLine = new Line();
            myLine.Stroke = System.Windows.Media.Brushes.Black;
            myLine.X1 = 110;
            myLine.X2 = 610;
            myLine.Y1 = 90;
            myLine.Y2 = 90;
            //myLine.StrokeThickness = 0.2;
            Grids.Children.Add(myLine);


            Line myLine2 = new Line();
            myLine2.Stroke = System.Windows.Media.Brushes.Black;
            myLine2.X1 = 100;
            myLine2.X2 = 100;
            myLine2.Y1 = 100;
            myLine2.Y2 = 400;
            //myLine2.StrokeThickness = 0.2;
            Grids.Children.Add(myLine2);


            Line myLine3 = new Line();
            myLine3.Stroke = System.Windows.Media.Brushes.Black;
            myLine3.X1 = 620;
            myLine3.X2 = 620;
            myLine3.Y1 = 100;
            myLine3.Y2 = 400;
            //myLine3.StrokeThickness = 0.2;
            Grids.Children.Add(myLine3);

            Line myLine5 = new Line();
            myLine5.Stroke = System.Windows.Media.Brushes.Black;
            myLine5.X1 = 110;
            myLine5.X2 = 610;
            myLine5.Y1 = 410;
            myLine5.Y2 = 410;
            //myLine5.StrokeThickness = 0.2;
            Grids.Children.Add(myLine5);


            /////////////////////////////////////



            Line myLine6 = new Line();
            myLine6.Stroke = System.Windows.Media.Brushes.Black;
            myLine6.X1 = 125;
            myLine6.X2 = 125;
            myLine6.Y1 = 210;
            myLine6.Y2 = 290;
            //myLine6.StrokeThickness = 0.2;
            Grids.Children.Add(myLine6);


            Line myLine7 = new Line();
            myLine7.Stroke = System.Windows.Media.Brushes.Black;
            myLine7.X1 = 595;
            myLine7.X2 = 595;
            myLine7.Y1 = 210;
            myLine7.Y2 = 290;
            //myLine7.StrokeThickness = 0.2;
            Grids.Children.Add(myLine7);


            Line myLine8 = new Line();
            myLine8.Stroke = System.Windows.Media.Brushes.Black;
            myLine8.X1 = 320;
            myLine8.X2 = 400;
            myLine8.Y1 = 116;
            myLine8.Y2 = 116;
            //myLine8.StrokeThickness = 0.2;
            Grids.Children.Add(myLine8);

            Line myLine9 = new Line();
            myLine9.Stroke = System.Windows.Media.Brushes.Black;
            myLine9.X1 = 320;
            myLine9.X2 = 400;
            myLine9.Y1 = 385;
            myLine9.Y2 = 385;
            //myLine9.StrokeThickness = 0.2;
            Grids.Children.Add(myLine9);








            //Line myLine2 = new Line();
            //myLine2.Stroke = System.Windows.Media.Brushes.Black;
            //myLine2.X1 = 110;
            //myLine2.X2 = 110;
            //myLine2.Y1 = 100;
            //myLine2.Y2 = 310;
            ////myLine.HorizontalAlignment = HorizontalAlignment.Left;
            ////myLine.VerticalAlignment = VerticalAlignment.Center;
            //myLine2.StrokeThickness = 3;
            //Grids.Children.Add(myLine2);


            //Line myLine3 = new Line();
            //myLine3.Stroke = System.Windows.Media.Brushes.Black;
            //myLine3.X1 = 110;
            //myLine3.X2 = 610;
            //myLine3.Y1 = 100;
            //myLine3.Y2 = 100;
            ////myLine.HorizontalAlignment = HorizontalAlignment.Left;
            ////myLine.VerticalAlignment = VerticalAlignment.Center;
            //myLine3.StrokeThickness = 3;
            //Grids.Children.Add(myLine3);


            //Line myLine4 = new Line();
            //myLine4.Stroke = System.Windows.Media.Brushes.Black;
            //myLine4.X1 = 110;
            //myLine4.X2 = 610;
            //myLine4.Y1 = 100;
            //myLine4.Y2 = 100;
            ////myLine.HorizontalAlignment = HorizontalAlignment.Left;
            ////myLine.VerticalAlignment = VerticalAlignment.Center;
            //myLine4.StrokeThickness = 3;
            //Grids.Children.Add(myLine4);
        }
    }
}
