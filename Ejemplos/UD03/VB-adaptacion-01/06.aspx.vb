
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_LoadComplete(sender As Object, e As EventArgs) Handles Me.LoadComplete
        Response.Write(EnOrden("abcdefgh")) ' No previsto las cadenas vacías.
    End Sub

    Public Function EnOrden(ByVal palabra As String) As Boolean
        Dim anterior As Char
        Dim ok As Boolean = True
        Dim i As Int16 = 0

        anterior = palabra(0)
        i += 1
        While i < palabra.Length
            If palabra(i) < anterior Then
                ok = False
                Exit While
            End If
            anterior = palabra(i)
            i += 1
        End While
        Return ok
    End Function

End Class
