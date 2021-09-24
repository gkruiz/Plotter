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
using System.Windows;

namespace AUD9._9
{
    /// <summary>
    /// Interaction logic for elevacion.xaml
    /// </summary>
    public partial class elevacion : UserControl
    {
        public elevacion()
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
            myRect.Stroke = Brushes.Black;
            myRect.Height = 300;
            myRect.Width = 500;
            myRect.Margin = new Thickness(110, 100, 0, 0);
            Grids.Children.Add(myRect);


            Rectangle myRect1 = new Rectangle();
            myRect1.HorizontalAlignment = HorizontalAlignment.Left;
            myRect1.VerticalAlignment = VerticalAlignment.Top;
            myRect1.Stroke = Brushes.Black;
            myRect1.Height = 294;
            myRect1.Width = 488;
            myRect1.Margin = new Thickness(116, 106, 0, 0);
            Grids.Children.Add(myRect1);




            Rectangle myRect2 = new Rectangle();
            myRect2.HorizontalAlignment = HorizontalAlignment.Left;
            myRect2.VerticalAlignment = VerticalAlignment.Top;
            myRect2.Stroke = Brushes.Black;
            myRect2.Height = 130;
            myRect2.Width = 80;
            myRect2.Margin = new Thickness(310, 270, 0, 0);
            Grids.Children.Add(myRect2);

            Rectangle myRect3 = new Rectangle();
            myRect3.HorizontalAlignment = HorizontalAlignment.Left;
            myRect3.VerticalAlignment = VerticalAlignment.Top;
            myRect3.Stroke = Brushes.Black;
            myRect3.Height = 80;
            myRect3.Width = 80;
            myRect3.Margin = new Thickness(450, 200, 0, 0);
            Grids.Children.Add(myRect3);



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





            Line myLine8 = new Line();
            myLine8.Stroke = System.Windows.Media.Brushes.Black;
            myLine8.X1 = 310;
            myLine8.X2 = 390;
            myLine8.Y1 = 255;
            myLine8.Y2 = 255;
            //myLine8.StrokeThickness = 0.2;
            Grids.Children.Add(myLine8);

            Line myLine9 = new Line();
            myLine9.Stroke = System.Windows.Media.Brushes.Black;
            myLine9.X1 = 400;
            myLine9.X2 = 400;
            myLine9.Y1 = 270;
            myLine9.Y2 = 400;
            //myLine9.StrokeThickness = 0.2;
            Grids.Children.Add(myLine9);






            Line myLine10 = new Line();
            myLine10.Stroke = System.Windows.Media.Brushes.Black;
            myLine10.X1 = 450;
            myLine10.X2 = 530;
            myLine10.Y1 = 190;
            myLine10.Y2 = 190;
            //myLine8.StrokeThickness = 0.2;
            Grids.Children.Add(myLine10);

            Line myLine11 = new Line();
            myLine11.Stroke = System.Windows.Media.Brushes.Black;
            myLine11.X1 = 540;
            myLine11.X2 = 540;
            myLine11.Y1 = 200;
            myLine11.Y2 = 280;
            //myLine8.StrokeThickness = 0.2;
            Grids.Children.Add(myLine11);






        }
    }
}
