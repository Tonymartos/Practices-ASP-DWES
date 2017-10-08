
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim a() As Integer = {4, 8, 9, 6, 1, 3, 4, 0}

        Ordenar(a)

        For Each item In a
            Response.Write(item.ToString + "<br/>")
        Next
    End Sub

    Public Sub Ordenar(ByRef A() As Integer)
        Dim s As Integer = A.GetLength(0)
        Dim i, j As Integer
        For i = 1 To s - 1
            For j = s - 1 To i Step -1
                If A(j) < A(j - 1) Then
                    Swap(A(j), A(j - 1))
                End If
            Next
        Next
    End Sub

    Protected Sub Swap(ByRef x As Object, ByRef y As Object)
        Dim aux As Object = x
        x = y
        y = aux
    End Sub

End Class
