
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load()

        ' La fecha es obtenida aquí.
        '
        ' La hora y el número de visitante son cargadas en Global.asax en una variable de sesión.
        '
        ' El número de usuarios conectados, cargado en Global.asax y almacenado en una variable de aplicación.

        Lfecha.Text = DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy")
        Lhora.Text = Session("hora").ToString()
        Lusuario.Text = Session("nVisitante").ToString()
        LusuariosOnline.Text = Application("nUsuarios").ToString()
    End Sub
End Class
