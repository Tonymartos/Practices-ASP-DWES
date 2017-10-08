
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Ejemplo de utilización:
        Dim u As Object() = {1, 7, 1, 7, "B"}
        Dim v As Object() = {8, "B", 7, 4, "B", 5}

        Response.Write(Vector.indiceOf(u, 7) & ";<br/>") ' Devuelve 1
        For Each item In Vector.union(u, v) ' Devuelve {1,7,”B”,8,4,5}
            Response.Write(item & "<br/>")
        Next
    End Sub

End Class
