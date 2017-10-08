using System;

public partial class respuesta : System.Web.UI.Page
{
    string todas = "TRWAGMYFPDXBNJZSQVHLCKE";
    protected void Page_Load(object sender, EventArgs e)
    {
        string mensaje = " Letra del NIF ¡Incorrecta!";
        string N, L;
        if (Request.UrlReferrer.ToString().Contains("default.aspx"))
        {
            string metodo = Request.RequestType;
            if (metodo == "GET")
            {
                N = Request.QueryString["dni"];
                L = Request.QueryString["letra"].ToUpper();

            }
           else
            {
                N = Request.Form["TBdniAsp"];
                L = Request.Form["TBletraAsp"].ToUpper();
            }
            if (L.Length == 1)
            {
                if (Okey(N, L[0])) mensaje = "Letra del NIF ¡Correcta!";
            }
        }
        else
        {
            mensaje = "Acceso prohibido";
        }
        Lmensaje.Text = mensaje;
    }

    bool Okey(string n, char l)
    {
        bool ok = false;
        try
        {
            l = char.ToUpper(l);
            char Le = todas[int.Parse(n) % 23];
            if (Le == l) ok = true;
        }
        catch
        { }
        return ok;
    }

}