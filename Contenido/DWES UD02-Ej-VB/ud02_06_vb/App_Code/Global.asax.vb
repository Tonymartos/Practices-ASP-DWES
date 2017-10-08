Option Explicit Off
Imports System.IO

' En tiempo de ejecución, Global.asax se analiza y se compila en una clase de .NET Framework generada dinámicamente que se deriva de la clase base HttpApplication. 

Public Class Contar
    Inherits System.Web.HttpApplication

    Public Function Visitas() As Int16
        ' HttpContext.Current obtiene el objeto HttpContext que encapsula toda la información específica de HTTP acerca de la actual solicitud. 

        contador = HttpContext.Current.Server.MapPath("~/") & "\App_Data\contador.txt"

        Dim archivo As FileInfo = New FileInfo(contador)

        If (archivo.Exists) Then
            Dim leer As StreamReader = File.OpenText(contador)
            v = Int16.Parse(leer.ReadLine())
            v += 1
            leer.Close()
        Else
            v = 1
        End If

        Dim escribir As StreamWriter = File.CreateText(contador)
        escribir.WriteLine(v.ToString())
        escribir.Close()

        Return v
    End Function

End Class
