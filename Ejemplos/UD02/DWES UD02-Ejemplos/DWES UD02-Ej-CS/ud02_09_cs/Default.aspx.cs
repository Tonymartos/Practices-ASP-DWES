using System;

public partial class _Default : System.Web.UI.Page
{
    protected void BTcalcular_Click(object sender, EventArgs e)
    { 
        Decimal F, G, C;
        if (Decimal.TryParse(TBgrados.Text, out G))
        {
            switch (RBLtipo.SelectedValue)
            {
                case "0":
                    F = (G * 9 / 5) + 32;
                    TBtipo.Text = "Fahrenheits";
                    TBresultado.Text = Decimal.Round(F, 2).ToString();
                    break;
                case "1":
                    C = (G - 32) * 5 / 9;
                    TBtipo.Text = "Celsius";
                    TBresultado.Text = Decimal.Round(C, 2).ToString();
                    break;
            }
        }
        else
        {
            throw new System.Exception("La temperatura introducida no es correcta");
        }
    }

    protected void Page_Error(object sender, System.EventArgs e)
    {
        string miError;
        Exception objErr = Server.GetLastError().GetBaseException();
        miError = "<h1><B>Error</B></h1><hr>" +
                  "<br><B>En     : </B>" + Request.Url.ToString() +
                  "<br><B>Mensaje: </B>" + objErr.Message.ToString() +
                  "<br><B>Controlado Por:</B> Page_Error";
        Response.Write(miError.ToString());
        Server.ClearError();
    }

   
}