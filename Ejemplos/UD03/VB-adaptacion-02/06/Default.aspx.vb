
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim A As New Lista From {"uno", "dos", "tres", "cuatro"}
        Dim B As New Lista
        B.Add("cinco")
        B.Add("seis")

        'For Each i In A + B
        '    Response.Write(i & "<br/>")
        'Next

        'Dim c = "siete"
        'For Each i In A + c
        '    Response.Write(i & "<br/>")
        'Next

        'Dim d = "dos"
        'For Each i In A - d
        '    Response.Write(i & "<br/>")
        'Next

        'Dim F As New Lista From {"dos", "cuatro"}
        'For Each i In A - F
        '    Response.Write(i & "<br/>")
        'Next

        'For Each i In -A
        '    Response.Write(i & "<br/>")
        'Next

        Dim G As New Lista From {"uno", "dos", "tres", "cuatro"}
        Response.Write(A = G)
    End Sub

End Class
