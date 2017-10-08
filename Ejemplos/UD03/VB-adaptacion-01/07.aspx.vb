
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim p(,) As Byte = {{1, 6, 2}, {6, 2, 4}, {2, 4, 8}}
        Response.Write(Simetrica(p))
    End Sub

    Public Function Simetrica(ByVal A(,) As Byte) As Boolean
        ' Comprueba que una matriz es simétrica.
        Dim i, j As Byte
        Dim ok As Boolean = False

        Dim m As Byte = A.GetLength(0)
        Dim n As Byte = A.GetLength(1)
        ' Tiene que ser cuadrada.
        If m = n Then
            For i = 0 To m - 1
                For j = 0 To n - 1
                    If i <> j Then
                        If A(i, j) <> A(j, i) Then
                            ' Se usa GoTo para forzar la  
                            ' salida de los dos bucles a la vez y no continuar con las comparaciones.
                            ' Exit For sale solo de un nivel.
                            GoTo salir
                        End If
                    End If
                Next
            Next
            ok = True
        End If
salir:
        Return ok
    End Function

End Class
