
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Soluciones reales
        'Dim ecuacion As New ec2g(1, -5, 6) ' 3 y 2
        'Dim ecuacion As New ec2g(1, 0, -4)  ' 2 y -2
        'Dim ecuacion As New ec2g(1, 2, 1)  ' -1 (doble)
        'Dim ecuacion As New ec2g(1, 1) ' 0 y -1

        ' Soluciones imaginarias
        'Dim ecuacion As New ec2g(1, -2, 2) ' 1+i y 1-i
        'Dim ecuacion As New ec2g(2, 4, 3)   ' -1-0.7i y -1+0.7i
        'Dim ecuacion As New ec2g(1, -2, 5) ' 1+2i y 1-2i
        'Dim ecuacion As New ec2g(1, 0, 1)   ' i y -i
        'Dim ecuacion As New ec2g(1, 0, 4)   ' 2i y -2i
        Dim ecuacion As New ec2g(1, -6, 10) ' 3+i y 3-i

        Response.Write(ecuacion.x0.ToString & "<br/>")
        Response.Write(ecuacion.x1.ToString & "<br/>")

        Response.Write(ec2g.Imprimir(ecuacion.x0) & "<br/>")
        Response.Write(ec2g.Imprimir(ecuacion.x1) & "<br/>")
    End Sub

End Class
