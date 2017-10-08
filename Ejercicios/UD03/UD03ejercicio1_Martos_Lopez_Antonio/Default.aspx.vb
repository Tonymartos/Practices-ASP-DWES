
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub Buno_Click(sender As Object, e As EventArgs) Handles Buno.Click
        Dim frase = TBuno.Text.ToLower
        Dim letra = TBdos.Text
        contarcadena(frase, letra)
    End Sub

    Private Function contarcadena(ByRef cadena As String, Optional caracter As Char = Nothing) As Object
        Dim encontrado As Boolean

        If caracter = Nothing Then
            encontrado = False
            GoTo salir
        Else
            Dim contador As Int16 = 0
            For x = 0 To cadena.Length - 1
                If cadena(x) = caracter Then
                    contador += 1
                End If
            Next
            Response.Write("El caracter " & caracter & " se repite en la cadena : " & contador & " veces ")
        End If
salir:
    End Function
End Class