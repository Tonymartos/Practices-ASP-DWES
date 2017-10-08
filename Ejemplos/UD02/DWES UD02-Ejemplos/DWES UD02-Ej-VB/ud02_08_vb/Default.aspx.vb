
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub ProcesarBotonASP(ByVal sender As Object, ByVal e As System.EventArgs)
        Response.Write("<scr" + "ipt> alert('Tras ejecutar el correspondiente código en el cliente, se ejecuta esta acción en el servidor.') </scr" + "ipt>")
    End Sub

End Class
