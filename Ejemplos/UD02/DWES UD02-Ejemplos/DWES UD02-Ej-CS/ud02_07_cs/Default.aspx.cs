using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void CambioRadioButton(object sender, System.EventArgs e)
    {
        TBobservaciones.Text = TBobservaciones.Text + "\r\n" + "La elección del modo de pago es devuelta y gestionada en el servidor. Opción seleccionada:" + RBLmodopago.SelectedValue;
    }

    protected void ProcesarBotones(object sender, System.EventArgs e)
    {
        Button b;
        b = (Button)sender;
        switch (b.ID)
        {
            case "BTborrar":
                TBobservaciones.Text = TBobservaciones.Text + "\r\n" + "Ha hecho clic sobre el botón Nuevos Datos. La página ha sido devuelta al servidor, donde se ha detectado qué botón ha sido pulsado y se ha procesado.";
                break;
            case "BTreservar":
                TBobservaciones.Text = TBobservaciones.Text + "\r\n" + "Ha hecho clic sobre el botón Realizar reservas. La página ha sido devuelta al servidor, donde se ha detectado qué botón ha sido pulsado y se ha procesado.";
                break;
        }
    }

    protected void ProcesarCheckBox(object sender, System.EventArgs e)
    {
        TBobservaciones.Text = TBobservaciones.Text + "\r\n" + "CheckBox ha cambiado, respecto a la última devolución.";
    }

}