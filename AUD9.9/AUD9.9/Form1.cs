using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace AUD9._9
{
    public partial class Form1 : Form
    {
        Analisis1 ana;
        public Form1()
        {
            InitializeComponent();
          
           ana = new Analisis1();
        }
        String salida = "asdf";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void compilarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            ana = new Analisis1();
            TextReader read = new System.IO.StringReader(textBox1.Text);
            String linea = read.ReadLine();

            Boolean salir = false;
            int Conta = 0;

            int contador = 0;
            while (!salir)
            {
                //Console.WriteLine(linea + "-+-+-+-+-+-+-+-+-+-+-");
                if (("".Equals(linea)) || (linea == null) || (String.IsNullOrEmpty(linea)) || (" ".Equals(linea)))
                {
                    if (Conta == 5)
                    {
                        salir = true;
                    }
                    else
                    {
                        Conta++;
                    }
                    linea = read.ReadLine();
                }
                else
                {
                   
                    Conta = 0;
                    ana.inicio((linea).Trim());
                    ana.error(linea.Trim(),contador);
                   // Console.WriteLine(linea + "55555555");
                    linea = read.ReadLine();
                    contador++;
                }
            }
            Console.WriteLine("5555///////////////////////////////////////5555");

            //for (int i = 0; i < ana.lineT.Count; i++)
            //{
            //    ArrayList tem = (ArrayList)ana.lineT[i];
            //    for (int j = 0; j < tem.Count; j++)
            //    {
            //        Console.WriteLine("saco------------------------:" + tem[j] + " " + j);
            //    }

            //}

            //Cpuertas = sin.Cpuertas();
            //Npuertas = sin.noPuertas();
            //Nventanas = sin.noVentanas();
            //Csuelo = sin.Csuelo();


            ana.Stokens();
            html(ana.Ctoken);
            
            String err=ana.segun();
            ArrayList Cpuetas = ana.Cpuertas;
            int Npuertas = ana.Npuertas;
            int Nventanas = ana.Nventanas;
            String Csuelo = ana.Csuelo;





            Console.WriteLine(err+"55555555555555555555555555555");

            if(err=="NO"){

                ArrayList datos = ana.GetDatos();
                cubo3d1 = new AUD9._9.cubo3d();
                this.elementHost1.Location = new System.Drawing.Point(-1, 1);
                this.elementHost1.Name = "elementHost1";
                this.elementHost1.Size = new System.Drawing.Size(719, 572);
                this.elementHost1.TabIndex = 3;
                this.elementHost1.Text = "elementHost1";
                this.elementHost1.Child = this.cubo3d1;

                cubo3d1.colorSuelo(Csuelo);

                Console.WriteLine("NUMERO DE VENTANAS "+Nventanas+"///////////////////////////");
                for (int i = 0; i < datos.Count; i++)
                {

                    if (i == 0)
                    {
                        ArrayList temp = (ArrayList)datos[i];
                        double[] coor = (double[])temp[0];
                        String color = Convert.ToString(temp[1]);
                        cubo3d1.figura(coor, color, "panel1");

                        
                        if(Nventanas>=(i+1)){
                            cubo3d1.Ventana(creaVentana(coor), "modelova");
                        }else{
                        
                        }


                        if (Npuertas >= (i + 1))
                        {
                            cubo3d1.Puertas(creaPuerta(coor), "puerta0", Cpuetas[i]);
                        }
                        else
                        {

                        }




                    }
                    else if (i == 1)
                    {
                        ArrayList temp = (ArrayList)datos[i];
                        double[] coor = (double[])temp[0];
                        String color = Convert.ToString(temp[1]);
                        cubo3d1.figura(coor, color, "panel2");

                        if (Nventanas >= (i + 1))
                        {
                            cubo3d1.Ventana(creaVentana(coor), "modelovs");
                        }
                        else
                        {

                        }
                        if (Npuertas >= (i + 1))
                        {
                            cubo3d1.Puertas(creaPuerta(coor), "puerta1",Cpuetas[i]);
                        }
                        else
                        {

                        }
                        
                    }
                    else if (i == 2)
                    {
                        ArrayList temp = (ArrayList)datos[i];
                        double[] coor = (double[])temp[0];
                        String color = Convert.ToString(temp[1]);
                        cubo3d1.figura(coor, color, "panel3");

                        if (Nventanas >= (i + 1))
                        {
                            cubo3d1.Ventana(creaVentana(coor), "modelovd");
                        }
                        else
                        {

                        }
                        if (Npuertas >= (i + 1))
                        {
                            cubo3d1.Puertas(creaPuerta(coor), "puerta2", Cpuetas[i]);
                        }
                        else
                        {

                        }
                        
                    }
                    else if (i == 3)
                    {
                        ArrayList temp = (ArrayList)datos[i];
                        double[] coor = (double[])temp[0];
                        String color = Convert.ToString(temp[1]);
                        cubo3d1.figura(coor, color, "panel5");

                        if (Nventanas >= (i + 1))
                        {
                            cubo3d1.Ventana(creaVentana(coor), "modelovf");
                        }
                        else
                        {

                        }
                        if (Npuertas >= (i + 1))
                        {
                            cubo3d1.Puertas(creaPuerta(coor), "puerta3", Cpuetas[i]);
                        }
                        else
                        {

                        }
                        
                    }
                    else
                    { }
                }

            }else{
            //MOSTRAR PARA ERROR TIPO SINTACTICO

            }

            






        }


        private double[] creaVentana(double[] coor)
        {

            double resta = coor[0] - coor[9];
            double resta2 = coor[2] - coor[11];

            double abs = Math.Pow(Math.Pow(resta, 2), 0.5);//y
            double abs2 = Math.Pow(Math.Pow(resta2, 2), 0.5);//x
double[] arrays = new double[12];
            if (abs == 0)
            {
                //y cte
                
                double L1 = (abs2 * 0.5) / 2;
                double L2 = L1 + (abs2 * 0.5);

                double h1 = (coor[4] * 0.5) / 2;
                double h2 = h1 + (coor[4] * 0.5);


                Console.WriteLine(abs+"///////"+abs2);
                Console.WriteLine(L1);
                Console.WriteLine(L2);
                Console.WriteLine(h1);
                Console.WriteLine(h2);

                double constante = coor[0];
                if (constante == 0)
                {
                    constante = -0.01;
                }
                else
                {
                    constante = constante + 0.01;
                }


                arrays[0] = constante; //y
                arrays[1] = h1; //z
                arrays[2] = L1; //x

                arrays[3] = constante;
                arrays[4] = h1;
                arrays[5] = L2;

            

                arrays[6] = constante;
                arrays[7] = h2;
                arrays[8] = L2;

                arrays[9] = constante;
                arrays[10] = h2;
                arrays[11] = L1;


            }
            else if (abs2 == 0)
            {

                double L1 = (abs * 0.5) / 2;
                double L2 = L1 + (abs * 0.5);

                double h1 = (coor[4] * 0.5) / 2;
                double h2 = h1 + (coor[4] * 0.5);

                double constante = coor[2];
                if (constante == 0)
                {
                    constante = -0.01;
                }
                else {
                    constante = constante + 0.01;
                }

                arrays[0] = L1; //y
                arrays[1] = h1; //z
                arrays[2] = constante; //x


                arrays[3] = L1;
                arrays[4] = h2;
                arrays[5] = constante;

                arrays[6] = L2;
                arrays[7] = h2;
                arrays[8] = constante;

                arrays[9] = L2;
                arrays[10] = h1;
                arrays[11] = constante;


                

            }
            else
            {


            }


            return arrays;
        }


        private double[] creaPuerta(double[] coor)
        {

            double resta = coor[0] - coor[9];
            double resta2 = coor[2] - coor[11];

            double abs = Math.Pow(Math.Pow(resta, 2), 0.5);//y
            double abs2 = Math.Pow(Math.Pow(resta2, 2), 0.5);//x
            double[] arrays = new double[12];
            if (abs == 0)
            {
                //y cte

                double L1 = (abs2 * 0.61) / 2;
                double L2 = L1 + (abs2 * 0.39);

                double h1 = (coor[4] * 0.5) / 2;
                double h2 = h1 + (coor[4] * 0.5);


                Console.WriteLine(abs + "///////" + abs2);
                Console.WriteLine(L1);
                Console.WriteLine(L2);
                Console.WriteLine(h1);
                Console.WriteLine(h2);

                double constante = coor[0];
                if (constante == 0)
                {
                    constante = -0.01;
                }
                else
                {
                    constante = constante + 0.01;
                }


                arrays[0] = constante; //y
                arrays[1] = 0; //z
                arrays[2] = L1; //x

                arrays[3] = constante;
                arrays[4] = 0;
                arrays[5] = L2;



                arrays[6] = constante;
                arrays[7] = h2;
                arrays[8] = L2;

                arrays[9] = constante;
                arrays[10] = h2;
                arrays[11] = L1;


            }
            else if (abs2 == 0)
            {

                double L1 = (abs * 0.5) / 2;
                double L2 = L1 + (abs * 0.5);

                double h1 = (coor[4] * 0.5) / 2;
                double h2 = h1 + (coor[4] * 0.5);

                double constante = coor[2];
                if (constante == 0)
                {
                    constante = -0.01;
                }
                else
                {
                    constante = constante + 0.01;
                }

                arrays[0] = L1; //y
                arrays[1] = 0; //z
                arrays[2] = constante; //x


                arrays[3] = L1;
                arrays[4] = h2;
                arrays[5] = constante;

                arrays[6] = L2;
                arrays[7] = h2;
                arrays[8] = constante;

                arrays[9] = L2;
                arrays[10] = 0;
                arrays[11] = constante;




            }
            else
            {


            }


            return arrays;
        }

        private double[] creaSuelo(int ancho , int largo)
        {

            
            double[] arrays = new double[12];
            

                

                arrays[0] = -1.5; //y
                arrays[1] = 0; //z
                arrays[2] = -1.5; //x

                arrays[3] = largo+1.5;
                arrays[4] = 0;
                arrays[5] = -1.5;



                arrays[6] = ancho+1.5;
                arrays[7] = 0;
                arrays[8] = -1.5;

                arrays[9] = ancho+1.5;
                arrays[10] = 0;
                arrays[11] = largo+1.5;


           

            return arrays;
        }



        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        String rutaa = "nada";
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            String line = null; 

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.design)|*.design";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog1.FileName);
                 try
                {
                    rutaa = openFileDialog1.FileName;
                     String con= Path.ChangeExtension(openFileDialog1.FileName,".txt");
                     
                    File.Move(openFileDialog1.FileName,con);
                    StreamReader sr = new StreamReader(con);
                    line = sr.ReadLine();

                    Boolean salir = false;
                    int Conta = 0;
                    while (!salir)
                    {
                        //Console.WriteLine(linea + "-+-+-+-+-+-+-+-+-+-+-");
                        if (("".Equals(line)) || (line == null) || (String.IsNullOrEmpty(line)) || (" ".Equals(line)))
                        {
                            if (Conta == 5)
                            {
                                salir = true;
                            }
                            else
                            {
                                Conta++;
                            }
                            line = sr.ReadLine();
                        }
                        else
                        {
                            Conta = 0;
                            textBox1.Text += line + "\r\n";
                            Console.WriteLine(line + "556565");
                            line = sr.ReadLine();
                        }
                    }

                    sr.Close();


                    Console.ReadLine();
                    File.Move(con, openFileDialog1.FileName);
                }
                catch (Exception zxcv)
                {

                }
            }







            
            //try
            //{
                
            //    StreamReader sr = new StreamReader("C:\\Sample.txt");
            //    line = sr.ReadLine();

            //    while (line != null)
            //    {

            //        Console.WriteLine(line);
            //        line = sr.ReadLine();
            //    }

            //    sr.Close();
            //    Console.ReadLine();
            //}
            //catch (Exception e)
            //{
               
            //}
            
        }
        


        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "desing|*.design";
            saveFileDialog1.Title = "Guardar Archivo";
            saveFileDialog1.ShowDialog();


            if (saveFileDialog1.FileName != "")
            {


                System.IO.FileStream fs =
                      (System.IO.FileStream)saveFileDialog1.OpenFile();
                fs.Close();

                string dir = saveFileDialog1.FileName;

                String resultado = Path.ChangeExtension(dir, ".txt");


                String arreglo = (String)arregla(resultado);
                String arreglo2 = (String)arregla(dir);
                //try
                //{

                //Pass the filepath and filename to the StreamWriter Constructor

                Console.WriteLine(arreglo + "-------------------");

                File.Move(arreglo2, arreglo);


                rutaa = arreglo2;
                StreamWriter sw = new StreamWriter(arreglo);
                TextReader read = new System.IO.StringReader(textBox1.Text);
                String linea = read.ReadLine();

                Boolean salir = false;
                int Conta = 0;
                while (!salir)
                {

                    if (("".Equals(linea)) || (linea == null) || (String.IsNullOrEmpty(linea)) || (" ".Equals(linea)))
                    {
                        if (Conta == 5)
                        {
                            salir = true;
                        }
                        else
                        {
                            Conta++;
                        }
                        linea = read.ReadLine();
                    }
                    else
                    {
                        Conta = 0;
                        sw.WriteLine(linea);
                        linea = read.ReadLine();
                    }
                }

                sw.Close();


                File.Move(arreglo, arreglo2);

            }


            
        }



        public String arregla(String arregla)
        {
            String conatena = "";
            int contador = 0;


            while (contador < arregla.Length)
            {



                Char diagoi = '\\';
                switch (arregla[contador])
                {
                    case '\\':
                        Console.WriteLine("\\\\");
                        Console.WriteLine(arregla[contador]);
                        //conatena = conatena.Replace("\\","\\\\");
                        conatena = conatena + "\\";
                        conatena = conatena + "\\";
                        break;

                    default:
                        Console.WriteLine(diagoi);
                        Console.WriteLine(arregla[contador]);
                        conatena = conatena + arregla[contador];
                        break;

                }



                contador++;
            }
            Console.WriteLine(conatena + "*********");
            return conatena;

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (File.Exists(rutaa))
            {
                String resultado =Path.ChangeExtension(rutaa, ".txt");
                File.Move(rutaa, resultado);


                StreamWriter sw = new StreamWriter(resultado);
                TextReader read = new System.IO.StringReader(textBox1.Text);
                String linea = read.ReadLine();

                Boolean salir = false;
                int Conta = 0;
                while (!salir)
                {

                    if (("".Equals(linea)) || (linea == null) || (String.IsNullOrEmpty(linea)) || (" ".Equals(linea)))
                    {
                        if (Conta == 5)
                        {
                            salir = true;
                        }
                        else
                        {
                            Conta++;
                        }
                        linea = read.ReadLine();
                    }
                    else
                    {
                        Conta = 0;
                        sw.WriteLine(linea);
                        linea = read.ReadLine();
                    }
                }

                sw.Close();

                String resultado2 = Path.ChangeExtension(rutaa, ".design");
                File.Move(resultado, resultado2);


            }
            else {





                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "desing|*.design";
                saveFileDialog1.Title = "Guardar Archivo";
                saveFileDialog1.ShowDialog();


                if (saveFileDialog1.FileName != "")
                {


                    System.IO.FileStream fs =
                          (System.IO.FileStream)saveFileDialog1.OpenFile();
                    fs.Close();

                    string dir = saveFileDialog1.FileName;

                    String resultado = Path.ChangeExtension(dir, ".txt");
                    

                    String arreglo = (String)arregla(resultado);
                    String arreglo2 = (String)arregla(dir);
                    //try
                    //{

                    //Pass the filepath and filename to the StreamWriter Constructor

                    Console.WriteLine(arreglo + "-------------------");
                    
                    File.Move(arreglo2, arreglo);

                    
                    rutaa = arreglo2;
                    StreamWriter sw = new StreamWriter(arreglo);
                    TextReader read = new System.IO.StringReader(textBox1.Text);
                    String linea = read.ReadLine();

                    Boolean salir = false;
                    int Conta = 0;
                    while (!salir)
                    {

                        if (("".Equals(linea)) || (linea == null) || (String.IsNullOrEmpty(linea)) || (" ".Equals(linea)))
                        {
                            if (Conta == 5)
                            {
                                salir = true;
                            }
                            else
                            {
                                Conta++;
                            }
                            linea = read.ReadLine();
                        }
                        else
                        {
                            Conta = 0;
                            sw.WriteLine(linea);
                            linea = read.ReadLine();
                        }
                    }

                    sw.Close();


                    File.Move(arreglo, arreglo2);

                }



            
            }

        }

        


        public void html(ArrayList array)
        {


            int contador = 0;
            //--------------------------

            Console.WriteLine("ENTRO PARA LLENADO TABLA");
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "html|*.html";
            saveFileDialog1.Title = "Guardar Archivo";
            saveFileDialog1.ShowDialog();


            if (saveFileDialog1.FileName != "")
            {

                System.IO.FileStream fs =
                      (System.IO.FileStream)saveFileDialog1.OpenFile();
                fs.Close();

                string dir = saveFileDialog1.FileName;
                String arreglo = (String)arregla(dir);


                String resultado = Path.ChangeExtension(arreglo, ".txt");
                //File.Move(arreglo, resultado);



                salida = arreglo;
                StreamWriter sw = new StreamWriter(arreglo);

                //StreamWriter sw = new StreamWriter(resultado);
                

                


                //String estilo = " table {width: 100%;border: 1px solid #000;}th, td { width: 25%; text-align: left;vertical-align: top; border: 1px solid #000;   border-collapse: collapse;  padding: 0.3em;   caption-side: bottom;}caption {   padding: 0.3em;   color: #fff;    background: #000;}th {   background: #eee;}";


                String estilo = "table{position:absolute; border: 1px solid #000;border-collapse: collapse;font-family:century gothic';}";

                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<style type='text/css'>");
                sw.WriteLine(estilo);
                sw.WriteLine("</style>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<div id=data>");


                sw.WriteLine("<table class='egt' border=1px style='margin-left:250px;font-family:century gothic'>");
                sw.WriteLine("<tr><td colspan=6 align=center>SALIDA DE TOKENS</td></tr>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th scope='row'>#</th>");
                sw.WriteLine("<th>Nombre</th>");
                sw.WriteLine("<th>Fila</th>");
                sw.WriteLine("<th>Columna</th>");
                sw.WriteLine("<th>Token</th>");
                sw.WriteLine("<th>Nombre</th>");
                sw.WriteLine("</tr>");
                sw.WriteLine("<tr>");

                for (int i = 0; i < array.Count; i++)
                {
                    ArrayList temp = (ArrayList)array[i];
                    Console.WriteLine(temp[0] + "------------++++++++++++++++++++");
                    Console.WriteLine(temp[0] + " --- " + temp[1] + " --- " + temp[2] + " --- " + temp[3] + " --- " + temp[4]);

                    if (temp.Count>=5)
                    {
                        //tipo / token/ posiccionn o id seria i
                        Console.WriteLine( "------------////////////ESCRIBE//////////+");
                        sw.WriteLine("<th>  " + contador + "</th>");
                        sw.WriteLine("<td> " + temp[0] + "</td>");
                        sw.WriteLine("<td>" + temp[1] + "</td>");
                        sw.WriteLine("<td>" + temp[2] + "</td>");
                        sw.WriteLine("<td>" + temp[3] + "</td>");
                        sw.WriteLine("<td>" + temp[4] + "</td>");

                        sw.WriteLine("</tr>");
                        sw.WriteLine("<tr>");
                        contador++;
                        //sw.WriteLine("<th>Temperatura</th>");
                        //sw.WriteLine("<td>19°C</td>");
                        //sw.WriteLine("<td>17°C</td>");
                        //sw.WriteLine("<td>12°C</td>");
                        //sw.WriteLine("</tr>");
                        //sw.WriteLine("<tr>");

                        //sw.WriteLine("<th>Vientos</th>");
                        //sw.WriteLine("<td>E 13 km/h</td>");
                        //sw.WriteLine("<td>E 11 km/h</td>");
                        //sw.WriteLine("<td>S 16 km/h</td>");
                        ///sw.WriteLine(tabla[i]);
                    }
                    else
                    {
                        Console.WriteLine("------------////////////NO ESCRIBBE/////////+");
                    }
                }
                Console.WriteLine("------------////////////fin//////////+");
                sw.WriteLine("</tr>");
                sw.WriteLine("</table>");

                sw.Close();












                //sw.WriteLine("<table class='egt' border=1px style='margin-left:700px;font-family:century gothic'>");
                //sw.WriteLine("<tr><td colspan=4 align=center>titulo</td></tr>");
                //sw.WriteLine("<tr>");
                //sw.WriteLine("<th scope='row'>#</th>");
                //sw.WriteLine("<th>Fila</th>");
                //sw.WriteLine("<th>Columna</th>");
                //sw.WriteLine("<th>Caracter</th>");

                //sw.WriteLine("</tr>");
                //sw.WriteLine("<tr>");
                //contador = 0;
                //for (int i = 0; i < array.Count; i++)
                //{
                //    String temp = (String)array[i];
                //    Console.WriteLine(temp[0] + "------------++++++++++++++++++++");

                //    ArrayList tabla2 = Errores(temp);

                //    if (!(tabla2[0].Equals("error")))
                //    {
                //        //tipo / token/ posiccionn o id seria i
                //        Console.WriteLine(tabla2.Count + "--------------************//////////////");
                //        if (tabla2.Count > 2)
                //        {
                //            for (int j = 0; j < tabla2.Count; j += 2)
                //            {
                //                sw.WriteLine("<th>" + contador + "</th>");


                //                sw.WriteLine("<td>" + i + "</td>");

                //                sw.WriteLine("<td>" + tabla2[j] + "</td>");
                //                sw.WriteLine("<td>" + tabla2[j + 1] + "</td>");
                //                sw.WriteLine("</tr>");
                //                sw.WriteLine("<tr>");
                //                contador++;
                //            }
                //        }
                //        else
                //        {

                //            sw.WriteLine("<th>" + contador + "</th>");
                //            sw.WriteLine("<td>" + i + "</td>");
                //            sw.WriteLine("<td>" + tabla2[0] + "</td>");
                //            sw.WriteLine("<td>" + tabla2[1] + "</td>");

                //            sw.WriteLine("</tr>");
                //            sw.WriteLine("<tr>");
                //            contador++;


                //        }

                //        //sw.WriteLine("<th>Temperatura</th>");
                //        //sw.WriteLine("<td>19°C</td>");
                //        //sw.WriteLine("<td>17°C</td>");
                //        //sw.WriteLine("<td>12°C</td>");
                //        //sw.WriteLine("</tr>");
                //        //sw.WriteLine("<tr>");

                //        //sw.WriteLine("<th>Vientos</th>");
                //        //sw.WriteLine("<td>E 13 km/h</td>");
                //        //sw.WriteLine("<td>E 11 km/h</td>");
                //        //sw.WriteLine("<td>S 16 km/h</td>");
                //        ///sw.WriteLine(tabla[i]);
                //    }
                //    else
                //    {

                //    }
                //}
                //sw.WriteLine("</tr>");
                //sw.WriteLine("</table>");
                //sw.WriteLine("</div>");
                //sw.WriteLine("</body>");
                //sw.WriteLine("</html>");


                //





            }



        }

        private void tokensToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(File.Exists(salida)){
            Process.Start(salida);
            }
            
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
