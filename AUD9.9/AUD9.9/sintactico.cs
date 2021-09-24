using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUD9._9
{
    class sintactico
    {
        ArrayList e;

        ArrayList id;

        public ArrayList tabla;


        ArrayList totemps;


        ArrayList variables = new ArrayList();

        ArrayList paredes = new ArrayList();


        public ArrayList ERRORES = new ArrayList();


        

        int fila = 0;



         int ventanas = 0;
         int puertas = 0;
         String colors = "gray";
         ArrayList colopuertas = new ArrayList();
         int anchos = 0;
         int largos = 0;


        public sintactico()
        {

            e = new ArrayList();
            id = new ArrayList();
            tabla = new ArrayList();
            e.Add("<variables>");
            e.Add("</variables>");

            e.Add("<construccion>");
            e.Add("</construccion>");

            e.Add("<terreno>");
            e.Add("</terreno>");

            e.Add("<pared>");
            e.Add("</pared>");

            e.Add("<ventana>");
            e.Add("</ventana>");

            e.Add("<puerta>");
            e.Add("</puerta>");

            e.Add("<suelo>");
            e.Add("</suelo>");

            e.Add("<diseño>");
            e.Add("</diseño>");

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

        }



        public String inicio(ArrayList tokens)
        {
            String err = "NO";
            for (int k = 0; k < tokens.Count; k++)
            {
                ArrayList temp = (ArrayList)tokens[k];
                for (int j = 0; j < temp.Count; j++)
                {
                    Console.Write(temp[j] + "---");
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }



            err=Analisis(tokens);
            Console.WriteLine(err+"-/-*-/-*/-11*/-*/-*/+++++++++++++++++++++++++++++++++++++++++++++++++");
            err=cierres();
            Console.WriteLine(err + "-/-*-/-*22/-*/-*/-*//////////////////////////////////////////////");
            err=orden();
            Console.WriteLine(err + "-/-*-/-*333/-*/-*/-*/");
            ///////////////identifica(tokens);


            Console.WriteLine("************************************" + tabla.Count);
            //for (int k = 0; k < tabla.Count; k++)
            //{
            //    ArrayList temp = (ArrayList)tabla[k];

            //    Console.WriteLine(temp[0] + " tipo> " + temp[1]);
            //}

            for (int k = 0; k < ERRORES.Count; k++)
            {
                ArrayList temp = (ArrayList)ERRORES[k];

                Console.WriteLine(temp[0] + " ti@@@@@@@@@@@@@@@@@@@'po> " + temp[1]+" "+temp[2]+" "+temp[3]+"-------------------------------------------------");
            }




            //if (Convert.ToString(linea[2]).Equals("numero") || Convert.ToString(linea[2]).Equals("letra"))
            //{
            //    meteerror(fila, 3, linea[3], ";");

            //}
            //else
            //{
            //    meteerror(fila, 2, linea[2], "una Asignacion");
            //}

            return err;
        }

       




        private void mete(ArrayList temp, int tam) {
            ArrayList tip = new ArrayList();

            
            tip.Add(temp[0]);
            tip.Add("identificador");
            tabla.Add(tip);
            tip = new ArrayList();

            tip.Add(temp[1]);
            tip.Add("asigna");
            tabla.Add(tip);
            tip = new ArrayList();

            tip.Add(temp[2]);
            tip.Add("valor");
            tabla.Add(tip);
            tip = new ArrayList();
            
            if(tam==4){
                tip.Add(";");
                tip.Add("final");
                tabla.Add(tip);
                tip = new ArrayList();
            }else{
              
            }
        
        
        }
        private void coorde(ArrayList temp, int tam)
        {
            ArrayList tip = new ArrayList();


            tip.Add(temp[0]);
            tip.Add("identificador");
            tabla.Add(tip);
            tip = new ArrayList();

            tip.Add(temp[1]);
            tip.Add("asigna");
            tabla.Add(tip);
            tip = new ArrayList();


            tip.Add(temp[2]);
            tip.Add("valor");
            tabla.Add(tip);
            tip = new ArrayList();


            tip.Add(temp[3]);
            tip.Add("separa");
            tabla.Add(tip);
            tip = new ArrayList();


            tip.Add(temp[4]);
            tip.Add("valor");
            tabla.Add(tip);
            tip = new ArrayList();



            

            if (tam == 6)
            {
                tip.Add(";");
                tip.Add("final");
                tabla.Add(tip);
                tip = new ArrayList();
            }
            else
            {
                
            }


        }
        private void mete2(ArrayList temp, int tam,String valor)
        {
            ArrayList tip = new ArrayList();


            tip.Add(temp[0]);
            tip.Add("identificador");
            tabla.Add(tip);
            tip = new ArrayList();

            tip.Add(temp[1]);
            tip.Add("asigna");
            tabla.Add(tip);
            tip = new ArrayList();

            tip.Add(valor);
            tip.Add("valor");
            tabla.Add(tip);
            tip = new ArrayList();

            if (tam == 4)
            {
                tip.Add(";");
                tip.Add("final");
                tabla.Add(tip);
                tip = new ArrayList();
            }
            else
            {
                
            }


        }








        private String Analisis(ArrayList lista)
        {
            String err = "NO";
            totemps = lista;
            for (int i = 0; i < lista.Count; i++)
            {
                ArrayList temporal = (ArrayList)lista[i];

                String respueta = Convert.ToString(temporal[0]).Trim();
                
                

               // Console.WriteLine("saca " + respueta);
                switch (respueta)
                {
                    case "nombre":
                        if(err.Equals("ERROR")){
                            texto(temporal);
                        }else{
                            err=texto(temporal);
                        }
                        
                        Console.WriteLine(i+"errrr  " + err);
                        break;
                    case "tipo":
                        if (err.Equals("ERROR"))
                        {
                            texto(temporal);
                        }
                        else { err = texto(temporal);
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "valor":
                        String respueta2 = Convert.ToString(temporal[2]).Trim();
                        ArrayList temporal2 = (ArrayList)lista[i-1];
                        String tipo = Convert.ToString(temporal2[2]);
                        Console.WriteLine("asdf---------------------------asdf "+tipo);
                        Console.WriteLine("asdf---------------------------asdf " + respueta2[0]);
                        if (ts(respueta2[0]).Equals("numero"))
                        {
                            if (err.Equals("ERROR"))
                            {
                                numero(temporal, 0, tipo);
                            }
                            else
                            {
                                err = numero(temporal, 0, tipo);
                            }
                            
                            Console.WriteLine(i + "errrr  " + err);
                        }
                        else if (ts(respueta2[0]).Equals("letra"))
                        {
                            if (err.Equals("ERROR"))
                            {
                                numero(temporal, 0, tipo);
                            }
                            else
                            {err = numero(temporal, 0, tipo);
                            }
                            
                            Console.WriteLine(i + "errrr  " + err);
                        }
                        else if (ts(respueta2[0]).Equals("comilla"))
                        {
                            if (err.Equals("ERROR"))
                            {
                                comillas(temporal);
                            }
                            else
                            {err = comillas(temporal);
                            }
                            Console.WriteLine("asdf---------------------------asdf");
                            
                            Console.WriteLine(i + "errrr  " + err);
                        }
                        else
                        {
                            err = "ERROR";
                            Console.WriteLine("asdfasdf");
                            //errror 
                        }
                        break;
                    case "color":
                        if (err.Equals("ERROR"))
                        {
                            texto(temporal);
                        }
                        else
                        { err = texto(temporal);
                        }
                       
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "pared_asociada":
                        if (err.Equals("ERROR"))
                        {
                            texto(temporal);
                        }
                        else
                        {err = texto(temporal);
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "radio":
                        if (err.Equals("ERROR"))
                        {
                            numero(temporal, 0, "nada");
                        }
                        else
                        {err = numero(temporal, 0, "nada");
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "ancho":
                        if (err.Equals("ERROR"))
                        {
                            numero(temporal, 0, "nada");
                        }
                        else
                        {err = numero(temporal, 0, "nada");
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "largo":
                        if (err.Equals("ERROR"))
                        {
                            numero(temporal, 0, "nada");
                        }
                        else
                        {
                            err = numero(temporal, 0, "nada");
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "longitud":
                        if (err.Equals("ERROR"))
                        {
                            numero(temporal, 0, "nada");
                        }
                        else
                        {err = numero(temporal, 0, "nada");
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "alto":
                        if (err.Equals("ERROR"))
                        {
                            numero(temporal, 0, "nada");
                        }
                        else
                        {err = numero(temporal, 0, "nada");
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "inicio":
                        if (err.Equals("ERROR"))
                        {
                            numero(temporal, 0, "nada");
                        }
                        else
                        { err = numero(temporal, 0, "nada");
                        }
                       
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "fin":
                        if (err.Equals("ERROR"))
                        {
                            numero(temporal, 0, "nada");
                        }
                        else
                        {err = numero(temporal, 0, "nada");
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    default:
                        if (temporal.Count == 1)
                        {
                            if (err.Equals("ERROR"))
                            {
                                etiquetas(temporal);
                            }
                            else
                            {err = etiquetas(temporal);
                            }
                            
                            Console.WriteLine(i + "errrr  " + err);
                        }
                        else
                        {
                            err = "ERROR";

                        }
                        Console.WriteLine("NO INICIA CON NINGUN CONOCIDO");
                        break;

                }



            }

            Console.WriteLine(err+"6666666666666666666");


            return err;
        }

        private String texto(ArrayList linea) {
            String err="NO";

            Console.WriteLine("ingreso a texto" +linea[2]);
        if(linea.Count==3){
                    if(Convert.ToString(linea[1]).Equals(":")&&(ts(linea[2]).Equals("letra"))){
                        Console.WriteLine("letraletraletra");
                            mete(linea, 3);
                    }else{
                        Console.WriteLine("6565656565");
                        err = "ERROR";
                    //error
                    }

        }
        else if (linea.Count == 4)
        {
            if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("letra")) &&Convert.ToString(linea[3]).Equals(";"))
                    {
                        mete(linea, 4);
                    }
                    else
                    {
                        Console.WriteLine("6565888888888777656565");
                        err = "ERROR";
                        //error
                    }
        }
        else
        {
            Console.WriteLine("656asdfasdf555 666   5656565");
            err = "ERROR";
            //error
        }
        return err;
        }
        private String numero(ArrayList linea,int erro,String tipo)
        {
            String err = "NO";
            if (linea.Count == 3)
            {
                if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("numero")))
                {
                    String lin =Convert.ToString(linea[2]);
                    int ban = 0;
                    //Console.WriteLine("saca "+lin);
                    for(int i=0;i<lin.Length;i++){
                    
                        if(Convert.ToString(lin[i]).Equals(".")){
                        ban=1;
                        break;
                        }else{
                        }
                    }

                    if(tipo.Equals("entero")&&(ban==1)){
                        err = "ERROR";
                    }else
                    {
                        mete(linea, 3);
                    
                    }
                    

                }
                else if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("letra")))
                {
                    mete(linea, 3);
                }
                else
                {
                    err = "ERROR";
                    //error
                }

            }
            else if (linea.Count == 4)
            {
                if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("numero")) &&Convert.ToString( linea[3]).Equals(";"))
                {

                    String lin = Convert.ToString(linea[2]);
                    int ban = 0;
                   // Console.WriteLine("saca " + lin);
                    for (int i = 0; i < lin.Length; i++)
                    {

                        if (Convert.ToString(lin[i]).Equals("."))
                        {
                            ban = 1;
                            break;
                        }
                        else
                        {
                        }
                    }

                    if (tipo.Equals("entero") && (ban == 1))
                    {
                        err = "ERROR";
                    }
                    else
                    {
                        mete(linea, 4);

                    }

                    //mete(linea, 4);
                }
                else if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("letra")) && Convert.ToString(linea[3]).Equals(";"))
                {
                    mete(linea, 4);
                }
                else
                {
                    err = "ERROR";
                    //error
                }
            }
            else if ((linea.Count == 5)&&(erro==0))
            {
                if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("numero")) && Convert.ToString(linea[3]).Equals(",") && (ts(linea[4]).Equals("numero")))
                {
                   // mete(linea, 4);
                    coorde(linea, 5);
                }
               
                else
                {
                    numero(linea, 1,tipo);
                    //err = "ERROR";
                    //error
                }
            }
            else if ((linea.Count == 6) && (erro == 0))
            {
                if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("numero")) &&Convert.ToString( linea[3]).Equals(",") && (ts(linea[4]).Equals("numero")) && (Convert.ToString(linea[5]).Equals(";")))
                {
                    coorde(linea,6);
                }
                
                else
                {
                    numero(linea, 1,tipo);

                    //error
                }
            }
            else
            {
                if(linea.Count>=3){

                    String opero = opera(linea);
                    Console.WriteLine(opero+"-------------------****************");
                    if(opero.Equals("ERROR")){
                    //ERROR
                        err = "ERROR";
                        Console.WriteLine(opero + "---error**************");
                    }else{
                        if(Convert.ToString(linea[linea.Count-1]).Equals(";")){
                            Console.WriteLine(opero + "--------------punto y coma*********");
                            mete2(linea,4,opero);

                        }
                        else if (ts(linea[linea.Count - 1]).Equals("numero"))
                        {
                            Console.WriteLine(opero + "-----------tama3*************");
                            mete2(linea, 3, opero);
                        }
                        else {
                            err = "ERROR";
                            Console.WriteLine(opero + "--------------ninguno erroraraso***************");
                        }
                        
                    }

                }else{

                    err = "ERROR";
                }
                //error
            }


            return err;
        }
        private String comillas(ArrayList linea)
        {
            String err = "NO";
            Console.WriteLine("INGRESO COMILLAS************************************************"+linea[0]);
            Console.WriteLine("INGRESO COMILLAS************************************************" + linea[1]);
            Console.WriteLine("INGRESO COMILLAS************************************************" + linea[2]);
            Console.WriteLine("INGRESO COMILLAS************************************************" + linea[3]);
            if (linea.Count == 5)
            {
                if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("comilla")) && (ts(linea[3]).Equals("letra")) && (ts(linea[4]).Equals("comilla")))
                {
                    String s= '"'+Convert.ToString(linea[3])+'"';
                    mete2(linea,3,s);
                }
                else
                {
                    err = "ERROR";
                    //error
                }

            }
            else if (linea.Count == 6)
            {
                if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("comilla")) && (ts(linea[3]).Equals("letra")) && (ts(linea[4]).Equals("comilla")) && Convert.ToString(linea[5]).Equals(";"))
                {
                    String s = '"' + Convert.ToString(linea[3]) + '"';
                    mete2(linea, 4, s);
                }
                else
                {
                    err = "ERROR";
                    //error
                }
            }
            else
            {
                err = "ERROR";
                //error
            }

            return err;
        
        }
        private String etiquetas(ArrayList temp)
        {
            ArrayList tip = new ArrayList();
            String err = "NO";

            for (int k = 0; k < e.Count; k++)
            {
                //Console.WriteLine("idnetfifica-++++++++++++++++++-" + temp[j]);
                if ((temp[0].Equals(e[k])))
                {
                    tip.Add(temp[0]);
                    tip.Add("etiqueta");
                    tabla.Add(tip);
                    tip = new ArrayList();
                    break;
                }
                else
                {
                    if(k==(e.Count-1)){
                        err = "ERROR";
                    }else{
                    
                    }
                    
                    //err si no encuentra
                }
            }



            return err;
        }







        private String Analisis2(ArrayList lista)
        {
            String err = "NO";
            for (int i = 0; i < lista.Count; i++)
            {
                ArrayList temporal = (ArrayList)lista[i];
                fila = i;
                String respueta = Convert.ToString(temporal[0]).Trim();
               // Console.WriteLine("saca " + respueta);
                switch (respueta)
                {
                    case "nombre":
                        if(err.Equals("ERROR")){
                            texto2(temporal);
                        }else{
                            err = texto2(temporal);
                            
                        }
                       
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "tipo":
                        if (err.Equals("ERROR"))
                        {
                            texto2(temporal);
                        }
                        else { err = texto2(temporal);
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "valor":
                        if (ts(respueta[0]).Equals("numero"))
                        {
                            if (err.Equals("ERROR"))
                            {
                                numero2(temporal, 0);
                            }
                            else
                            {err = numero2(temporal, 0);
                            }
                            
                            Console.WriteLine(i + "errrr  " + err);
                        }
                        else if (ts(respueta[0]).Equals("letra"))
                        {
                            if (err.Equals("ERROR"))
                            {
                                numero2(temporal, 0);
                            }
                            else
                            { err = numero2(temporal, 0);
                            }
                           
                            Console.WriteLine(i + "errrr  " + err);
                        }
                        else if (ts(respueta[0]).Equals("comilla"))
                        {
                            if (err.Equals("ERROR"))
                            {
                                comillas2(temporal);
                            }
                            else
                            {err = comillas2(temporal);
                            }
                            
                            Console.WriteLine(i + "errrr  " + err);
                        }
                        else
                        {
                            err = "ERROR";
                            //errror 
                        }
                        break;
                    case "color":
                        if (err.Equals("ERROR"))
                        {
                            texto2(temporal);
                        }
                        else
                        {err = texto2(temporal);
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "pared_asociada":

                        if (err.Equals("ERROR"))
                        {
                            texto2(temporal);
                        }
                        else
                        {err = texto2(temporal);
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "radio":
                        if (err.Equals("ERROR"))
                        {
                            numero2(temporal, 0);
                        }
                        else
                        {err = numero2(temporal, 0);
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "ancho":
                        if (err.Equals("ERROR"))
                        {
                            numero2(temporal, 0);
                        }
                        else
                        {err = numero2(temporal, 0);
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "largo":
                        if (err.Equals("ERROR"))
                        {
                            numero2(temporal, 0);
                        }
                        else
                        {err = numero2(temporal, 0);
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "longitud":
                        if (err.Equals("ERROR"))
                        {
                            numero2(temporal, 0);
                        }
                        else
                        {err = numero2(temporal, 0);
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "alto":
                        if (err.Equals("ERROR"))
                        {
                            numero2(temporal, 0);
                        }
                        else
                        {err = numero2(temporal, 0);
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "inicio":
                        if (err.Equals("ERROR"))
                        {
                            numero2(temporal, 0);
                        }
                        else
                        {err = numero2(temporal, 0);
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    case "fin":
                        if (err.Equals("ERROR"))
                        {
                            numero2(temporal, 0);
                        }
                        else
                        {err = numero2(temporal, 0);
                        }
                        
                        Console.WriteLine(i + "errrr  " + err);
                        break;
                    default:
                        if (temporal.Count == 1)
                        {
                            if (err.Equals("ERROR"))
                            {
                                etiquetas2(temporal);
                            }
                            else
                            {err = etiquetas2(temporal);
                            }
                            
                            Console.WriteLine(i + "errrr  " + err);
                        }
                        else
                        {
                            err = "ERROR";
                        }
                        Console.WriteLine("NO INICIA CON NINGUN CONOCIDO");
                        break;

                }



            }

            Console.WriteLine(err + "6666666677777777766666666666");

            return err;

        }

        private String texto2(ArrayList linea)
        {
            String err = "NO";
            Console.WriteLine("ingreso a texto" + linea[2]);
            if (linea.Count == 3)
            {
                if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("letra")))
                {
                    Console.WriteLine("letraletraletra");
                    mete(linea, 3);
                }
                else
                {
                    if (Convert.ToString(linea[1]).Equals(":"))
                    {
                        meteerror(fila, 1, linea[1], "una Asignacion");
                        
                    }else{
                        meteerror(fila, 1, linea[1],":");
                    }


                    err = "ERROR";
                    //error
                }

            }
            else if (linea.Count == 4)
            {
                if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("letra")) && Convert.ToString(linea[3]).Equals(";"))
                {
                    mete(linea, 4);
                }
                else
                {


                    if (Convert.ToString(linea[1]).Equals(":"))
                    {
                        if (ts(linea[2]).Equals("letra"))
                        {
                            meteerror(fila, 3, linea[3], "; ");

                        }
                        else
                        {
                            meteerror(fila, 2, linea[2], "una Asignacion");
                        }
                        //meteerror(fila, 1, linea[1], "una Asignacion");

                    }
                    else
                    {
                        meteerror(fila, 1, linea[1], ":");
                    }

                    err = "ERROR";
                    //error
                }
            }
            else
            {

               
                    meteerror(fila, 1, linea[1], "Error sintaxis");

                

                err = "ERROR";
                //error
            }
            return err;
        }
        private String numero2(ArrayList linea, int erro)
        {
            String err = "NO";
            if (linea.Count == 3)
            {
                if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("numero")))
                {
                    mete(linea, 3);
                }
                else if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("letra")))
                {
                    String busca = buscaV(Convert.ToString(linea[2]),"entero");
                    String busca2 = buscaV(Convert.ToString(linea[2]), "doble");

                    String dato = "ERROR";
                    if(busca.Equals("ERROR")){
                        if (busca2.Equals("ERROR"))
                        {

                           
                                meteerror(fila, 1, linea[1], "una Variable");

                            

                            err = "ERROR";
                        }
                        else
                        {
                            dato = busca2;
                        }

                    }else{
                        dato = busca;
                        
                    }
                    if(dato.Equals("ERROR")){

                            meteerror(fila, 2, linea[1], "una Variable");

                        err = "ERROR";
                    }else{
                        mete2(linea, 3, dato);
                    }
                    
                }
                else
                {
                    if (Convert.ToString(linea[1]).Equals(":"))
                    {
                        meteerror(fila, 2, linea[2], "una Asignacion");

                    }
                    else
                    {
                        meteerror(fila, 1, linea[1], ":");
                    }

                    err = "ERROR";
                    //error
                }

            }
            else if (linea.Count == 4)
            {
                if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("numero")) && Convert.ToString(linea[3]).Equals(";"))
                {
                    mete(linea, 4);
                }
                else if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("letra")) && Convert.ToString(linea[3]).Equals(";"))
                {
                    String busca = buscaV(Convert.ToString(linea[2]), "entero");
                    String busca2 = buscaV(Convert.ToString(linea[2]), "doble");

                    String dato = "ERROR";
                    if (busca.Equals("ERROR"))
                    {
                        if (busca2.Equals("ERROR"))
                        {
                            err = "ERROR";

                            
                                meteerror(fila, 2, linea[2], "una Variable");


                        }
                        else
                        {
                            dato = busca2;
                        }

                    }
                    else
                    {
                        dato = busca;
                    }
                    if(dato.Equals("ERROR")){
                        err = "ERROR";
                        
                            meteerror(fila, 2, linea[2], "una Variable");

                       
                        //.RemoveAt( 5 );
                    }else{
                        mete2(linea, 4, dato);
                    }
                    
                }
                else
                {

                    if (Convert.ToString(linea[1]).Equals(":"))
                    {
                        if (Convert.ToString(linea[2]).Equals("numero") || Convert.ToString(linea[2]).Equals("letra"))
                        {
                            meteerror(fila, 3, linea[3], ";");

                        }
                        else
                        {
                            meteerror(fila, 2, linea[2], "una Asignacion");
                        }

                    }
                    else
                    {
                        meteerror(fila, 1, linea[1], ":");
                    }





                    err = "ERROR";
                    //error
                }
            }
            else if ((linea.Count == 5) && (erro == 0))
            {
                if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("numero")) && Convert.ToString(linea[3]).Equals(",") && (ts(linea[4]).Equals("numero")))
                {
                    // mete(linea, 4);
                    coorde(linea, 5);
                }

                else
                {
                    numero2(linea, 1);

                    //error
                }
            }
            else if ((linea.Count == 6) && (erro == 0))
            {
                if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("numero")) && Convert.ToString(linea[3]).Equals(",") && (ts(linea[4]).Equals("numero")) && (Convert.ToString(linea[5]).Equals(";")))
                {
                    coorde(linea, 6);
                }

                else
                {
                    numero2(linea, 1);

                    //error
                }
            }
            else
            {
                if (linea.Count >= 3)
                {

                    String opero = opera(linea);
                    if (opero.Equals("ERROR"))
                    {

                        
                            meteerror(fila, 3, linea[3], "un Numero");

                       
                        err = "ERROR";
                        //ERROR
                    }
                    else
                    {
                        if (Convert.ToString(linea[linea.Count - 1]).Equals(";"))
                        {
                            mete2(linea, 4, opero);
                        }
                        else if (ts(linea[linea.Count - 1]).Equals("numero"))
                        {
                            mete2(linea, 3, opero);
                        }
                        else
                        {


                            
                                meteerror(fila, 2, linea[2], "un numero o ;");
                            

                            err = "ERROR";
                            ///////////nose
                        }

                    }

                }
                else
                {
                    meteerror(fila,1,linea[0],": Error Sintaxis");
                    err = "ERROR";

                }
                //error
            }

            return err;
        }
        private String comillas2(ArrayList linea)
        {
            String err = "NO";
            Console.WriteLine("INGRESO COMILLAS************************************************" + linea[0]);
            Console.WriteLine("INGRESO COMILLAS************************************************" + linea[1]);
            Console.WriteLine("INGRESO COMILLAS************************************************" + linea[2]);
            Console.WriteLine("INGRESO COMILLAS************************************************" + linea[3]);
            if (linea.Count == 5)
            {
                if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("comilla")) && (!ts(linea[3]).Equals("Error")) && (ts(linea[4]).Equals("comilla")))
                {
                    String s = '"' + Convert.ToString(linea[3]) + '"';
                    mete2(linea, 3, s);
                }
                else
                {
                    if (Convert.ToString(linea[1]).Equals(":"))
                    {

                        if ((ts(linea[2]).Equals("comilla")))
                        {

                            if ((!ts(linea[3]).Equals("Error")))
                            {

                                meteerror(fila, 4, linea[4], "final Comilla");
                            }
                            else
                            {
                                meteerror(fila, 3, linea[3], "un Texto");

                            }

                        }
                        else
                        {
                            meteerror(fila, 2, linea[2], "Comilla");

                        }


                       

                    }
                    else {

                        meteerror(fila,1,linea[1],":");
                    }

                    err = "ERROR";
                    //error
                }

            }
            else if (linea.Count == 6)
            {
                if (Convert.ToString(linea[1]).Equals(":") && (ts(linea[2]).Equals("comilla")) && (!ts(linea[3]).Equals("Error")) && (ts(linea[4]).Equals("comilla")) && Convert.ToString(linea[5]).Equals(";"))
                {
                    String s = '"' + Convert.ToString(linea[3]) + '"';
                    mete2(linea, 4, s);
                }
                else
                {


                    if (Convert.ToString(linea[1]).Equals(":"))
                    {
                        if ((ts(linea[2]).Equals("comilla")))
                        {

                            
                                    if ((!ts(linea[3]).Equals("Error")))
                                        {

                                            if ((ts(linea[4]).Equals("comilla")))
                                            {
                                                meteerror(fila, 5, linea[5], ";");
                                            }
                                            else {
                                                meteerror(fila, 4, linea[4], "final Comilla");
                                            }
                                        }
                                        else
                                        {
                                            meteerror(fila, 3, linea[3], "un Texto");

                                        }
                        }
                        else
                        {
                            meteerror(fila, 2, linea[2], "Comilla");

                        }
                    }
                    else
                    {

                        meteerror(fila, 1, linea[1], ":");
                    }





                    err = "ERROR";
                    //error
                }
            }
            else
            {

                meteerror(fila, 1, linea[0], ": Error Sintaxis");
                err = "ERROR";
                //error
            }
            return err;

        }
        private String etiquetas2(ArrayList temp)
        {
            ArrayList tip = new ArrayList();
            String err = "NO";

            for (int k = 0; k < e.Count; k++)
            {
                //Console.WriteLine("idnetfifica-++++++++++++++++++-" + temp[j]);
                if ((temp[0].Equals(e[k])))
                {
                    tip.Add(temp[0]);
                    tip.Add("etiqueta");
                    tabla.Add(tip);
                    tip = new ArrayList();
                    break;
                }
                else
                {
                    if (k == (e.Count - 1))
                    {
                        err = "ERROR";

                        meteerror(fila, 0, temp[0], "etiqueta Correcta");
                    }
                    else
                    {

                    }
                    //err si no encuentra
                }
            }

            return err;


        }





        private String opera(ArrayList linea) {
            Stack pila = new Stack();
            String concatena = "ERROR";
            for (int i = 2; i < linea.Count - 1;i++ )
            {
                if (ts(linea[i]).Equals("letra") || ts(linea[i]).Equals("numero")&& ts(linea[2]).Equals("numero"))
                {
                
                    if(i==2){
                    
                    }else{
                        if (pila.Count == 0)
                        {
                            for (int j = 2; j < 20 - 1; j++)
                            {
                                pila.Push("a");
                            }
                            //error 
                        }
                        else {
                            pila.Pop();
                        }
                    
                    }

                }
                else if (ts(linea[2]).Equals("numero")&& ts(linea[i]).Equals("asterisco") || ts(linea[i]).Equals("diagonal") || ts(linea[i]).Equals("guionn") || ts(linea[i]).Equals("mas") || ts(linea[i]).Equals("exponente"))
                {
                    if (i == 2)
                    {
                        for (int j = 2; j < 20 - 1; j++)
                        {
                            pila.Push("a");
                        } 
                    }
                    else
                    {
                        pila.Push("a");

                    }
                }else{
                    for (int j = 2; j < 20 - 1; j++) {
                        pila.Push("a");
                    }
                //error
                }
            }

            if(pila.Count==0){
            //todo correcto
                concatena = "";
                int pow = 0;
                for (int i = 2; i < linea.Count - 1; i++) {

                    if (linea[i + 1].Equals("^"))
                    {
                        concatena = concatena + " Math.pow(" + linea[i] + "," + linea[i + 2] + ") ";
                        pow = 1;
                        Console.WriteLine("entro en pow");
                    }
                    else
                    {

                        if (pow == 0)
                        {
                            concatena = concatena + linea[i];
                        }
                        else
                        {

                            if (pow == 3)
                            {
                                concatena = concatena + linea[i];
                                pow = 0;
                            }
                            else
                            {
                                pow = pow + 1;

                            }
                        }

                    }







                   // concatena = concatena + linea[i];
                }
                Console.WriteLine(" "+concatena);
                operacion opera = new operacion();
                concatena=opera.EvalExpression(concatena);
            }else{
            }

            return concatena;
        }
        private String ts(Object linea) {
            String trae = Convert.ToString(linea);

            String regre = tipo(Convert.ToString(trae[0]));

            return regre;
        
        }




        private String cierres()
        {
            String err = "NO";
            Stack pila = new Stack();
            try
            {

                for (int i = 0; i < tabla.Count; i++)
                {
                    ArrayList temp = (ArrayList)tabla[i];

                    if (temp[1].Equals("etiqueta") && (!((((String)temp[0])[1]).Equals('/'))))
                    {
                        pila.Push(temp[0]);

                    }
                    else if (temp[1].Equals("etiqueta") && (((((String)temp[0])[1]).Equals('/'))))
                    {
                        String saca = (String)pila.Pop();
                        String buscoc = Convert.ToString(saca[5]);
                        String cierre = Convert.ToString(((String)temp[0])[6]);

                        if ((buscoc.Equals(cierre)))
                        {
                            //Console.WriteLine("tiene cierre correcto -----------------*-*");
                        }
                        else
                        {
                            err = "ERROR";
                            Console.WriteLine("NONNONONONONONO tiene cierre correoco-----------------*-*");
                        }



                    }
                    else
                    {
                        //err = "ERROR";
                    }

                }
            }
            catch {

                err = "ERROR";
            
            }
            return err;

        }
        private String orden()
        {

            String err = "NO";
            Stack orden = new Stack();


            orden.Push("</diseño>");
            orden.Push("</construccion>");
            orden.Push("</suelo>");
            //orden.Push("ejecu6");
            orden.Push("<suelo>");
            orden.Push("</puerta>");
            //orden.Push("ejecu5");
            orden.Push("<puerta>");
            orden.Push("</ventana>");
            //orden.Push("ejecu4");
            orden.Push("<ventana>");
            orden.Push("</pared>");
            //orden.Push("ejecu3");
            orden.Push("<pared>");
            orden.Push("</terreno>");
            //orden.Push("ejecu2");
            orden.Push("<terreno>");
            orden.Push("<construccion>");
            orden.Push("</variables>");
            //orden.Push("ejecu1");
            orden.Push("<variables>");
            orden.Push("<diseño>");





            for (int i = 0; i < tabla.Count; i++)
            {
                ArrayList temp = (ArrayList)tabla[i];


               // Console.WriteLine("orden correcto -----------------*-*fila en " + i);
                if (temp[1].Equals("etiqueta"))
                {
                    String saca = (String)orden.Pop();
                    String etiqueta = (String)temp[0];

                    if ((saca.Equals(etiqueta)))
                    {
                       // Console.WriteLine("orden correcto -----------------*-*");

                        switch (saca)
                        {
                            case "<variables>":
                                if(err.Equals("ERROR")){
                                    variable(i);
                                }else{
                                err=variable(i);
                                }
                                
                                Console.WriteLine(err + "999999999999999911");
                                break;
                            case "<terreno>":
                                if (err.Equals("ERROR"))
                                {
                                    terreno(i);
                                }else{
                                    err = terreno(i);
                                }
                                
                                Console.WriteLine(err + "999999999999999922");
                                break;
                            case "<pared>":
                                if (err.Equals("ERROR"))
                                {
                                    pared(i);
                                }
                                else
                                {
                                    err = pared(i);
                                }
                                
                                Console.WriteLine(err + "999999999999999933");
                                break;
                            case "<ventana>":
                                if (err.Equals("ERROR"))
                                {
                                    ventana(i);
                                }
                                else
                                {
                                    err = ventana(i);
                                }
                                
                                Console.WriteLine(err + "999999999999999944");
                                break;
                            case "<puerta>":
                                if (err.Equals("ERROR"))
                                {
                                    puerta(i);
                                }
                                else
                                {
                                        err = puerta(i);
                                }
                                
                                Console.WriteLine(err + "999999999999999955");
                                break;
                            case "<suelo>":
                                if (err.Equals("ERROR"))
                                {
                                    suelo(i);
                                }
                                else
                                {
                                    err = suelo(i);
                                }
                                
                                Console.WriteLine(err + "999999999999999966");
                                break;
                            default:
                                //err = "ERROR";
                                break;

                        }




                    }
                    else
                    {
                        if (err.Equals("ERROR"))
                        {
                            
                        }
                        else
                        {
                            meteerror(fila, 0, temp[1], saca);
                        }
                        
                        err = "ERROR";



                        Console.WriteLine("NONNONONONONONO orden correcto----------------*-*");
                    }

                }
                else
                {



                }
            }

            return err;

        }


        private String buscaV(String nombre,String tipo) {
            String valor = "ERROR";

            for (int i = 0; i < variables.Count;i++ )
            {
                ArrayList temp = (ArrayList)variables[i];

                if((temp[0].Equals(nombre))&&(temp[1].Equals(tipo))){
                    valor = (String)temp[2];
                    break;
                }else{

                }


            }
            return valor;
        }
        private String buscaVar(String nombre)
        {
            String valor = "ERROR";

            for (int i = 0; i < variables.Count; i++)
            {
                ArrayList temp = (ArrayList)variables[i];

                if (temp[0].Equals(nombre))
                {
                    valor = "EXISTE";
                    break;
                }
                else
                {

                }


            }
            return valor;
        }



        private void meteerror(int fila , int colum,Object valor,String texto) {
            ArrayList tempo = new ArrayList();
            tempo.Add(fila);
            tempo.Add(colum);
            tempo.Add(valor);
            tempo.Add("Sintactico:Se esperaba "+texto);
            ERRORES.Add(tempo);
        
        }


        private String variable(int fila)
        {

            String err = "NO";
            Console.WriteLine("************************************" + tabla.Count);
            for (int k = 0; k < tabla.Count; k++)
            {
                ArrayList temp = (ArrayList)tabla[k];

                //Console.WriteLine(temp[0] + " tipo-------------------> " + temp[1]);
            }

            Console.WriteLine("**************-----***********************" + tabla.Count);
            Stack datos = new Stack();
            ArrayList tipox = new ArrayList();
            tipox.Add("entero");
            tipox.Add("cadena");
            tipox.Add("doble");

            datos.Push(';');
            datos.Push("valor");
            datos.Push(':');
            datos.Push("valor");

            datos.Push(tipox);
            datos.Push(':');
            datos.Push("tipo");
            datos.Push("valor");
            datos.Push(':');
            datos.Push("nombre");

            int term = 10;

            Console.WriteLine("linea para VARIABLES -----------------------------------" + fila);

            
            int con = 0;
            for (int i = fila + 1; i < tabla.Count; i++)
            {
                ArrayList temp = (ArrayList)tabla[i];
                con++;
                try
                {

                
                Console.WriteLine("evalua " + temp[0] + " con " + con);
                Console.WriteLine(" valor pila" + datos.Count);

                if (con == 6)
                {

                    Console.WriteLine("tra/////////////////----------------------------e ");
                    ArrayList ins = (ArrayList)datos.Pop();
                    if (((temp[0]).Equals(ins[0])) || (temp[0].Equals(ins[1])) || (temp[0].Equals(ins[2])))
                    {
                       // Console.WriteLine("-----valor corecto en valor valores ---------------------");
                    }
                    else
                    {


                        meteerror(fila, i, temp[0],"un Tipo");



                        err = "ERROR";
                        Console.WriteLine("-----errrrr ---------------------");
                        datos.Push("asd");
                    }

                }
                else if (con == 9)
                {
                    //Console.WriteLine("trae++++++++++++++++++++++++++++++++++++++++++++ ---------" );
                    String tips = tipo(Convert.ToString((Convert.ToString(temp[0])[0])));
                    ArrayList arri = (ArrayList)tabla[fila+6];
                   // Console.WriteLine("trae "+arri[0]+"*********-*-*-*-*-*-*-----------"+tips);
                   // Console.WriteLine("trae++++++++++++++++++++++++++++++++++++++++++++ ---------");
                    if (tips.Equals("numero") && ((arri[0].Equals("entero")) || (arri[0].Equals("doble"))))
                    {

                        operacion op = new operacion();

                        String sali = op.EvalExpression((String)temp[0]);
                       // Console.WriteLine("valor de tipos " + arri[0] + "//////////////////////////////////////////////");

                        if ((arri[0]).Equals("entero"))
                        {
                            double s = Convert.ToDouble(sali);
                            int ss = (int)s;
                         //   Console.WriteLine(ss + "************************************************************");
                            sali = Convert.ToString(ss);

                            

                        }
                        else
                        {


                        }
                        ArrayList me = new ArrayList();
                        me.Add(sali);
                        me.Add("valor");
                        tabla[i] = me;

                        datos.Pop();

                    }
                    else if (tips.Equals("letra"))
                    {
                        datos.Pop();
                        //qui busco variables
                        
                        if (!(buscaV((String)temp[0], (String)arri[0]).Equals("ERROR")))
                        {
                            //err = "ERROR";
                            Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                        }
                        else
                        {
                            meteerror(fila, i, temp[0], "una Variable");
                            datos.Push("asd");
                            datos.Push("asd");
                            datos.Push("asd");
                            datos.Push("asd");
                            err = "ERROR";
                            Console.WriteLine("-----error no cu------------mple orden ---------------------" + tips);
                            Console.WriteLine("-----error no cu------------mple orden ---------------------" + temp[0]);
                        }
                    }
                    else if (tips.Equals("comilla"))
                    {
                        Console.WriteLine("entro comillas d");
                        datos.Pop();
                        //term = 12;
                        //Stack med = new Stack();
                        //med.Push(';');
                        //med.Push('"');
                        //med.Push("valor");
                        //datos = med;
                    }
                    else
                    {

                        meteerror(fila, i, temp[0], "un Valor Correcto");
                        Console.WriteLine("erorororororo");
                        datos.Push("asd");
                        datos.Push("asd");
                        datos.Push("asd");
                        datos.Push("asd");
                        err = "ERROR";
                        datos.Push("asd");
                        
                    }
                }
                else if (con == 3)
                {
                    String busca = buscaVar((String)temp[0]);
                    if (busca.Equals("ERROR"))
                    {

                        Console.WriteLine("trae--333333333333333333333333333333---");
                        String tips = tipo(Convert.ToString(((String)temp[0])[0]));
                        if (tips.Equals("letra"))
                        {
                            datos.Pop();
                        }
                        else
                        {

                            meteerror(fila, i, temp[0], " un Nombre");
                            err = "ERROR";
                            datos.Push("asd");
                            Console.WriteLine("-----error no cumple orden ---------------------");
                        }



                    }
                    else {
                        meteerror(fila, i, temp[0], "nombre no Existente");
                        err = "ERROR";
                        datos.Push("asd");
                    }
                    



                }
                //else if ((con == 10)&&(term==12))
                //{
                //    String tips = tipo(Convert.ToString(((String)temp[0])[0]));
                //    if (tips.Equals("letra"))
                //    {
                //        datos.Pop();
                //    }
                //    else
                //    {
                //        datos.Push("asd");
                //        Console.WriteLine("-----error no cumple orden ---------------------");
                //    }
                //}
                //else if ((con == 11) && (term == 12))
                //{
                //    String tips = tipo(Convert.ToString((Convert.ToString(temp[0])[0])));
                //    if (tips.Equals("comilla"))
                //    {
                //        datos.Pop();
                //    }
                //    else
                //    {
                //        datos.Push("asd");
                //        Console.WriteLine("-----error no cumple orden ---------------------");
                //    }
                //}
                else if ((con == term))
                {
                   
                    String tips = Convert.ToString((Convert.ToString(temp[0])[0]));
                    Console.WriteLine("trae--33333termpsssssssssssssssssss3333333---"+tips);
                    if (tips.Equals(";"))
                    {
                        datos.Pop();

                    }
                    else
                    {
                        meteerror(fila, i, temp[0], " ;");
                        err = "ERROR";

                        datos.Push("asd");
                        datos.Push("asd");
                        datos.Push("asd");
                        datos.Push("asd");
                        Console.WriteLine("-----error no cumqwerqwerqple oasdfasdfrden ---------------------" + i);
                        Console.WriteLine("-----error no cumaaaaaaaaple oasdfasdfrden ---------------------" + tips);
                    }

                }
                else
                {
                   // Console.WriteLine("tcorrienteeeeeeeeeeeaaaaaaaas   eeeeeeeeeeeeeeeee---");
                    String ins = Convert.ToString(datos.Pop());
                    if (Convert.ToString(temp[0]).Equals(ins))
                    {
                        //Console.WriteLine("-----igual valores ---------------------");
                    }
                    else
                    {
                        meteerror(fila, i, temp[0], ins);
                        err = "ERROR";
                        datos.Push("asd");
                        Console.WriteLine("-----errrror e corriete--------------------" + i);
                    }


                }


                if ((con == term))
                {
                    break;


                }



                }
            catch
            {
                try
                {

                    for (int j = 0; j < term - 1; j++)
                    {

                        String assd = Convert.ToString(datos.Pop());

                        if (con == j)
                        {
                            meteerror(i, 2, temp[0], assd);
                            break;
                        }
                        else
                        {

                        }
                    }

                }
                catch { 
                
                }



                err = "ERROR";
            }

            }


            

            Console.WriteLine(datos.Count+" valor de la pila supuestamente-----------------------");

            if (datos.Count == 0)
            {
                ArrayList nom = (ArrayList)tabla[fila + 3];
                ArrayList tip = (ArrayList)tabla[fila + 6];
                ArrayList val = (ArrayList)tabla[fila + 9];
                ArrayList vari = new ArrayList();

                vari.Add(nom[0]);
                vari.Add(tip[0]);
                String tipss = tipo(Convert.ToString((Convert.ToString(val[0]))[0]));
                Console.WriteLine("busca " + val[0]);
                Console.WriteLine("busca " +tip[0]);

                if (tipss.Equals("letra"))
                {

                  vari.Add(buscaV(Convert.ToString(val[0]),Convert.ToString(tip[0])));
                    
                }
                else if (tipss.Equals("comilla"))
                {
                    ArrayList val2 = (ArrayList)tabla[fila + 10];
                    vari.Add(val2[0]);
                }
                else {
                    vari.Add(val[0]);
                }
                variables.Add(vari);

                //Console.WriteLine("saca de variables >"+vari[0]);
                //Console.WriteLine("saca de variables >" + vari[1]);
               // Console.WriteLine("saca de variables >" + vari[2]);




                if ((fila + term+1) < tabla.Count)
                {
                ArrayList tempv = (ArrayList)tabla[fila + term+1];
                Console.WriteLine("-----todo cumplio variables---------------------" );
                if (tempv[0].Equals("nombre"))
                {

                    err = variable(fila + term);

                }
                else
                {
                    
                }
                }
                else
                {


                }





                

            }
            else
            {


                if ((fila + term+1) < tabla.Count)
                {
                    ArrayList tempv = (ArrayList)tabla[fila + term + 1];
                    Console.WriteLine("-----no se vacio pila---------------------");
                    if (tipo(Convert.ToString((Convert.ToString(tempv[0]))[0])).Equals("menor"))
                    {

                        err = "ERROR";

                    }
                    else
                    {
                        err = variable(fila + 2);
                    }
                }
                else
                {


                }



               
                
                
            }


            //asigna(totemps);
            tabla = new ArrayList();
            Analisis2(totemps);

            return err;
        }



        private String terreno(int fila)
        {
            String err = "NO";
            Stack dat = new Stack();
            Console.WriteLine("ingreso a TERRENO++++++++++++++++++++999" + fila);


            //for (int k = 0; k < tabla.Count; k++)
            //{
            //    ArrayList temp = (ArrayList)tabla[k];

            //    Console.WriteLine(temp[0] + " /" + temp[1] + "************************************" + k);
            //}


            dat.Push("num");
            dat.Push(":");
            dat.Push("largo");
            dat.Push("num");
            dat.Push(":");
            dat.Push("ancho");

            int con = 0;

            try
            {


                for (int i = fila + 1; i < tabla.Count; i++)
                {
                    ArrayList temp = (ArrayList)tabla[i];


                    con++;
                    String ins = Convert.ToString(dat.Pop());
                    //Console.WriteLine("---ores ----------------------------------");
                    //Console.WriteLine("---ores ---------------------" + temp[0]);
                    //Console.WriteLine("---ores ---------------------" + ins);
                    //Console.WriteLine("---ores ----------------------------------");


                    if ((con == 3) || (con == 6))
                    {




                        if (((tipo(Convert.ToString(((String)temp[0])[0]))).Equals("numero")))
                        {
                            // Console.WriteLine("-----valor corecto en valor valores ---------------------");
                        }
                        else
                        {

                            
                                
                           
                            err = "ERROR";
                            Console.WriteLine("-----EERRR ---------------------");
                        }


                    }
                    else
                    {

                        if (((Convert.ToString(temp[0])).Equals(ins)))
                        {
                            // Console.WriteLine("-----valor corecto en valor valores ---------------------");
                        }
                        else
                        {

                            if (((Convert.ToString(temp[0])).Equals("largo")))
                            {
                                //Console.WriteLine("-----valor corecto en valor valores ---------------------");
                                Stack dat2 = new Stack();

                                dat2.Push("num");
                                dat2.Push(":");
                                dat2.Push("ancho");
                                dat2.Push("num");
                                dat2.Push(":");
                                dat = dat2;


                            }
                            else
                            {

                                err = "ERROR";
                                Console.WriteLine("-----EERRR ---------------------");
                            }
                        }

                    }

                    if ((con == 6))
                    {
                        break;


                    }

                }
            }
            catch {
                err = "ERROR";
            }


            return err;
        }



        private String pared(int fila)
        {
            String err = "NO";
            Stack dat = new Stack();
            Console.WriteLine("ingreso a PARED++++++++++++++++++++999" + fila);


            
            dat.Push(";");
            dat.Push("num");
            dat.Push(",");
            dat.Push("num");
            dat.Push(":");
            dat.Push("fin");

            dat.Push("num");
            dat.Push(",");
            dat.Push("num");
            dat.Push(":");
            dat.Push("inicio");

            dat.Push("num");
            dat.Push(":");
            dat.Push("alto");

            ArrayList colo = new ArrayList();
            colo.Add("azul");
            colo.Add("rojo");
            colo.Add("verde");
            colo.Add("cafe");
            colo.Add("blanco");
            colo.Add("negro");
            colo.Add("amarillo");
            colo.Add("beige");
            colo.Add("transparente");

            dat.Push(colo);
            dat.Push(":");
            dat.Push("color");

            dat.Push("val");
            dat.Push(":");
            dat.Push("nombre");
            try{
            int con = 0;
            for (int i = fila + 1; i < tabla.Count; i++)
            {
                ArrayList temp = (ArrayList)tabla[i];


                con++;


                //Console.WriteLine("-----ew ---------------------" + con);
                //Console.WriteLine("-----dfg---------------------" + temp[0]);
                if ((con == 9) || (con == 12) || (con == 14) || (con == 17) || (con == 19))
                {
                    String ins = Convert.ToString(dat.Pop());



                    if (((tipo(Convert.ToString(((String)temp[0])[0]))).Equals("numero")))
                    {
                        //Console.WriteLine("-----valor corecto en valor valores ---------------------" + con);
                    }
                    else
                    {
                        err = "ERROR";
                        dat.Push("asdf");
                        Console.WriteLine("-----EERRR ---------------------");
                    }


                }
                else if ((con == 3))
                {

                    String ins = Convert.ToString(dat.Pop());


                    if (((tipo(Convert.ToString(((String)temp[0])[0]))).Equals("letra")))
                    {
                        //Console.WriteLine("-----valor corecto en valor valores ---------------------");
                    }
                    else
                    {
                        err = "ERROR";
                        dat.Push("asdf");
                        Console.WriteLine("-----EERRR ---------------------");
                    }


                }
                else if (con == 6)
                {

                    //String ins = Convert.ToString(dat.Pop());
                    //Console.WriteLine(dat.Pop());
                    ArrayList ins2 = (ArrayList)dat.Pop();

                    for (int j = 0; j < ins2.Count; j++)
                    {
                        if (((temp[0]).Equals(ins2[j])))
                        {
                            //Console.WriteLine("-----valor corecto en valor valores ---------------------");
                        }
                        else
                        {

                            if (i == (ins2.Count - 1))
                            {
                                dat.Push("asd");
                                err = "ERROR";
                                Console.WriteLine("-----werwewe eerrorr ---------------------");
                            }
                            else
                            {

                            }

                        }

                    }


                }
                else
                {


                    String ins = Convert.ToString(dat.Pop());



                    if (((Convert.ToString(temp[0])).Equals(ins)))
                    {
                       // Console.WriteLine("-----valor corecto en valor valores ---------------------");
                    }
                    else
                    {

                        if (((Convert.ToString(temp[0])).Equals("largo")))
                        {
                           // Console.WriteLine("-----valor corecto en valor valores ---------------------");
                            Stack dat2 = new Stack();

                            dat2.Push("num");
                            dat2.Push(":");
                            dat2.Push("ancho");
                            dat2.Push("num");
                            dat2.Push(":");
                            dat = dat2;


                        }
                        else
                        {




                            err = "ERROR";
                            Console.WriteLine("-----EERRR ---------------------");
                        }
                    }

                }



                if ((con == 20))
                {
                    break;


                }
            }

        }catch{
            err = "ERROR";
    }


            if(dat.Count!=0){
                err = "ERROR";
            }


            //if (dat.Count == 0)
            //{
            if ((fila + 21)<tabla.Count)
            {
            
        ArrayList tempv = (ArrayList)tabla[fila + 21];
                        //Console.WriteLine("-----todo cumplio variables---------------------" + temp[0]);
                        if (tempv[0].Equals("nombre"))
                        {
                            err=pared(fila + 20);

                        }
                        else
                        {

                        }

            }else{
            
            
            }
                

            //}
            //else
            //{
            //    Console.WriteLine("-----no se vacio pila---------------------");
            //}

                return err;

        }


        private String ventana(int fila)
        {
            String err = "NO";
            Stack dat = new Stack();
            Console.WriteLine("ingreso a VENTANA++++++++++++++++++++999" + fila);


            dat.Push(";");
            dat.Push("valor");
            dat.Push(":");
            dat.Push("pared_asociada");

            dat.Push("num");
            dat.Push(":");
            dat.Push("longitud");
           

            ArrayList colo = new ArrayList();
            colo.Add("cuadrado");
            colo.Add("redondo");

            dat.Push(colo);
            dat.Push(":");
            dat.Push("tipo");

            dat.Push("val");
            dat.Push(":");
            dat.Push("nombre");


            try
            {


                int con = 0;
                for (int i = fila + 1; i < tabla.Count; i++)
                {
                    ArrayList temp = (ArrayList)tabla[i];


                    con++;


                    //Console.WriteLine("-----ew ---------------------" + con);
                    //Console.WriteLine("-----dfg---------------------" + temp[0]);
                    if ((con == 9))
                    {
                        String ins = Convert.ToString(dat.Pop());



                        if (((tipo(Convert.ToString(((String)temp[0])[0]))).Equals("numero")))
                        {
                            // Console.WriteLine("-----valor corecto en valor valores ---------------------" + con);
                        }
                        else
                        {
                            err = "ERROR";
                            dat.Push("asdf");
                            Console.WriteLine("-----EERRR ---------------------");
                        }


                    }
                    else if ((con == 3) || (con == 12))
                    {

                        String ins = Convert.ToString(dat.Pop());


                        if (((tipo(Convert.ToString(((String)temp[0])[0]))).Equals("letra")))
                        {
                            Console.WriteLine("-----valor corecto en valor valores ---------------------");
                        }
                        else
                        {
                            err = "ERROR";
                            dat.Push("asdf");
                            Console.WriteLine("-----EERRR ---------------------");
                        }


                    }
                    else if (con == 6)
                    {

                        //String ins = Convert.ToString(dat.Pop());
                        //Console.WriteLine(dat.Pop());
                        ArrayList ins2 = (ArrayList)dat.Pop();

                        for (int j = 0; j < ins2.Count; j++)
                        {
                            if (((temp[0]).Equals(ins2[j])))
                            {

                                if (temp[0].Equals("redondo"))
                                {
                                    Stack pi = new Stack();
                                    pi.Push(";");
                                    pi.Push("valor");
                                    pi.Push(":");
                                    pi.Push("pared_asociada");

                                    pi.Push("num");
                                    pi.Push(":");
                                    pi.Push("longitud");
                                    pi.Push("radio");
                                    dat = pi;
                                }
                                else
                                {
                                    //err = "ERROR";
                                }


                                //Console.WriteLine("-----valor corecto en valor valores ---------------------");
                            }
                            else
                            {

                                if (i == (ins2.Count - 1))
                                {
                                    err = "ERROR";
                                    dat.Push("asd");

                                    Console.WriteLine("-----werwewe eerrorr ---------------------");
                                }
                                else
                                {

                                }

                            }

                        }


                    }
                    else
                    {


                        String ins = Convert.ToString(dat.Pop());



                        if (((Convert.ToString(temp[0])).Equals(Convert.ToString(ins))))
                        {
                            //Console.WriteLine("-----valor corecto en valor valores ---------------------");
                        }
                        else
                        {
                            err = "ERROR";
                            dat.Push("aes");
                            Console.WriteLine("-----EERRR ---------------------");

                        }

                    }



                    if ((con == 13))
                    {
                        break;


                    }
                }


            }
            catch
            {
                err = "ERROR";
            }
            Console.WriteLine(dat.Count+"VALOR QUE TRAE &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"+ventanas);

            if (dat.Count != 0)
            {
                err = "ERROR";
            }
            else {

                ventanas=ventanas+1;
            
            }



            if ((fila + 13) < tabla.Count)
            {
             ArrayList tempv = (ArrayList)tabla[fila + 14];
                          Console.WriteLine("-----todo cumplio variables---------------------" + tempv[0]);
                            if (tempv[0].Equals("nombre"))
                            {
                                err=ventana(fila + 13);

                            }
                            else
                            {

                            }
            }
            else
            {


            }



            //if (dat.Count == 0)
            //{
               

            //}
            //else
            //{
            //    Console.WriteLine("-----no se vacio pila---------------------");
            //}

                return err;

        }



        private String puerta(int fila)
        {
            Stack dat = new Stack();
            Console.WriteLine("ingreso a PUERTA++++++++++++++++++++999" + fila);

            String err = "NO";
           

            dat.Push(";");

            ArrayList colo = new ArrayList();
            colo.Add("azul");
            colo.Add("rojo");
            colo.Add("verde");
            colo.Add("cafe");
            colo.Add("blanco");
            colo.Add("negro");
            colo.Add("amarillo");
            colo.Add("beige");
            colo.Add("transparente");

            dat.Push(colo);
            dat.Push(":");
            dat.Push("color");


            dat.Push("valor");
            dat.Push(":");
            dat.Push("pared_asociada");



            dat.Push("num");
            dat.Push(":");
            dat.Push("ancho");

            dat.Push("num");
            dat.Push(":");
            dat.Push("alto");


            

            dat.Push("val");
            dat.Push(":");
            dat.Push("nombre");


            try
            {


                int con = 0;
                for (int i = fila + 1; i < tabla.Count; i++)
                {
                    ArrayList temp = (ArrayList)tabla[i];


                    con++;


                    //Console.WriteLine("-----ew ---------------------" + con);
                    //Console.WriteLine("-----dfg---------------------" + temp[0]);
                    if ((con == 6) || (con == 9))
                    {
                        String ins = Convert.ToString(dat.Pop());



                        if (((tipo(Convert.ToString(((String)temp[0])[0]))).Equals("numero")))
                        {
                            //   Console.WriteLine("-----valor corecto en valor valores ---------------------" + con);
                        }
                        else
                        {
                            err = "ERROR";
                            dat.Push("asdf");
                            Console.WriteLine("-----EERRR ---------------------");
                        }


                    }
                    else if ((con == 3) || (con == 12))
                    {

                        String ins = Convert.ToString(dat.Pop());


                        if (((tipo(Convert.ToString(((String)temp[0])[0]))).Equals("letra")))
                        {
                            // Console.WriteLine("-----valor corecto en valor valores ---------------------");
                        }
                        else
                        {
                            err = "ERROR";
                            dat.Push("asdf");
                            Console.WriteLine("-----EERRR ---------------------");
                        }


                    }
                    else if (con == 15)
                    {

                        //String ins = Convert.ToString(dat.Pop());
                        //Console.WriteLine(dat.Pop());
                        ArrayList ins2 = (ArrayList)dat.Pop();

                        for (int j = 0; j < ins2.Count; j++)
                        {
                            if (((temp[0]).Equals(ins2[j])))
                            {



                                //  Console.WriteLine("-----valor corecto en valor valores ---------------------");
                            }
                            else
                            {

                                if (i == (ins2.Count - 1))
                                {
                                    dat.Push("asd");
                                    err = "ERROR";
                                    Console.WriteLine("-----werwewe eerrorr ---------------------");
                                }
                                else
                                {

                                }

                            }

                        }


                    }
                    else
                    {


                        String ins = Convert.ToString(dat.Pop());



                        if (((Convert.ToString(temp[0])).Equals(Convert.ToString(ins))))
                        {
                            //Console.WriteLine("-----valor corecto en valor valores ---------------------");
                        }
                        else
                        {
                            err = "ERROR";
                            dat.Push("aes");
                            Console.WriteLine("-----EERRR ---------------------");

                        }

                    }



                    if ((con == 16))
                    {
                        break;


                    }
                }

            }
            catch {
                err = "ERROR";
            }




            Console.WriteLine("valor");
            if (dat.Count != 0)
            {
                err = "ERROR";
            }
            else {

                puertas=puertas+1;
                colopuertas.Add(((ArrayList)tabla[fila+15])[0]);
            }




            if ((fila + 16) < tabla.Count)
            {
                ArrayList tempv = (ArrayList)tabla[fila + 17];
                                Console.WriteLine("-----todo cumplio variables---------------------" + tempv[0]);
                                if (tempv[0].Equals("nombre"))
                                {
                                    err=puerta(fila + 16);

                                }
                                else
                                {

                                }
            }
            else
            {


            }




            //if (dat.Count == 0)
            //{
                

            //}
            //else
            //{
            //    Console.WriteLine("-----no se vacio pila---------------------");
            //}

                return err;

        }


        private String suelo(int fila)
        {
            Stack dat = new Stack();
            Console.WriteLine("ingreso a SUELO++++++++++++++++++++999" + fila);

            String err = "NO";
           

            

            ArrayList colo = new ArrayList();
            colo.Add("azul");
            colo.Add("rojo");
            colo.Add("verde");
            colo.Add("cafe");
            colo.Add("blanco");
            colo.Add("negro");
            colo.Add("amarillo");
            colo.Add("beige");
            colo.Add("transparente");


            dat.Push(colo);
            dat.Push(":");
            dat.Push("color");


            dat.Push("valor");
            dat.Push(":");
            dat.Push("nombre");


            try{
            int con = 0;
            for (int i = fila + 1; i < tabla.Count; i++)
            {
                ArrayList temp = (ArrayList)tabla[i];


                con++;


                //Console.WriteLine("-----ew ---------------------" + con);
                //Console.WriteLine("-----dfg---------------------" + temp[0]);
                if ((con == 3))
                {

                    String ins = Convert.ToString(dat.Pop());


                    if (((tipo(Convert.ToString(((String)temp[0])[0]))).Equals("letra")))
                    {
                       // Console.WriteLine("-----valor corecto en valor valores ---------------------");
                    }
                    else
                    {
                        err = "ERROR";
                        dat.Push("asdf");
                        Console.WriteLine("-----EERRR ---------------------");
                    }


                }
                else if (con == 6)
                {

                    //String ins = Convert.ToString(dat.Pop());
                    //Console.WriteLine(dat.Pop());
                    ArrayList ins2 = (ArrayList)dat.Pop();

                    for (int j = 0; j < ins2.Count; j++)
                    {
                        if (((temp[0]).Equals(ins2[j])))
                        {



                            //Console.WriteLine("-----valor corecto en valor valores ---------------------");
                        }
                        else
                        {

                            if (i == (ins2.Count - 1))
                            {
                                dat.Push("asd");
                                err = "ERROR";
                                Console.WriteLine("-----werwewe eerrorr ---------------------");
                            }
                            else
                            {

                            }

                        }

                    }


                }
                else
                {


                    String ins = Convert.ToString(dat.Pop());



                    if (((Convert.ToString(temp[0])).Equals(Convert.ToString(ins))))
                    {
                        //Console.WriteLine("-----valor corecto en valor valores ---------------------");
                    }
                    else
                    {
                        err = "ERROR";
                        dat.Push("aes");
                        Console.WriteLine("-----EERRR ---------------------");

                    }

                }



                if ((con == 6))
                {
                    break;


                }
            }


        }catch{
            err = "ERROR";

    }
            if(dat.Count>0){
            //error
            
            }else{
                colors = Convert.ToString(((ArrayList)tabla[fila + 6])[0]);
            }




            return err;
        }

        //analisis orden etiqutas
        //analisis orden de frases
        //analisis valor cada uno

        //convierto valores 
        //lleno valores
        //envio valores

        //ejecuto valores

        public String Csuelo() {

            return colors;
        }
        public ArrayList Cpuertas()
        {

            return colopuertas;
        }
        public int noPuertas()
        {

            return puertas;
        }

        public int noVentanas()
        {

            return ventanas;
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
               
                default:
                    Char cim = '"';
                    try
                    {
                        if (Convert.ToChar(carac).Equals(cim))
                        {
                            tipo = "comilla";
                        }
                    }
                    catch { }

                    //singo desconocido
                    break;


            }
            //Console.WriteLine(tipo + "+++++");

            return tipo;
        }






        public ArrayList Grafi()
        { 
        
        //si solo todo bien
            ArrayList Dnecesario = new ArrayList();



            ArrayList datos1 = new ArrayList();
            ArrayList datos2 = new ArrayList();
            ArrayList datos3 = new ArrayList();
            ArrayList datos5 = new ArrayList();

            for(int i=0;i<tabla.Count;i++){

                ArrayList temp = (ArrayList)tabla[i];

                if(Convert.ToString(temp[0]).Equals("<pared>")){
                     datos1 =paredG(i);

                    int suma = 21;

                    for (int j = 0; j <= 2; j++)
                    {
                        if(suma>tabla.Count){
                        
                        }else{
                        
                        
                        ArrayList tempv = (ArrayList)tabla[i + suma];

                        if (tempv[0].Equals("nombre"))
                        {
                            if(j==0){
                                datos2 = paredG(i + suma - 1);
                            }else if(j==1){
                                datos3 = paredG(i + suma - 1);
                            }else if(j==2){
                                datos5 = paredG(i + suma - 1);
                            }
                        }
                        else
                        {
                        }
                        
                    }
                        suma = suma + 20;

                    }

                    Console.WriteLine("valores "+datos1.Count);
                    Console.WriteLine("valores " + datos2.Count);
                    Console.WriteLine("valores " + datos3.Count);
                    Console.WriteLine("valores " + datos5.Count);


                    for (int j = 0; j <= 3;j++ )
                    {


                    
                            if((datos1.Count==7)&&(j==0)){
                                String nombre = Convert.ToString(datos1[0]);
                                String color = Convert.ToString(datos1[1]);
                                double z = Convert.ToDouble(datos1[2]);
                                double x1 = Convert.ToDouble(datos1[3]);
                                double y1 = Convert.ToDouble(datos1[4]);
                                double x2 = Convert.ToDouble(datos1[5]);
                                double y2 = Convert.ToDouble(datos1[6]);
                                Console.WriteLine("s " + z);
                                Console.WriteLine("s " + x1);
                                Console.WriteLine("s " + y1);
                                Console.WriteLine("s " + x2);
                                Console.WriteLine("s " + y2);
                                Console.WriteLine("s " + color);
                                


                                Dnecesario.Add(coordenadas(nombre,color, z, x1, y1, x2, y2));
                            }
                            else if ((datos2.Count == 7) && (j == 1))
                            {
                                String nombre = Convert.ToString(datos2[0]);
                                String color = Convert.ToString(datos2[1]);
                                double z = Convert.ToDouble(datos2[2]);
                                double x1 = Convert.ToDouble(datos2[3]);
                                double y1 = Convert.ToDouble(datos2[4]);
                                double x2 = Convert.ToDouble(datos2[5]);
                                double y2 = Convert.ToDouble(datos2[6]); Console.WriteLine("s " + z);
                                Console.WriteLine("s " + x1);
                                Console.WriteLine("s " + y1);
                                Console.WriteLine("s " + x2);
                                Console.WriteLine("s " + y2);
                                Console.WriteLine("s " + color);
                                Dnecesario.Add(coordenadas(nombre, color, z, x1, y1, x2, y2));
                            }
                            else if ((datos3.Count == 7) && (j == 2))
                            {
                                String nombre = Convert.ToString(datos3[0]);
                                String color = Convert.ToString(datos3[1]);
                                double z = Convert.ToDouble(datos3[2]);
                                double x1 = Convert.ToDouble(datos3[3]);
                                double y1 = Convert.ToDouble(datos3[4]);
                                double x2 = Convert.ToDouble(datos3[5]);
                                double y2 = Convert.ToDouble(datos3[6]);
                                Console.WriteLine("s " + z);
                                Console.WriteLine("s " + x1);
                                Console.WriteLine("s " + y1);
                                Console.WriteLine("s " + x2);
                                Console.WriteLine("s " + y2);
                                Console.WriteLine("s " + color);
                                Dnecesario.Add(coordenadas(nombre, color, z, x1, y1, x2, y2));
                            }
                            else if ((datos5.Count == 7) && (j == 3))
                            {
                                String nombre = Convert.ToString(datos1[0]);
                                String color = Convert.ToString(datos5[1]);
                                double z = Convert.ToDouble(datos5[2]);
                                double x1 = Convert.ToDouble(datos5[3]);
                                double y1 = Convert.ToDouble(datos5[4]);
                                double x2 = Convert.ToDouble(datos5[5]);
                                double y2 = Convert.ToDouble(datos5[6]);
                                Dnecesario.Add(coordenadas(nombre, color, z, x1, y1, x2, y2));
                            }
                            else { 
                            
                            }

                    }


                    break;
                }else{
                
                }

            }

            return Dnecesario;
        }
        private ArrayList paredG(int fila)
        {
            Stack dat = new Stack();
            Console.WriteLine("ingreso a PARED++++++++++++++++++++999" + fila);

            ArrayList datos = new ArrayList();
            //nombre ,color, alto , inici , fin
            dat.Push(";");
            dat.Push("num");
            dat.Push(",");
            dat.Push("num");
            dat.Push(":");
            dat.Push("fin");

            dat.Push("num");
            dat.Push(",");
            dat.Push("num");
            dat.Push(":");
            dat.Push("inicio");

            dat.Push("num");
            dat.Push(":");
            dat.Push("alto");

            ArrayList colo = new ArrayList();
            colo.Add("azul");
            colo.Add("rojo");
            colo.Add("verde");
            colo.Add("cafe");
            colo.Add("blanco");
            colo.Add("negro");
            colo.Add("amarillo");
            colo.Add("beige");


            dat.Push(colo);
            dat.Push(":");
            dat.Push("color");

            dat.Push("val");
            dat.Push(":");
            dat.Push("nombre");
            //try
            //{
                int con = 0;
                for (int i = fila + 1; i < tabla.Count; i++)
                {
                    ArrayList temp = (ArrayList)tabla[i];

                   // Console.WriteLine("EVALUA EVALUA ++++++++++++++++++++999" + temp[0]);
                    con++;
                    if ((con == 9) || (con == 12) || (con == 14) || (con == 17) || (con == 19))
                    {
                        String ins = Convert.ToString(dat.Pop());



                        if (((tipo(Convert.ToString(((String)temp[0])[0]))).Equals("numero")))
                        {
                            datos.Add(temp[0]);
                        }
                        else
                        {
                            dat.Push("asdf");
                            Console.WriteLine("-----EERRR ---------------------");
                        }


                    }
                    else if ((con == 3))
                    {

                        String ins = Convert.ToString(dat.Pop());


                        if (((tipo(Convert.ToString(((String)temp[0])[0]))).Equals("letra")))
                        {
                            datos.Add(temp[0]);
                        }
                        else
                        {
                            dat.Push("asdf");
                            Console.WriteLine("-----EERRR ---------------------");
                        }


                    }
                    else if (con == 6)
                    {

                        ArrayList ins2 = (ArrayList)dat.Pop();

                        for (int j = 0; j < ins2.Count; j++)
                        {
                            if (((temp[0]).Equals(ins2[j])))
                            {
                                datos.Add(temp[0]);
                            }
                            else
                            {

                                if (i == (ins2.Count - 1))
                                {
                                    dat.Push("asd");

                                    Console.WriteLine("-----werwewe eerrorr ---------------------");
                                }
                                else
                                {

                                }

                            }

                        }


                    }
                    else
                    {


                        String ins = Convert.ToString(dat.Pop());



                        if (((Convert.ToString(temp[0])).Equals(ins)))
                        {
                            
                        }
                        else
                        {

                            if (((Convert.ToString(temp[0])).Equals("largo")))
                            {
                                Stack dat2 = new Stack();

                                dat2.Push("num");
                                dat2.Push(":");
                                dat2.Push("ancho");
                                dat2.Push("num");
                                dat2.Push(":");
                                dat = dat2;


                            }
                            else
                            {
                                Console.WriteLine("-----EERRR ---------------------");
                            }
                        }

                    }



                    if ((con == 20))
                    {
                        break;


                    }
                }

            //}
            //catch
            //{

            //}



            //if (dat.Count == 0)
            //{
            //ArrayList tempv = (ArrayList)tabla[fila + 21];
            ////Console.WriteLine("-----todo cumplio variables---------------------" + temp[0]);
            //if (tempv[0].Equals("nombre"))
            //{
            //    pared(fila + 20);

            //}
            //else
            //{

            //}

            //}
            //else
            //{
            //    Console.WriteLine("-----no se vacio pila---------------------");
            //}

            return datos;

        }


      

        private ArrayList coordenadas(String nombre, String color, double z, double x1, double y1, double x2, double y2)
        {

            ArrayList datos = new ArrayList();
            datos.Add(nombre);
            datos.Add(x1);
            datos.Add(y1);
            datos.Add(x2);
            datos.Add(y2);
            datos.Add(z);

            paredes.Add(datos);
            datos = new ArrayList();

            double restax = x2 - x1;
            double restay = y2 - y1;

            double[] arrays = new double[12];

            arrays[0] = y1; //x
            arrays[1] = 0; //y
            arrays[2] = x1; //z

            arrays[3] = y1;
            arrays[4] = z;
            arrays[5] = x1;

            arrays[6] = y2;
            arrays[7] = z;
            arrays[8] = x2;

            arrays[9] = y2;
            arrays[10] = 0;
            arrays[11] = x2;


            datos.Add(arrays);
            datos.Add(color);
           

           



            if(restax==0){
            //infinito  es recta pared
            




            }else{

            
            }


           // Math.Pow (Double, Double)



            return datos;
        
        }





    }
}
