<%@ Application Language="VB" %>

<script runat="server">
    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Código que se ejecuta al iniciarse la aplicación.
        ' Cuando entra el primer usuario a la aplicación.
        Application("nUsuarios") = 0
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Código que se ejecuta durante el cierre de aplicaciones.
        ' Cuando sale el último usuario de la aplicación.
        Application.Clear()
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Código que se ejecuta cuando se inicia una nueva sesión
        ' Cuando entra un nuevo usuario.
        Session("nVisitante") = New Contar().Visitas
        Session("hora") = DateTime.Now.ToString("HH:mm")

        Application.Lock()
        Application("nUsuarios") = Int16.Parse(Application("nUsuarios").ToString()) + 1
        Application.UnLock()
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Código que se ejecuta cuando finaliza una sesión. 
        ' Cuando sale un usuario.
        Application.Lock()
        Application("nUsuarios") = Int16.Parse(Application("nUsuarios").ToString()) - 1
        Application.UnLock()

    End Sub

    Protected Sub Application_BeginRequest(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Este manejador de evento, realiza verificaciones de rutas de acceso y ayuda a prevenir los caracteres no válidos y las direcciones URL mal formadas.
        ' Código creado por Microsoft (violación de seguridad).

        If Request.Path.IndexOf("\") >= 0 Or _
        System.IO.Path.GetFullPath(Request.PhysicalPath) <> Request.PhysicalPath Then
            Throw New HttpException(404, "not found")
        End If
    End Sub
</script>