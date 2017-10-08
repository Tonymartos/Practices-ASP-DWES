

Partial Class _Default
    Inherits System.Web.UI.Page

    Public Sub BTenviar_Click(sender As Object, e As EventArgs) Handles BTenviar.Click
        'Variables de cada valor de las Cajas de Texto
        Dim a As Double = TBuno.Text
        Dim b As Double = TBdos.Text
        Dim c As Double = TBtres.Text
        'Dim x = New ec2g (Double.Parse(TBuno.Text),Double.Parse(TBdos.Text),Double.Parse(TBtres.Text))
        'Instanciar objeto con sus respectivos valores a, b y c
        Dim x = New ec2g(a, b, c)

        'Realizar Verificacion del Boton Check para extraer el numero real
        If CBCheck.Checked = True Then
            Dim dreal = x.D
            If dreal >= 0 Then
                borrarbotones()
                resultadoxuno.Text = "x1=" & ec2g.Imprimir(x.x0, 2)
                resultadoxdos.Text = "x2=" & ec2g.Imprimir(x.x1, 2)
                BTvolver.Visible = True
            Else
                borrarbotones()
                Response.Write("Error: No se puede realizar la ecuación")
                BTvolver.Visible = True
            End If
        Else
            borrarbotones()
            resultadoxuno.Text = "x1= " & ec2g.Imprimir(x.x0, 2)
            resultadoxdos.Text = "x2=" & ec2g.Imprimir(x.x1, 2)
        End If
    End Sub
    ' Gestion de errores nivel pagina
    Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        Dim miError As String
        Dim objErr As Exception = Server.GetLastError().GetBaseException()
        miError = "<h1><B>Error</B></h1><hr>" &
                  "<br><B>En     : </B>" & Request.Url.ToString() &
                  "<br><B>Mensaje: </B>" & objErr.Message.ToString() &
                  "<br><B>Controlado Por:</B> Page_Error"
        Response.Write(miError.ToString())
        Server.ClearError()
    End Sub

    Private Sub BTvolver_Click(sender As Object, e As EventArgs) Handles BTvolver.Click
        BTvolver.Visible = True
        Response.Redirect("Default.aspx")
    End Sub

    Protected Function borrarbotones() As Boolean
        TBuno.Visible = False
        Label1.Visible = False
        TBdos.Visible = False
        Label2.Visible = False
        TBtres.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        CBCheck.Visible = False
        BTenviar.Visible = False
        BTvolver.Visible = True
    End Function


End Class
