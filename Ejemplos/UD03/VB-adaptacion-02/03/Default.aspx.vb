
Partial Class _Default
    Inherits System.Web.UI.Page

    'WithEvents miCC As New Cuenta("1234567890", 10000) ' Alternativa a AddHandler
    Dim miCC As New Cuenta("1234567890", 10000)

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load

        AddHandler miCC.eReintegro, AddressOf ManejarEvento

        'miCC.estado = False

        miCC.Ingreso(200.568)

        miCC.Reintegro(500.215)

        For Each i In miCC.GetType.GetProperties
            Response.Write(i.Name & ":" & i.GetValue(miCC, Nothing).ToString & "<br/>")
        Next


        Dim otraCC As New Cuenta("2333444555", 200.0)
        'otraCC.estado = False
        miCC.Traspaso(100, otraCC)

        Response.Write(miCC.ToString & "<br/>")
        Response.Write(otraCC.ToString & "<br/>")
    End Sub

    Public Sub ManejarEvento(ByVal cantidad As Decimal, ByVal saldo As Decimal)
        MsgBox("En su cuenta se ha realizado un reintegro de " & cantidad & " €. Su nuevo saldo es de " & saldo & " €")
    End Sub


    'Public Sub ManejarEvento(ByVal cantidad As Decimal, ByVal saldo As Decimal) Handles miCC.eReintegro
    '    MsgBox("En su cuenta se ha realizado un reintegro de " & cantidad & " €. Su nuevo saldo es de " & saldo & " €")
    'End Sub

End Class
