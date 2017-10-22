
Partial Class _inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            If (NifVB.Okey(TBnif.Text)) Then
                ' o bien
                'If (NifCS.Okey(TBnif.Text)) Then
                ' si usa el código en c#
                Lmensaje.Text = Nothing
                DDLvehiculos.DataSource = Consultas.VehiculosCliente(TBnif.Text, Server.MapPath("App_Data/Seguros.mdb"))
                DDLvehiculos.DataTextField = "matricula"
                DDLvehiculos.DataBind()
                PNpanel.Visible = True
            Else
                Lmensaje.Text = "El nif es incorrecto"
                TBnif.Text = Nothing
                PNpanel.Visible = False
            End If
        End If
    End Sub
End Class
