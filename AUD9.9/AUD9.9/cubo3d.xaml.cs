using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AUD9._9
{
    /// <summary>
    /// Interaction logic for cubo3d.xaml
    /// </summary>
    public partial class cubo3d : UserControl
    {
         AxisAngleRotation3D rotx;

        public static int[] pared0 = new int[12];
        public static int[] pared1 = new int[12];
        public static int[] pared2 = new int[12];
        public static int[] pared3 = new int[12];

        public static int[] puerta0 = new int[12];
        public static int[] puerta1 = new int[12];
        public static int[] puerta2 = new int[12];
        public static int[] puerta3 = new int[12];


        public static int[] ventana0 = new int[12];
        public static int[] ventana1 = new int[12];
        public static  int[] ventana2 = new int[12];
        public static int[] ventana3 = new int[12];

        public static int[] terreno = new int[12];


        public static ArrayList instrucciones = new ArrayList();

        public static String c1 = "gray";
        public static String c2 = "gray";
        public static String c3 = "gray";
        public static String c4 = "gray";
        public static String c5 = "gray";
        public static String c6 = "gray";
        public static String c7 = "gray";
        public static String c8 = "gray";
        public static String c9 = "gray";
        public static String c10 = "gray";
        public static String c11 = "gray";
        public static String c12 = "gray";
        public static String c13 = "gray";



        public cubo3d()
        {
            InitializeComponent();
            //Principal ventana = new Principal();
            //ventana.Visible = true;
            rotx = new AxisAngleRotation3D(new Vector3D(1, 0, 0), 10);




        }
        



        


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rotatex.Angle = 5;
            rotatex2.Angle = 5;
            rotatex.Angle = 5;
            rotatex2.Angle = 5;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MeshGeometry3D mesh = new MeshGeometry3D();

            mesh.Positions.Add(new Point3D(0, 0, 0));
            mesh.Positions.Add(new Point3D(5, 0, 0));
            mesh.Positions.Add(new Point3D(5, 5, 0));
            mesh.Positions.Add(new Point3D(0, 5, 0));

            mesh.Positions.Add(new Point3D(0, 0, 0));
            mesh.Positions.Add(new Point3D(5, 0, 0));
            mesh.Positions.Add(new Point3D(5, 5, 0));
            mesh.Positions.Add(new Point3D(0, 5, 0));

            // cara delantera
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(0);

            // cara trasera
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(6);

            // cara izquierda
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(2);

            // cara superior
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(7);

            // cara inferior
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(5);

            // cara derecha
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(4);

            //GeometryModel3D mGeometry = new GeometryModel3D(mesh, new DiffuseMaterial(Brushes.YellowGreen));
            
            Point3DCollection cole = new Point3DCollection();

            //cole.Add(new Point3D(0, 0, 0));
            //cole.Add(new Point3D(0, 0, 0));
            //cole.Add(new Point3D(0, 0, 0));
            //cole.Add(new Point3D(0, 0, 0));
            //cole.Add(new Point3D(0, 0, 0));
            //cole.Add(new Point3D(0, 0, 0));
            //cole.Add(new Point3D(0, 0, 0));
            //cole.Add(new Point3D(0, 0, 0));

            cole.Add(new Point3D(0, 0, 0));
            cole.Add(new Point3D(5, 0, 0));
            cole.Add(new Point3D(5, 5, 0));
            cole.Add(new Point3D(0, 5, 0));

            cole.Add(new Point3D(0, 0, 0));
            cole.Add(new Point3D(5, 0, 0));
            cole.Add(new Point3D(5, 5, 0));
            cole.Add(new Point3D(0, 5, 0));


            panel1.Positions = cole;

            color.Brush = Brushes.YellowGreen;
            panel1 = mesh;




        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {


        }


        private void cambia() { 
        //evaluar que venta toda info



        
        
        
        }




        public void figura(double[] p, String c, String panel)
        {

            MeshGeometry3D mesh = new MeshGeometry3D();

            mesh.Positions.Add(new Point3D(p[0], p[1], p[2]));
            mesh.Positions.Add(new Point3D(p[3], p[4], p[5]));
            mesh.Positions.Add(new Point3D(p[6], p[7], p[8]));
            mesh.Positions.Add(new Point3D(p[9], p[10], p[11]));

            mesh.Positions.Add(new Point3D(p[0], p[1], p[2]));
            mesh.Positions.Add(new Point3D(p[3], p[4], p[5]));
            mesh.Positions.Add(new Point3D(p[6], p[7], p[8]));
            mesh.Positions.Add(new Point3D(p[9], p[10], p[11]));

            // cara delantera
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(0);

            // cara trasera
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(6);

            // cara izquierda
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(2);

            // cara superior
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(7);

            // cara inferior
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(5);

            // cara derecha
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(4);

           
            Point3DCollection cole = new Point3DCollection();

            cole.Add(new Point3D(p[0], p[1], p[2]));
            cole.Add(new Point3D(p[3], p[4], p[5]));
            cole.Add(new Point3D(p[6], p[7], p[8]));
            cole.Add(new Point3D(p[9], p[10], p[11]));

            cole.Add(new Point3D(p[0], p[1], p[2]));
            cole.Add(new Point3D(p[3], p[4], p[5]));
            cole.Add(new Point3D(p[6], p[7], p[8]));
            cole.Add(new Point3D(p[9], p[10], p[11]));

            

            Console.WriteLine("entro en cubo 3d ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            for (int i = 0; i < 12;i++ )
            {
                Console.WriteLine("**********" + p[i]);
            }
            
            //if de colores


            //  colo.Add("Blue");
            //colo.Add("Red");
            //colo.Add("Green");
            //colo.Add("Brown");
            //colo.Add("White");
            //colo.Add("Black");
            //colo.Add("Yellow");
            //colo.Add("Beige");


            Console.WriteLine("COLOR  "+c);




            if (c.Equals("azul"))
            {
                color.Brush = Brushes.Blue;
            }
            else if (c.Equals("rojo"))
            {
                color.Brush = Brushes.Red;
            }
            else if (c.Equals("verde"))
            {
                color.Brush = Brushes.Green;
            }
            else if (c.Equals("cafe"))
            {
                color.Brush = Brushes.Brown;
            }
            else if (c.Equals("blanco"))
            {
                color.Brush = Brushes.White;
            }
            else if (c.Equals("negro"))
            {
                color.Brush = Brushes.Black;
            }
            else if (c.Equals("amarillo"))
            {
                color.Brush = Brushes.Yellow;
            }
            else if (c.Equals("beige"))
            {
                color.Brush = Brushes.Beige;
            }
            else
            {
                color.Brush = Brushes.YellowGreen;
            }



            

            switch(panel){
            
                case"panel1":
                    colorpa(c);
                    panel1.Positions = cole;
                    panel1 = mesh.Clone();
                    break;
                case "panel2":
                    colorpa1(c);
                    panel2.Positions = cole;
                    panel2 = mesh.Clone();
                    break;
                case "panel3":
                    colorpa2(c);
                    panel3.Positions = cole;
                    panel3 = mesh.Clone();
                    break;
                case "panel5":
                    colorpa3(c);
                    panel5.Positions = cole;
                    panel5 = mesh.Clone();
                    break;
            }
            
        
        }

        private void colorpa(String c){
            
                switch (c)
                    {

                case "azul":
                    color.Brush = Brushes.Blue;
                    break;
                case "rojo":
                    color.Brush = Brushes.Red;
                    break;
                case "verde":
                    color.Brush = Brushes.Green;
                    break;
                case "cafe":
                    color.Brush = Brushes.Brown;
                    break;
                case "blanco":
                    color.Brush = Brushes.White;
                    break;
                case "negro":
                    color.Brush = Brushes.Black;
                    break;
                case "amarillo":
                    color.Brush = Brushes.Yellow;
                    break;
                case "beige":
                    color.Brush = Brushes.Beige;
                    break;
                case "transparente":
                    color.Brush = Brushes.Transparent;
                    break;

                default:
                    color.Brush = Brushes.Gray;
                    break;
            }
    
    }
        private void colorpa1(String c)
        {

            switch (c)
            {

                case "azul":
                    color1.Brush = Brushes.Blue;
                    break;
                case "rojo":
                    color1.Brush = Brushes.Red;
                    break;
                case "verde":
                    color1.Brush = Brushes.Green;
                    break;
                case "cafe":
                    color1.Brush = Brushes.Brown;
                    break;
                case "blanco":
                    color1.Brush = Brushes.White;
                    break;
                case "negro":
                    color1.Brush = Brushes.Black;
                    break;
                case "amarillo":
                    color1.Brush = Brushes.Yellow;
                    break;
                case "beige":
                    color1.Brush = Brushes.Beige;
                    break;
                case "transparente":
                    color1.Brush = Brushes.Transparent;
                    break;
                default:
                    color1.Brush = Brushes.Gray;
                    break;
            }

        }
        private void colorpa2(String c)
        {

            switch (c)
            {

                case "azul":
                    color2.Brush = Brushes.Blue;
                    break;
                case "rojo":
                    color2.Brush = Brushes.Red;
                    break;
                case "verde":
                    color2.Brush = Brushes.Green;
                    break;
                case "cafe":
                    color2.Brush = Brushes.Brown;
                    break;
                case "blanco":
                    color2.Brush = Brushes.White;
                    break;
                case "negro":
                    color2.Brush = Brushes.Black;
                    break;
                case "amarillo":
                    color2.Brush = Brushes.Yellow;
                    break;
                case "beige":
                    color2.Brush = Brushes.Beige;
                    break;
                case "transparente":
                    color2.Brush = Brushes.Transparent;
                    break;

                default:
                    color2.Brush = Brushes.Gray;
                    break;
            }

        }
        private void colorpa3(String c)
        {

            switch (c)
            {

                case "azul":
                    color3.Brush = Brushes.Blue;
                    break;
                case "rojo":
                    color3.Brush = Brushes.Red;
                    break;
                case "verde":
                    color3.Brush = Brushes.Green;
                    break;
                case "cafe":
                    color3.Brush = Brushes.Brown;
                    break;
                case "blanco":
                    color3.Brush = Brushes.White;
                    break;
                case "negro":
                    color3.Brush = Brushes.Black;
                    break;
                case "amarillo":
                    color3.Brush = Brushes.Yellow;
                    break;
                case "beige":
                    color3.Brush = Brushes.Beige;
                    break;
                case "trasparente":
                    color3.Brush = Brushes.Transparent;
                    break;
                default:
                    color3.Brush = Brushes.Gray;
                    break;
            }

        }

        private void colorpav(String c)
        {

            switch (c)
            {

                case "azul":
                    colorp.Brush = Brushes.Blue;
                    break;
                case "rojo":
                    colorp.Brush = Brushes.Red;
                    break;
                case "verde":
                    colorp.Brush = Brushes.Green;
                    break;
                case "cafe":
                    colorp.Brush = Brushes.Brown;
                    break;
                case "blanco":
                    colorp.Brush = Brushes.White;
                    break;
                case "negro":
                    colorp.Brush = Brushes.Black;
                    break;
                case "amarillo":
                    colorp.Brush = Brushes.Yellow;
                    break;
                case "beige":
                    colorp.Brush = Brushes.Beige;
                    break;
                case "transparente":
                    colorp.Brush = Brushes.Transparent;
                    break;

                default:
                    colorp.Brush = Brushes.Gray;
                    break;
            }

        }
        private void colorpav1(String c)
        {

            switch (c)
            {

                case "azul":
                    colorp1.Brush = Brushes.Blue;
                    break;
                case "rojo":
                    colorp1.Brush = Brushes.Red;
                    break;
                case "verde":
                    colorp1.Brush = Brushes.Green;
                    break;
                case "cafe":
                    colorp1.Brush = Brushes.Brown;
                    break;
                case "blanco":
                    colorp1.Brush = Brushes.White;
                    break;
                case "negro":
                    colorp1.Brush = Brushes.Black;
                    break;
                case "amarillo":
                    colorp1.Brush = Brushes.Yellow;
                    break;
                case "beige":
                    colorp1.Brush = Brushes.Beige;
                    break;
                case "transparente":
                    colorp1.Brush = Brushes.Transparent;
                    break;

                default:
                    colorp1.Brush = Brushes.Gray;
                    break;
            }

        }
        private void colorpav2(String c)
        {

            switch (c)
            {

                case "azul":
                    colorp2.Brush = Brushes.Blue;
                    break;
                case "rojo":
                    colorp2.Brush = Brushes.Red;
                    break;
                case "verde":
                    colorp2.Brush = Brushes.Green;
                    break;
                case "cafe":
                    colorp2.Brush = Brushes.Brown;
                    break;
                case "blanco":
                    colorp2.Brush = Brushes.White;
                    break;
                case "negro":
                    colorp2.Brush = Brushes.Black;
                    break;
                case "amarillo":
                    colorp2.Brush = Brushes.Yellow;
                    break;
                case "beige":
                    colorp2.Brush = Brushes.Beige;
                    break;
                case "transparente":
                    colorp2.Brush = Brushes.Transparent;
                    break;

                default:
                    colorp2.Brush = Brushes.Gray;
                    break;
            }

        }
        private void colorpav3(String c)
        {

            switch (c)
            {

                case "azul":
                    colorp3.Brush = Brushes.Blue;
                    break;
                case "rojo":
                    colorp3.Brush = Brushes.Red;
                    break;
                case "verde":
                    colorp3.Brush = Brushes.Green;
                    break;
                case "cafe":
                    colorp3.Brush = Brushes.Brown;
                    break;
                case "blanco":
                    colorp3.Brush = Brushes.White;
                    break;
                case "negro":
                    colorp3.Brush = Brushes.Black;
                    break;
                case "amarillo":
                    colorp3.Brush = Brushes.Yellow;
                    break;
                case "beige":
                    colorp3.Brush = Brushes.Beige;
                    break;
                case "transparente":
                    colorp3.Brush = Brushes.Transparent;
                    break;

                default:
                    colorp3.Brush = Brushes.Gray;
                    break;
            }

        }


        public void colorSuelo(String c)
        {
            Console.WriteLine(c+"colococococooc");
            switch (c)
            {

                case "azul":
                    suelox.Brush = Brushes.Blue;
                    break;
                case "rojo":
                    suelox.Brush = Brushes.Red;
                    break;
                case "verde":
                    suelox.Brush = Brushes.Green;
                    break;
                case "cafe":
                    suelox.Brush = Brushes.Brown;
                    break;
                case "blanco":
                    suelox.Brush = Brushes.White;
                    break;
                case "negro":
                    suelox.Brush = Brushes.Black;
                    break;
                case "amarillo":
                    suelox.Brush = Brushes.Yellow;
                    break;
                case "beige":
                    suelox.Brush = Brushes.Beige;
                    break;
                case "transparente":
                    suelox.Brush = Brushes.Transparent;
                    break;

                default:
                    suelox.Brush = Brushes.Gray;
                    break;
            }

        }



        public void Ventana(double[] p,String panel)
        {

            MeshGeometry3D mesh = new MeshGeometry3D();

            mesh.Positions.Add(new Point3D(p[0], p[1], p[2]));
            mesh.Positions.Add(new Point3D(p[3], p[4], p[5]));
            mesh.Positions.Add(new Point3D(p[6], p[7], p[8]));
            mesh.Positions.Add(new Point3D(p[9], p[10], p[11]));

            mesh.Positions.Add(new Point3D(p[0], p[1], p[2]));
            mesh.Positions.Add(new Point3D(p[3], p[4], p[5]));
            mesh.Positions.Add(new Point3D(p[6], p[7], p[8]));
            mesh.Positions.Add(new Point3D(p[9], p[10], p[11]));

            // cara delantera
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(0);

            // cara trasera
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(6);

            // cara izquierda
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(2);

            // cara superior
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(7);

            // cara inferior
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(5);

            // cara derecha
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(4);


            Point3DCollection cole = new Point3DCollection();

            cole.Add(new Point3D(p[0], p[1], p[2]));
            cole.Add(new Point3D(p[3], p[4], p[5]));
            cole.Add(new Point3D(p[6], p[7], p[8]));
            cole.Add(new Point3D(p[9], p[10], p[11]));

            cole.Add(new Point3D(p[0], p[1], p[2]));
            cole.Add(new Point3D(p[3], p[4], p[5]));
            cole.Add(new Point3D(p[6], p[7], p[8]));
            cole.Add(new Point3D(p[9], p[10], p[11]));



            Console.WriteLine("entro en VENANA 3d ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("**********" + p[i]);
            }

            //if de colores


            //  colo.Add("Blue");
            //colo.Add("Red");
            //colo.Add("Green");
            //colo.Add("Brown");
            //colo.Add("White");
            //colo.Add("Black");
            //colo.Add("Yellow");
            //colo.Add("Beige");


            color.Brush = Brushes.SkyBlue;





            Console.WriteLine("ENTRARA PARA CREAR VENTANA "+panel);

            switch (panel)
            {

                case "modelova":
                    modelova.Positions = cole;
                    modelova = mesh.Clone();
                    break;
                case "modelovs":
                    modelovs.Positions = cole;
                    modelovs = mesh.Clone();
                    break;
                case "modelovd":
                    modelovd.Positions = cole;
                    modelovd = mesh.Clone();
                    break;
                case "modelovf":
                    modelovf.Positions = cole;
                    modelovf = mesh.Clone();
                    break;
            }


        }

        public void Puertas(double[] p, String panel,Object Color)
        {

            MeshGeometry3D mesh = new MeshGeometry3D();

            mesh.Positions.Add(new Point3D(p[0], p[1], p[2]));
            mesh.Positions.Add(new Point3D(p[3], p[4], p[5]));
            mesh.Positions.Add(new Point3D(p[6], p[7], p[8]));
            mesh.Positions.Add(new Point3D(p[9], p[10], p[11]));

            mesh.Positions.Add(new Point3D(p[0], p[1], p[2]));
            mesh.Positions.Add(new Point3D(p[3], p[4], p[5]));
            mesh.Positions.Add(new Point3D(p[6], p[7], p[8]));
            mesh.Positions.Add(new Point3D(p[9], p[10], p[11]));

            // cara delantera
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(0);

            // cara trasera
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(6);

            // cara izquierda
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(2);

            // cara superior
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(7);

            // cara inferior
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(5);

            // cara derecha
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(4);


            Point3DCollection cole = new Point3DCollection();

            cole.Add(new Point3D(p[0], p[1], p[2]));
            cole.Add(new Point3D(p[3], p[4], p[5]));
            cole.Add(new Point3D(p[6], p[7], p[8]));
            cole.Add(new Point3D(p[9], p[10], p[11]));

            cole.Add(new Point3D(p[0], p[1], p[2]));
            cole.Add(new Point3D(p[3], p[4], p[5]));
            cole.Add(new Point3D(p[6], p[7], p[8]));
            cole.Add(new Point3D(p[9], p[10], p[11]));



            Console.WriteLine("entro en VENANA 3d ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("**********" + p[i]);
            }

            //if de colores


            //  colo.Add("Blue");
            //colo.Add("Red");
            //colo.Add("Green");
            //colo.Add("Brown");
            //colo.Add("White");
            //colo.Add("Black");
            //colo.Add("Yellow");
            //colo.Add("Beige");
            String c= Convert.ToString(Color);

            Console.WriteLine("COLOR  " + c+"****************");

            if (c.Equals("azul"))
            {
                
                color.Brush = Brushes.Blue;
            }
            else if (c.Equals("rojo"))
            {
                color.Brush = Brushes.Red;
            }
            else if (c.Equals("verde"))
            {

                Console.WriteLine("ENTRO VERTE ");
                color.Brush = Brushes.Green;
            }
            else if (c.Equals("cafe"))
            {
                color.Brush = Brushes.Brown;
            }
            else if (c.Equals("blanco"))
            {
                color.Brush = Brushes.White;
            }
            else if (c.Equals("negro"))
            {
                color.Brush = Brushes.Black;
            }
            else if (c.Equals("amarillo"))
            {
                color.Brush = Brushes.Yellow;
            }
            else if (c.Equals("beige"))
            {
                color.Brush = Brushes.Beige;
            }
            else
            {
                color.Brush = Brushes.YellowGreen;
            }





            Console.WriteLine("ENTRARA PARA CREAR VENTANA " + panel);

            switch (panel)
            {

                case "puerta0":
                    colorpav(c);
                    puertap0.Positions = cole;
                    puertap0 = mesh.Clone();
                    break;
                case "puerta1":
                    colorpav1(c);
                    puerta1p.Positions = cole;
                    puerta1p = mesh.Clone();
                    break;
                case "puerta2":
                    colorpav2(c);
                    puerta2p.Positions = cole;
                    puerta2p = mesh.Clone();
                    break;
                case "puerta3":
                    colorpav3(c);
                    puerta3p.Positions = cole;
                    puerta3p = mesh.Clone();
                    break;
            }


        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {


            rotatex.Angle = SL1.Value;
            rotatex2.Angle = SL1.Value;
            rotatex3.Angle = SL1.Value;
            rotatex5.Angle = SL1.Value;
            rotatexv.Angle = SL1.Value;
            rotatexv2.Angle = SL1.Value;
            rotatexv3.Angle = SL1.Value;
            rotatexv5.Angle = SL1.Value;

            rotatex6.Angle = SL1.Value;

            rotatexp.Angle = SL1.Value;
            rotatexp2.Angle = SL1.Value;
            rotatexp3.Angle = SL1.Value;
            rotatexp5.Angle = SL1.Value;


            
        }

        private void Slider_ValueChanged2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {


            rotatey.Angle = SL2.Value;
            rotatey2.Angle = SL2.Value;
            rotatey3.Angle = SL2.Value;
            rotatey5.Angle = SL2.Value;
            rotateyv.Angle = SL2.Value;
            rotateyv2.Angle = SL2.Value;
            rotateyv3.Angle = SL2.Value;
            rotateyv5.Angle = SL2.Value;

            rotatey6.Angle = SL2.Value;

            rotateyp.Angle = SL2.Value;
            rotateyp2.Angle = SL2.Value;
            rotateyp3.Angle = SL2.Value;
            rotateyp5.Angle = SL2.Value;

            
        }
        int z = 0;

        public void valor(int valor) {

            z = z + valor;
            rotatez.Angle = z;
        }
        private void Slider_ValueChanged3(object sender, RoutedPropertyChangedEventArgs<double> e)
        {


            rotatez.Angle = SL3.Value;
            //rotatez.Angle = z;
            rotatez2.Angle = SL3.Value;
            rotatez3.Angle = SL3.Value;
            rotatez5.Angle =SL3.Value;
            rotatezv.Angle = SL3.Value;
            rotatezv2.Angle = SL3.Value;
            rotatezv3.Angle = SL3.Value;
            rotatezv5.Angle = SL3.Value;

            rotatez6.Angle = SL3.Value;

            rotatezp.Angle = SL3.Value;
            rotatezp2.Angle = SL3.Value;
            rotatezp3.Angle = SL3.Value;
            rotatezp5.Angle = SL3.Value;

            
        }
    }
}
