
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Unload(sender As Object, e As EventArgs) Handles Me.Unload
        Dim cadenafrase As String = "Ejercicio referencia a count chars de php"
        Cuentacadena(cadenafrase)
    End Sub

    Private Sub Cuentacadena(ByRef cadena As String)

        For Each item In cadena.ToCharArray
            Response.Write("" & item)
        Next

    End Sub
End Class
