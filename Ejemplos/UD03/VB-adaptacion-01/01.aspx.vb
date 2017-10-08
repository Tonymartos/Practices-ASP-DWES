Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim x As Object() = Ec_2Grado(1, -5, 6)

        Response.Write(x(0) & "<br/>")
        Response.Write(x(1) & "<br/>")
    End Sub

    Public Function Ec_2Grado(ByVal a As Double, ByVal b As Double, ByVal c As Double) As Object()
        Dim x(1) As Object
        If a = 0 Then
            x(0) = Double.NaN
            x(1) = Double.NaN
        Else
            Dim D As Double = Math.Pow(b, 2) - (4 * a * c)
            Dim t1 As Double = -b / (2 * a)
            Dim t2 As Double = Math.Sqrt(Math.Abs(D)) / (2 * a)
            If D < 0 Then
                x(0) = t1 & " + " & t2 & " i"
                x(1) = t1 & " - " & t2 & " i"
            Else
                x(0) = t1 + t2
                x(1) = t1 - t2
            End If
        End If
        Return x
    End Function

End Class

