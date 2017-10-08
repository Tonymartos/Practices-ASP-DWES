
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub CambioRadioButton(ByVal sender As Object, ByVal e As System.EventArgs)
        TBobservaciones.Text = TBobservaciones.Text & vbCrLf & "La elección del modo de pago es devuelta y gestionada en el servidor. Opción seleccionada:" & RBLmodopago.SelectedValue
    End Sub

    Protected Sub ProcesarBotones(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim b As Button
        b = CType(sender, Button)
        Select Case (b.ID)
            Case "BTborrar"
                TBobservaciones.Text = TBobservaciones.Text & vbCrLf & "Ha hecho clic sobre el botón Nuevos Datos. La página ha sido devuelta al servidor, donde se ha detectado qué botón ha sido pulsado y se ha procesado."
            Case "BTreservar"
                ' vbCrlf => Chr(13) & Chr(10)
                TBobservaciones.Text = TBobservaciones.Text & Chr(13) & Chr(10) & "Ha hecho clic sobre el botón Realizar reservas. La página ha sido devuelta al servidor, donde se ha detectado qué botón ha sido pulsado y se ha procesado."
        End Select
    End Sub

    Protected Sub ProcesarCheckBox(ByVal sender As Object, ByVal e As System.EventArgs)
        TBobservaciones.Text = TBobservaciones.Text & vbCrLf & "CheckBox ha cambiado, respecto a la última devolución."
    End Sub

End Class
