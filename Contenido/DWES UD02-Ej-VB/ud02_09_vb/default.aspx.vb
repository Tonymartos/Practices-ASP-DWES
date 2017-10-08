Partial Class _default
    Inherits System.Web.UI.Page

    Protected Sub BTcalcular_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTcalcular.Click
        Dim F, G, C As Decimal
        If Decimal.TryParse(TBgrados.Text, G) Then
            Select Case RBLtipo.SelectedValue
                Case "0"
                    F = (G * 9 / 5) + 32
                    TBtipo.Text = "Fahrenheits"
                    TBresultado.Text = Decimal.Round(F, 2).ToString
                Case "1"
                    C = (G - 32) * 5 / 9
                    TBtipo.Text = "Celsius"
                    TBresultado.Text = Decimal.Round(C, 2).ToString
            End Select
        Else
            Throw New System.Exception("La temperatura introducida no es correcta")
        End If
    End Sub

    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim miError As String
        Dim objErr As Exception = Server.GetLastError().GetBaseException()
        miError = "<h1><B>Error</B></h1><hr>" & _
                  "<br><B>En     : </B>" & Request.Url.ToString() & _
                  "<br><B>Mensaje: </B>" & objErr.Message.ToString() & _
                  "<br><B>Controlado Por:</B> Page_Error"
        Response.Write(miError.ToString())
        Server.ClearError()
    End Sub

End Class
