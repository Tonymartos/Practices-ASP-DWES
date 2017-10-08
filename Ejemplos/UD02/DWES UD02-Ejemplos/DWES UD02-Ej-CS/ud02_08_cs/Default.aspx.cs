
public partial class _Default : System.Web.UI.Page
{
    protected void ProcesarBotonASP(object sender, System.EventArgs e)
    {
        Response.Write("<scr" + "ipt> alert('Tras ejecutar el correspondiente código en el cliente, se ejecuta esta acción en el servidor.') </scr" + "ipt>");
    }
}