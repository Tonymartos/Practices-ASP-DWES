
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim miCC As New Corriente("1234567890", 150)
        miCC.limite = 50
        'miCC.estado = False
        miCC.Ingreso(100)
        miCC.Reintegro(50)
        For Each i In miCC.GetType.GetProperties
            Response.Write(i.Name & ":" & i.GetValue(miCC, Nothing).ToString & "<br/>")
        Next

        Dim otraCC As New Corriente("2333444555", 200)
        miCC.Traspaso(25, otraCC)
        Response.Write(miCC.ToString & "<br/>")
        Response.Write(otraCC.ToString & "<br/>")

        Dim otraA As New Ahorro("1222333444", 500)
        miCC.Traspaso(25, otraA)
        Response.Write(miCC.ToString & "<br/>")
        Response.Write(otraA.ToString & "<br/>")

    End Sub

End Class
