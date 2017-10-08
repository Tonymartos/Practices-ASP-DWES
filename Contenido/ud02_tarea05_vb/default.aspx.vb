
Partial Class _default
    Inherits System.Web.UI.Page

    Private Sub BTaceptar_Click(sender As Object, e As EventArgs) Handles BTaceptar.Click
        Dim numero As Int16
        If Int16.TryParse(TBnumero.Text, numero) Then
            For i As Integer = 1 To 10
                ' Creamos una fila.
                Dim fila As TableRow = New TableRow()

                ' Y sus correspondientes columnas
                Dim col1 As TableCell = New TableCell()
                col1.Text = numero & "*" & i
                fila.Cells.Add(col1)

                Dim col2 As TableCell = New TableCell()
                col2.Text = "="
                fila.Cells.Add(col2)

                Dim col3 As TableCell = New TableCell()
                With col3
                    .Font.Bold = True
                    '.ForeColor = Drawing.Color.Blue
                    '.ForeColor = Drawing.Color.FromArgb(0, 0, 255)
                    .ForeColor = System.Drawing.ColorTranslator.FromHtml("#0000FF")
                    .Text = numero * i
                End With
                fila.Cells.Add(col3)

                ' Añadimos la fila, ya creada, a la tabla
                Tmultiplicar.Rows.Add(fila)
            Next
        Else
            TBnumero.Text = Nothing
        End If
    End Sub
End Class
