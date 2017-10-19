
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub Buno_Click(sender As Object, e As EventArgs) Handles Buno.Click
        Dim numero = DDLsize.SelectedValue
        Dim obj = New GeneradorPassword(numero)
        Lresultado.Text = obj.PW
    End Sub

    Private Sub Bvalidar_Click(sender As Object, e As EventArgs) Handles Bvalidar.Click
        Dim claveobtenida As String = TBvalidar.Text
        Lresultado.Text = GeneradorPassword.Validar(claveobtenida)
    End Sub
End Class