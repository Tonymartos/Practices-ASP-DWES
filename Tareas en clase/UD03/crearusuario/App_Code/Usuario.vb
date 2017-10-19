Imports Microsoft.VisualBasic
Imports System.IO

Public Class Usuario

    Dim diccionario As New Dictionary(Of String, String)

    Public Sub usuarios(ByRef valor As String, ByVal usuario As String, ByVal password As String)
        Dim lectura As StreamReader = New StreamReader(HttpContext.Current.Server.MapPath("~/") & "archivos/ejemplo.txt")
        Do While lectura.Peek() >= 0
            Dim leerusuario = lectura.ReadLine()
            Dim cogerusuario = leerusuario.Split(",")
            Dim cogernombre = cogerusuario.GetValue(0)
            Dim cogercontraseña = cogerusuario.GetValue(1)
        Loop
        lectura.Close()
    End Sub

    Public Function validar(ByVal usuario As String, ByVal contraseña As String)

    End Function


End Class
