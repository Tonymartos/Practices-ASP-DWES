Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Consultas
    Inherits System.Web.UI.Page

    Public Shared Function VehiculosCliente(ByVal n As String, ByVal ruta As String) As DataTable
        Dim conexion As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & ruta 
        Dim sentencia As String = "select matricula from polizas where nif=@nif"
        Dim miCnx As New OleDbConnection(conexion)
        Dim miCmd As New OleDbCommand(sentencia, miCnx)
        miCmd.Parameters.Add("@nif", OleDbType.Char, 9).Value = n
        Dim miDSet As New DataSet
        Dim Adt As New OleDbDataAdapter(miCmd)
        Adt.Fill(miDSet)
        Return miDSet.Tables(0)
    End Function

End Class
