
Imports System.IO

Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each imagen In ImgAll("C:\Users\diego\Pictures")
            Response.Write(imagen & "<br/>")
        Next
    End Sub

    Public Function ImgAll(ByVal carpeta As String) As ArrayList
        Dim tipos As String() = {".JPG", ".JPEG", ".BMP", ".PNG", ".GIF"}
        Dim imgs As New ArrayList
        If Directory.Exists(carpeta) Then
            Dim pContenedor As DirectoryInfo = New DirectoryInfo(carpeta)
            Dim infoContenido As FileInfo() = pContenedor.GetFiles
            For Each item In infoContenido
                If Array.IndexOf(tipos, item.Extension.ToUpper) >= 0 Then ' Sin Linq (Contains)
                    imgs.Add(item.Name)
                End If
            Next
        End If
        Return imgs
    End Function

End Class
