using System;

public partial class _default : System.Web.UI.Page
{
    string todas = "TRWAGMYFPDXBNJZSQVHLCKE";

    // Manejador de evento asignado, en el marcado aspx, a la propiedad OnTextChanged de la etiqueta correspondiente. 
    // La firma del delegado debe ser la adecuada. Recomendación: al escribir la propiedad en el marcado, utilizar la etiqueta inteligente para crear un nuevo manejador de evento.
    protected void TBdniCambio(object sender, EventArgs e)
    {
        PNpanel.Visible = false;
        Lmensaje.Text = "Su NIF es: " + ((Okey(TBdni.Text)) ? "Correcto" : "Incorrecto");
    }

    bool Okey(string n)
    {
        char l = n[n.Length - 1];
        string nu = n.Substring(0, n.Length - 1);
        bool ok = Okey(nu, l);
        return ok;
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