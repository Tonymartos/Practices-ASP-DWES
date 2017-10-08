using System;
using System.Web;
using System.IO;


// En tiempo de ejecución, Global.asax se analiza y se compila en una clase de .NET Framework generada dinámicamente que se deriva de la clase base HttpApplication. 

public class Contar : System.Web.HttpApplication
{

    public Int16 Visitas()
    {
        // HttpContext.Current Obtiene el objeto HttpContext que encapsula toda la información específica de HTTP acerca de la actual solicitud. 

        Int16 v;
        string contador = HttpContext.Current.Server.MapPath("~/") + "\\App_Data\\contador.txt";

        FileInfo archivo = new FileInfo(contador);

        if (archivo.Exists)
        {
            StreamReader leer = File.OpenText(contador);
            v = Int16.Parse(leer.ReadLine());
            v++;
            leer.Close();
        }
        else
        {
            v = 1;
        }

        StreamWriter escribir = File.CreateText(contador);
        escribir.WriteLine(v.ToString());
        escribir.Close();

        return v;
    }
}
