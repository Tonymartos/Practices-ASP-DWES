Imports Microsoft.VisualBasic

Public Class generadorPassword

    Private password As String
    Private Shared todas As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz123456789."
    'instancia clase random
    Dim rnd As New Random

    Public Sub New()
        password = generador(15)
    End Sub
    Public Sub New(ByVal size As Integer)
        If size < 6 And size > 15 Then
            size = 15
        End If
        password = generador(size)
    End Sub

    Public ReadOnly Property Pw() As String
        Get
            Return password
        End Get
    End Property

    Public Shared Function Validar(ByVal p As String) As Boolean
        Dim ok As Boolean = True
        For i = 0 To p.Length - 1
            If Not todas.Contains(p(i)) Then
                ok = False
                Exit For
            End If
        Next

    End Function

    Private Function generador(ByVal s As Integer) As String
        Dim cadena As String = Nothing
        For i = 0 To s - 1
            cadena &= todas(rnd.Next(0, todas.Length))
        Next
        Return cadena
    End Function
End Class
