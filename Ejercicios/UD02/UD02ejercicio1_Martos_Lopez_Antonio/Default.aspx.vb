
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub BTenviar_Click(sender As Object, e As EventArgs) Handles BTenviar.Click
        Dim a As Double = TBuno.Text
        Dim b As Double = TBdos.Text
        Dim c As Double = TBtres.Text
        Dim x = New ec2g(a, b, c)

        resultadoxuno.Text = "x1= " & ec2g.Imprimir(x.x0, 3)
        resultadoxdos.Text = "x2=" & ec2g.Imprimir(x.x1, 3)
    End Sub
End Class
