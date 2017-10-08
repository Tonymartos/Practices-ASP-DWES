
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Response.Write(Sentencia("26100100E", "García Sánchez, José", "953606060"))
        Response.Write("<br/>")
        Response.Write(Sentencia("26100100E", "García Sánchez, José"))

    End Sub

    Public Function Sentencia(ByVal nif As String, ByVal nombre As String, Optional ByVal telefono As String = Nothing) As String
        Dim cadena As New System.Text.StringBuilder(
                       "insert into Alumnos values('<nif>','<nombre>',<telefono>)")
        cadena.Replace("<nif>", nif)
        cadena.Replace("<nombre>", nombre)
        cadena.Replace("<telefono>", IIf(telefono <> Nothing, "'" & telefono & "'", "NULL"))
        Return cadena.ToString
    End Function

End Class
