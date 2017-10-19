Imports System.IO

Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Accede a la ruta fisica del servidor y coge el archivo txt alojado en la carpeta archivos.
        Dim sr As StreamReader = New StreamReader(HttpContext.Current.Server.MapPath("~/") & "archivos/ejemplo.txt")
        Do While sr.Peek() >= 0
            Response.Write(sr.ReadLine & "</br>")
        Loop
        sr.Close()
    End Sub
End Class
