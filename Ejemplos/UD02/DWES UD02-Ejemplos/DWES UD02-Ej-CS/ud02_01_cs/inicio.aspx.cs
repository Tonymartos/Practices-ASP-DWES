using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _inicio: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            if (NifCS.Okey(TBnif.Text))
            {
                //  o bien
                //  if (NifVB.Okey(TBnif.Text)) 
                //  si usa el código en VB
                Lmensaje.Text = null;
                DDLvehiculos.DataSource = Consultas.VehiculosCliente(TBnif.Text, Server.MapPath("App_Data/Seguros.mdb"));
                DDLvehiculos.DataTextField = "matricula";
                DDLvehiculos.DataBind();
                PNpanel.Visible = true;
            }
            else
            {
                Lmensaje.Text = "El nif es incorrecto";
                TBnif.Text = null;
                PNpanel.Visible = false;
            }
        }
    }
}