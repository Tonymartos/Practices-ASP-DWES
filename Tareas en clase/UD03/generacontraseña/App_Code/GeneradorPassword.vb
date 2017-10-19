
Public Class GeneradorPassword

    Private password As String

    Private Shared source As String = "ABCDEFGHIJKLMNOPQRSTUUWXYZabcdefghijklmnopqrstuuwxyz1234567890."
    Private rnd As New Random

    Public Sub New()
        Me.New(15)
    End Sub

    Public Sub New(ByVal size As Integer)
        If size <= 6 Or size >= 15 Then size = 15
        password = generador(size)
    End Sub

    Public ReadOnly Property PW() As String
        Get
            Return password
        End Get
    End Property

    Private Function generador(ByVal s As Integer) As String
        Dim p As String = Nothing
        For i = 0 To s - 1
            p &= source(rnd.Next(0, source.Length))
        Next
        Return p
    End Function

    Public Shared Function Validar(ByVal p As String) As Boolean
        Dim ok As Boolean = True
        For i = 0 To p.Length - 1
            If Not source.Contains(p(i)) Then
                ok = False
                Exit For
            End If
        Next
        Return ok
    End Function

    Public Function casiIgual(ByVal p As String) As Boolean
        Dim ok As Boolean = False
        ' Caracteres a comparar, mínimo 4
        For i = 0 To p.Length - 4
            If password.Contains(p.Substring(i, 4)) Then
                ok = True
                Exit For
            End If
        Next
        Return ok
    End Function
End Class

