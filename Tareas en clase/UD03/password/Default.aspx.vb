
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim objetopass As New generadorPassword()

        Response.Write(objetopass.Pw)
    End Sub
End Class
