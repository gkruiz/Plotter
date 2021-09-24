using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUD9._9
{
    class Analisis1
    {


        public ArrayList tokens = new ArrayList();

        public ArrayList lineT = new ArrayList();

        public ArrayList INFO = new ArrayList();
        public ArrayList Cpuertas = new ArrayList();
        public int Npuertas = 0;
        public int Nventanas = 0;
        public String Csuelo = "gray";






        public ArrayList Ctoken = new ArrayList();


        public ArrayList ERRORES = new ArrayList();


        int Cactivo = 0;
        String Cstring = "";
        int simpl = 0;

        
        ArrayList id ;



        int fila = 0;
        int columna = 0;




        public void error(String linea,int fila ) {


            ArrayList temps = new ArrayList();


            for (int i = 0; i < linea.Length;i++ )
            {
                String teporal = Convert.ToString(linea[i]);
                String respuesta = tipo(teporal);

                if(respuesta.Equals("Error")){
                    temps.Add(fila);
                    temps.Add(i);
                    temps.Add(teporal);
                    temps.Add("Lexico: Desconocido");
                    ERRORES.Add(temps);
                }else{
                
                }

            }
        
        }

        public void inicio(String linea)
        {

    
            id = new ArrayList();
           

            id.Add("nombre");
            id.Add("tipo");
            id.Add("valor");
            id.Add("ancho");
            id.Add("largo");
            id.Add("longitud");
            id.Add("color");
            id.Add("alto");
            id.Add("inicio");
            id.Add("fin");
            id.Add("pared_asociada");
            id.Add("radio");


            automata(linea, 0);
            



        }

       
        public String segun()
        {
            String err = "NO";
            sintactico sin = new sintactico();
            err = sin.inicio(lineT);
            if(err!="ERROR"){
                
                INFO = sin.Grafi();
        //        public ArrayList INFO = new ArrayList();
        //public ArrayList Cpuertas = new ArrayList();
        //public int Npuertas = 0;
        //public int Nventanas = 0;
        //public String Csuelo = "gray";
                Cpuertas = sin.Cpuertas();
                Npuertas = sin.noPuertas();
                Nventanas = sin.noVentanas();
                Csuelo = sin.Csuelo();



            }
            
            //Console.WriteLine("************************************" + sin.tabla.Count);
            //for (int k = 0; k < sin.tabla.Count; k++)
            //{
            //    ArrayList temp = (ArrayList)sin.tabla[k];

            //    Console.WriteLine(temp[0] + " /" + temp[1] + "************************************");
            //}
            return err;
        }

        public ArrayList GetDatos() {

            return INFO;
        }


        private void automata(String linea, int posicion)
        {







            if ((linea).Equals(null))
            {

            }
            else
            {





                if (posicion > (linea.Length - 1))
                {
                    if (tokens.Count == 0)
                    {

                    }
                    else
                    {
                        lineT.Add(tokens);
                        tokens = new ArrayList();
                    }

                }
                else
                {



                    if (Cactivo == 1)
                    {

                        if ((linea.Trim()).Equals(""))
                        {

                        }
                        else
                        {
                            String poslinea = linea.Trim();
                            String tipoc = tipo(Convert.ToString(poslinea[posicion]));

                            comentario(poslinea, 0, "");


                        }




                    }
                    else
                    {
                        if ((linea.Trim()).Equals(""))
                        {

                        }
                        else
                        {
                            String poslinea = linea.Trim();
                            String tipoc = tipo(Convert.ToString(poslinea[posicion]));
                            if (posicion > (poslinea.Length - 1))
                            {

                            }
                            else
                            {


                                Console.WriteLine(tipoc);
                                switch (tipoc)
                                {
                                    case "letra":
                                        letra(poslinea, posicion, "");


                                        break;
                                    case "numero":
                                        numero(poslinea, posicion, "", 0);

                                        break;
                                    case "gionb":
                                        tokens.Add("_");
                                        automata(poslinea, posicion + 1);
                                        break;
                                    case "punto":
                                        tokens.Add(".");
                                        automata(poslinea, posicion + 1);
                                        break;
                                    case "diagonal":
                                        tokens.Add("/");
                                        automata(poslinea, posicion + 1);
                                        break;
                                    case "exclamacion":
                                        tokens.Add("!");
                                        automata(poslinea, posicion + 1);
                                        break;
                                    case "guionn":
                                        tokens.Add("-");
                                        automata(poslinea, posicion + 1);
                                        break;
                                    case "menor":
                                        Console.WriteLine("va analizar " + poslinea);
                                        menorque(poslinea, posicion, "");



                                        break;
                                    case "mayor":
                                        tokens.Add(">");
                                        automata(poslinea, posicion + 1);
                                        break;
                                    case "asterisco":
                                        tokens.Add("*");
                                        automata(poslinea, posicion + 1);
                                        break;
                                    case "mas":
                                        tokens.Add("+");
                                        automata(poslinea, posicion + 1);
                                        break;
                                    case "exponente":
                                        tokens.Add("^");
                                        automata(poslinea, posicion + 1);
                                        break;
                                    case "puntoycoma":
                                        tokens.Add(";");
                                        automata(poslinea, posicion + 1);
                                        break;
                                    case "dospuntos":
                                        tokens.Add(":");
                                        automata(poslinea, posicion + 1);
                                        break;
                                    case "espacio":

                                        automata(poslinea, posicion + 1);
                                        break;
                                    case "coma":
                                        tokens.Add(",");
                                        automata(poslinea, posicion + 1);
                                        break;
                                    case "comilla":
                                        tokens.Add('"');
                                        automata(poslinea, posicion + 1);
                                        break;
                                    default:
                                        automata(poslinea, posicion + 1);
                                        break;
                                }
                            }


                        }

                    }



                }












            }




        }

        
        public ArrayList Stokens() {





            if (lineT.Count == 0)
            {
        //vacio
        }else{

            for (int i = 0; i < lineT.Count; i++)
            {
                ArrayList temp = (ArrayList)lineT[i];
                for (int j = 0; j < temp.Count; j++)
                {

                    String celda = ts(temp[j]);

                    switch (celda)
                    {
                        case "letra":
                            for (int k = 0; k < id.Count; k++) { 
                            if(Convert.ToString(id[k]).Equals(Convert.ToString(temp[j]))){
                                met(Convert.ToString(temp[j]), "Palbra Reservada", i, j, "texto");
                                break;
                            }else{
                            if(k==(id.Count-1)){
                                met(Convert.ToString(temp[j]), "Valor", i, j, "texto");
                            }


                            }

                            }
                            


                            break;
                        case "numero":
                            met(Convert.ToString(temp[j]), celda, i, j, "numero");

                            break;
                        case "gionb":
                            tokens.Add("_");
                            met(Convert.ToString(temp[j]), celda, i, j, "signo");
                            break;
                        case "punto":
                            tokens.Add(".");
                            met(Convert.ToString(temp[j]), celda, i, j, "signo");
                            break;
                        case "diagonal":
                            tokens.Add("/");
                            met(Convert.ToString(temp[j]), celda, i, j, "operador");
                            break;
                        case "exclamacion":
                            tokens.Add("!");
                            met(Convert.ToString(temp[j]), celda, i, j, "signo");
                            break;
                        case "guionn":
                            tokens.Add("-");
                            met(Convert.ToString(temp[j]), celda, i, j, "operador");
                            break;
                        case "menor":
                            

                           if(Convert.ToString(temp[j]).Length>1){
                               //Console.WriteLine(temp[j]+" ////////////////////////£££££££££££££££££££££££££££££££££££££££££££");
                               String cos = "";
                               String tems = Convert.ToString(temp[j]);
                               for (int k = 1; k < tems.Length-1; k++) {
                                   cos = cos + tems[k];
                               }

                               met(Convert.ToString("&#60" + cos + "&#62"), "Etiqueta", i, j, "texto");
                                
                            }else{

                                met(Convert.ToString("&#60"), "Menor", i, j, "texto");
                            }

                            break;
                        case "mayor":
                            tokens.Add(">");
                            met(Convert.ToString("&#62"), celda, i, j, "signo");
                            break;
                        case "asterisco":
                            tokens.Add("*");
                            met(Convert.ToString(temp[j]), celda, i, j, "operador");
                            break;
                        case "mas":
                            tokens.Add("+");
                            met(Convert.ToString(temp[j]), celda, i, j, "operador");
                            break;
                        case "exponente":
                            tokens.Add("^");
                            met(Convert.ToString(temp[j]), celda, i, j, "operador");
                            break;
                        case "puntoycoma":
                            tokens.Add(";");
                            met(Convert.ToString(temp[j]), celda, i, j, "signo");
                            break;
                        case "dospuntos":
                            tokens.Add(":");
                            met(Convert.ToString(temp[j]), celda, i, j, "signo");
                            break;
                        case "espacio":

                            //automata(poslinea, posicion + 1);
                            break;
                        case "coma":

                            met(Convert.ToString(temp[j]), celda, i, j, "signo");
                            break;
                        case "comilla":

                            met(Convert.ToString(temp[j]), celda, i, j, "signo");
                            break;
                        default:
                            
                            break;
                    }


                }
            }



            


        
        }

            return Ctoken;
        }

        private String ts(Object linea)
        {
            String trae = Convert.ToString(linea);

            String regre = tipo(Convert.ToString(trae[0]));

            return regre;

        }



        private void met(String token, String nombre ,int fila , int columna,String tipo) {
           // Console.WriteLine(" -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*--  " );
          //  Console.WriteLine(token+" "+nombre+" "+fila+" "+columna+" "+tipo);
          //  Console.WriteLine(" -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*--  ");
            ArrayList otro = new ArrayList();

            //
            otro.Add(token);
            otro.Add(fila);
            otro.Add(columna);
            otro.Add(tipo);
            otro.Add(nombre);


            Ctoken.Add(otro);

        }



        private void letra(String linea, int posicion, String concatenado)
        {
            String conca;
            if (posicion == 0)
            {
                conca = "";
            }
            else
            {
                conca = concatenado;
            }


            if (posicion > (linea.Length - 1))
            {
                if (tokens.Count == 0)
                {

                }
                else
                {
                    lineT.Add(tokens);
                    tokens = new ArrayList();
                }
            }
            else
            {

                String tipoc = tipo(Convert.ToString(linea[posicion]));
                switch (tipoc)
                {
                    case "letra":
                        conca = conca + linea[posicion];
                        if (posicion == (linea.Length - 1))
                        {
                            tokens.Add(conca);
                        }
                        else { }
                        letra(linea, posicion + 1, conca);
                        break;
                    case "numero":
                        conca = conca + linea[posicion];
                        if (posicion == (linea.Length - 1))
                        {
                            tokens.Add(conca);
                        }
                        else { }
                        letra(linea, posicion + 1, conca);
                        break;
                    case "guionb":
                        conca = conca + linea[posicion];
                        if (posicion == (linea.Length - 1))
                        {
                            tokens.Add(conca);
                        }
                        else { }
                        letra(linea, posicion + 1, conca);
                        break;
                    default:

                        //conca = conca + linea[posicion];

                        tokens.Add(conca);

                        automata(linea, posicion);
                        //pero continua analisis
                        //error en linea
                        break;
                }

            }

        }

        private void menorque(String linea, int posicion, String concatenado)
        {
            simpl = 0;


            if (posicion > (linea.Length - 1))
            {
                if (tokens.Count == 0)
                {

                }
                else
                {
                    lineT.Add(tokens);
                    tokens = new ArrayList();
                }
            }
            else
            {
                Console.WriteLine("inicio " + linea);


                if (linea.Length > 1)
                {
                    Console.WriteLine("linea tama;o mayor a uno ");
                    String tipoc = "wer";
                    Console.WriteLine("bandera uno");
                    if(posicion==(linea.Length-1)){
                    
                    }else{
                        tipoc = tipo(Convert.ToString(linea[posicion + 1]));
                    }
                    

                    String uno = Convert.ToString(Convert.ToString(linea[posicion]));



                    switch (tipoc)
                    {
                        case "exclamacion":

                            comentario(linea, posicion + 1, uno);
                            break;
                        case "letra":
                            etiqueta(linea, posicion + 1, uno);


                            break;
                        case "diagonal":

                            try
                            {


                                //Console.WriteLine("paso cathc-------+-+-+" + linea[posicion + 2]);
                                if (tipo(Convert.ToString(linea[posicion + 2])).Equals("letra"))
                                {
                                    simpl = 1;
                                    etiqueta(linea, posicion + 2, uno + linea[posicion + 1]);


                                }
                                else
                                {
                                    tokens.Add(uno);
                                    automata(linea, posicion + 1);

                                }

                            }
                            catch
                            {
                                Console.WriteLine("paso cathc-------+-+-+");
                                tokens.Add(uno);
                                automata(linea, posicion + 1);
                            }




                            break;
                        default:
                            tokens.Add(uno);
                            automata(linea, posicion + 1);
                            //pero continua analisis
                            //error en linea
                            break;
                    }


                }
                else
                {
                    Console.WriteLine("bandera cero");
                    tokens.Add(Convert.ToString(linea[0]));
                    automata(linea, posicion + 1);

                }










            }

        }

        private void comentario(String linea, int posicion, String concatenado)
        {



            if (posicion > (linea.Length - 1))
            {




                if (tokens.Count == 0)
                {

                }
                else
                {
                    lineT.Add(tokens);
                    tokens = new ArrayList();
                }
            }
            else
            {
                if (Cactivo == 1)
                {


                    String conca = concatenado;

                    for (int i = 0; i < linea.Length; i++)
                    {
                        String tipoc = tipo(Convert.ToString(linea[i]));
                        if (tipoc.Equals("Error"))
                        {

                        }
                        else if (tipoc.Equals("guionn"))
                        {

                            if ((i + 2) <= linea.Length)
                            {
                                if ((Convert.ToString(linea[i + 1]).Equals("-")) && (Convert.ToString(linea[i + 2]).Equals(">")))
                                {
                                    //conca = conca + linea[i] + linea[i + 1] + linea[i + 2];
                                    //tokens.Add(conca);
                                    conca = "";
                                    Cactivo = 0;
                                    automata(linea, i + 3);

                                }
                                else
                                {
                                    conca = conca + linea[i];

                                }

                            }
                            else
                            {

                                conca = conca + linea[i];
                                // Cactivo = 1;

                            }

                        }
                        else
                        {
                            conca = conca + linea[i];

                        }

                    }

                    if (Cactivo == 1)
                    {
                        Cstring = conca;
                    }
                    else
                    {

                    }




                }
                else
                {

                    Console.WriteLine("EVALUA SUPUESTAMENTE " + linea[posicion]);
                    Console.WriteLine("EVALUA SUPUESTAMENTE " + linea[posicion+1]);
                    Console.WriteLine("EVALUA SUPUESTAMENTE " + linea[posicion+2]);
                    if (linea.Length >= 4)
                    {
                        if ((Convert.ToString(linea[posicion]).Equals("!")) && (Convert.ToString(linea[posicion + 1]).Equals("-")) && (Convert.ToString(linea[posicion + 2]).Equals("-")))
                        {
                            String conca = concatenado;
                            Cactivo = 1;


                            if (posicion == (linea.Length - 1))
                            {

                            }
                            else {

                                for (int i = posicion; i < linea.Length; i++)
                                {
                                    String tipoc = tipo(Convert.ToString(linea[i]));
                                    if (tipoc.Equals("Error"))
                                    {

                                    }
                                    else if (tipoc.Equals("-"))
                                    {

                                        if ((i + 2) <= linea.Length)
                                        {
                                            if ((linea[i + 1].Equals("-")) && (linea[i + 2].Equals(">")))
                                            {
                                                conca = conca + linea[i] + linea[i + 1] + linea[i + 2];
                                                tokens.Add(conca);
                                                conca = "";
                                                Cactivo = 0;
                                                automata(linea, i + 2);

                                            }
                                            else
                                            {
                                                conca = conca + linea[i];

                                            }

                                        }
                                        else
                                        {

                                            conca = conca + linea[i];
                                            // Cactivo = 1;

                                        }

                                    }
                                    else
                                    {
                                        conca = conca + linea[i];

                                    }

                                }

                                if (Cactivo == 1)
                                {
                                    Cstring = conca;
                                }
                                else
                                {

                                }
                            }

                        }
                        else
                        {
                            tokens.Add("<");
                            automata(linea, posicion);


                        }


                    }
                    else
                    {
                        tokens.Add("<");
                        automata(linea, posicion);
                        //error <!- solo eso podria teer
                    }





                }







            }

        }

        private void etiqueta(String linea, int posicion, String concatenado)
        {
            String conca;
            if (posicion == 0)
            {
                conca = "";
            }
            else
            {
                conca = concatenado;
            }
            //Console.WriteLine("valor concatenado " + concatenado);






            if (posicion > (linea.Length - 1))
            {
                if (tokens.Count == 0)
                {

                }
                else
                {
                    lineT.Add(tokens);
                    tokens = new ArrayList();
                }
            }
            else
            {



                int bandera = 0;
                for (int i = 0; i < linea.Length; i++)
                {
                    if (tipo(Convert.ToString(linea[i])).Equals("mayor"))
                    {
                        bandera = 1;

                        if (linea.Length >= 3)
                        {
                            int pos = 0;

                            for (int j = 0; j < linea.Length; j++)
                            {


                                if (((tipo(Convert.ToString(linea[j])).Equals("menor"))))
                                {
                                    pos = j;
                                    break;
                                }
                                else
                                {

                                }
                            }
                            //Console.WriteLine("bander entro -----hasta-------" + (i));
                           // Console.WriteLine("bander entro ------desde------" + (pos + 2));



                            for (int j = pos + 2; j < i; j++)
                            {

                                //  Console.WriteLine("analiza dentro de etiqueta " + linea[j]);
                                if (((!tipo(Convert.ToString(linea[j])).Equals("letra"))))
                                {
                                    bandera = 0;
                                    break;
                                }
                                else
                                {

                                }
                            }

                        }
                        else
                        {

                        }



                        break;
                    }
                    else
                    {

                    }
                }








                // Console.WriteLine("valor de bandera " + bandera);

                if (bandera == 1)
                {




                    String tipoc = tipo(Convert.ToString(linea[posicion]));


                    switch (tipoc)
                    {
                        case "letra":
                            conca = conca + linea[posicion];
                            if (posicion == (linea.Length - 1))
                            {
                                tokens.Add(conca);
                                //  Console.WriteLine("entro final " + concatenado);
                            }
                            else { //Console.WriteLine("no final " + concatenado);
                            }
                            etiqueta(linea, posicion + 1, conca);
                            break;
                        case "mayor":
                            conca = conca + linea[posicion];
                            // Console.WriteLine("valor cctena " + conca);
                            tokens.Add(conca);
                            conca = "";

                            automata(linea, posicion + 1);
                            break;
                        default:

                            //conca = conca + linea[posicion];

                            tokens.Add(conca);

                            automata(linea, posicion);
                            //pero continua analisis
                            //error en linea
                            break;
                    }



                }
                else
                {



                    if (simpl == 0)
                    {
                        Console.WriteLine("menora uno+++++++++++++++++++++88++++++++++++++++++++++++" + linea);
                        Console.WriteLine("menora uno++++++++++++++++++++++//+++++++++++++++++++++++" + posicion);

                        //Console.WriteLine("menora uno----------------------------------------");
                        String uno = Convert.ToString(linea[posicion - 1]);
                        tokens.Add(uno);
                        automata(linea, posicion);

                    }
                    else
                    {

                        Console.WriteLine("menora uno+++++++++++++++++++++++++++++++++++++++++++++" + linea);
                        Console.WriteLine("menora uno+++++++++++++++++++++++++++++++++++++++++++++" + posicion);
                        //for (int i = 0; i < linea.Length; i++)
                        //{
                            
                        //    Console.WriteLine("men" + tokens[i]);
                        //}


                        String uno = Convert.ToString(linea[posicion - 1]);
                        tokens.Add(Convert.ToString(linea[posicion - 2]));
                        //Console.WriteLine(uno);
                        Console.WriteLine(linea[posicion - 2]);
                        Console.WriteLine(linea[posicion - 2]);
                        tokens.Add(uno);
                        simpl = 0;
                        automata(linea, posicion - 1);


                    }





                }







            }

        }


        private void numero(String linea, int posicion, String concatenado, int estado)
        {
            String conca;
            if (posicion == 0)
            {
                conca = "";
            }
            else
            {
                conca = concatenado;
            }


            if (posicion > (linea.Length - 1))
            {
                if (tokens.Count == 0)
                {

                }
                else
                {
                    lineT.Add(tokens);
                    tokens = new ArrayList();
                }
            }
            else
            {

                String tipoc = tipo(Convert.ToString(linea[posicion]));
                switch (tipoc)
                {
                    case "numero":

                        conca = conca + linea[posicion];
                        if (posicion == (linea.Length - 1))
                        {
                            tokens.Add(conca);
                        }
                        else { }
                        numero(linea, posicion + 1, conca, estado);



                        break;
                    case "punto":
                        if (estado == 0)
                        {

                            if (posicion == (linea.Length - 1))
                            {
                                tokens.Add(conca);
                                tokens.Add(".");
                            }
                            else
                            {

                                Console.WriteLine("va a ver si es " + linea[posicion + 1]);
                                if (tipo(Convert.ToString(linea[posicion + 1])).Equals("numero"))
                                {
                                    conca = conca + linea[posicion];

                                    numero(linea, posicion + 1, conca, 1);

                                }
                                else
                                {

                                    tokens.Add(conca);

                                    automata(linea, posicion);

                                }



                            }



                        }
                        else
                        {



                            tokens.Add(conca);
                            automata(linea, posicion);


                        }




                        break;

                    default:

                        //conca = conca + linea[posicion];

                        tokens.Add(conca);

                        automata(linea, posicion);
                        //pero continua analisis
                        //error en linea
                        break;
                }

            }

        }



        private String tipo(String caracter)
        {

            String carac = caracter;
            String[] letras = new String[] { "Á", "É", "Í", "Ó", "Ú", "á", "é", "í", "ó", "ú", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };
            String[] numeros = new String[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            //Console.WriteLine("itera " + caracter);

            String tipo = "Error";

            for (int i = 0; i < letras.Length; i++)
            {
                if (caracter.Equals(letras[i]))
                {
                    carac = "letra";
                    break;
                }
                else { }
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                if (caracter.Equals(numeros[i]))
                {
                    carac = "numero";
                    break;
                }
                else { }
            }


            switch (carac)
            {
                case " ":
                    tipo = "espacio";
                    break;
                case "letra":
                    tipo = "letra";
                    break;
                case ",":
                    tipo = "coma";
                    break;
                case "numero":
                    tipo = "numero";
                    break;
                case "_":
                    tipo = "guionb";
                    break;
                case ".":
                    tipo = "punto";
                    break;
                case "/":
                    tipo = "diagonal";
                    break;
                case "!":
                    tipo = "exclamacion";
                    break;
                case "-":
                    tipo = "guionn";
                    break;
                case "<":
                    tipo = "menor";
                    break;
                case ">":
                    tipo = "mayor";
                    break;
                case "*":
                    tipo = "asterisco";
                    break;
                case "+":
                    tipo = "mas";
                    break;
                case "^":
                    tipo = "exponente";
                    break;
                case ";":
                    tipo = "puntoycoma";
                    break;
                case ":":
                    tipo = "dospuntos";
                    break;
                case "=":
                    tipo = "igual";
                    break;
                default:
                    if (Convert.ToChar(carac).Equals('"'))
                    {
                        tipo = "comilla";
                    }
                    else { 
                    //singo desconocido
                    
                    
                    }
                    
                    break;


            }
            //Console.WriteLine(tipo + "+++++");

            return tipo;
        }



       


    }
}
