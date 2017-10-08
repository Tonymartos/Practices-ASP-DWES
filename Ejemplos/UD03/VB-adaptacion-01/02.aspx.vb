
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Response.Write(dias(2, 2012))
    End Sub

    Public Function dias(ByVal mes As SByte, ByVal anio As Short) As SByte
        Dim d As SByte = 0
        If mes >= 1 And mes <= 12 Then
            Select Case mes
                Case 1, 3, 5, 7, 8, 10, 12
                    d = 31
                Case 4, 6, 9, 11
                    d = 30
                Case 2
                    If anio Mod 4 = 0 And Not (anio Mod 100 = 0 And anio Mod 400 <> 0) Then
                        d = 29
                    Else
                        d = 28
                    End If
            End Select
        End If
        Return d
    End Function

End Class
