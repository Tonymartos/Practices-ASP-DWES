
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim recuento As New List(Of Votacion)
        recuento.Add(New Votacion With (.partido = "PSOE", .votos = ""))
        recuento.Add(New Votacion With (.partido = "PSOE", .votos = ""))
        recuento.Add(New Votacion With (.partido = "PSOE", .votos = ""))
        recuento.Add(New Votacion With (.partido = "PSOE", .votos = ""))

        recuento.Sort()

        For Each In recuento
            Response.Write(i.partido & " - " & )
        Next

    End Sub
End Class

Public Structure Votacion
    Public partido As String
    Public votos As Integer

End Structure
