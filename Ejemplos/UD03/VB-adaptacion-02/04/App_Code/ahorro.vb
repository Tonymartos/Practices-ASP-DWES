
Public Class Ahorro : Inherits Cuenta

#Region "Campos"
    Private cInteres As Decimal
#End Region

#Region "Constructor"
    Public Sub New(ByVal numero As String, Optional saldoInicial As Decimal = 0, Optional ByVal interes As Decimal = 0)
        If Not (IsNumeric(interes) And interes >= 0) Then
            Throw New Exception("Error: El interés aplicable a la cuenta no es válido")
        End If
        Init(numero, saldoInicial)
        cInteres = interes
    End Sub
#End Region

#Region "Propiedades"
    Public Property interes() As Decimal
        Get
            Return cInteres
        End Get
        Set(ByVal valor As Decimal)
            If Not (IsNumeric(valor) And valor >= 0) Then
                Throw New Exception("Error: El interés aplicable a la cuenta no es válido")
            End If
            cInteres = valor
        End Set
    End Property
#End Region

#Region "Métodos"
    Public Overrides Sub Reintegro(ByVal cantidad As Decimal)
        If Not estado Then
            Throw New Exception("Error: Cuenta bloqueada")
        End If

        If Not (IsNumeric(cantidad) And cantidad > 0) Then
            Throw New Exception("Error: No es posible realizar la operación")
        End If

        If cantidad > cSaldo Then
            Throw New Exception("Error: Saldo insuficiente")
        End If

        cSaldo -= Math.Round(cantidad, 2)
    End Sub

    Public Shadows Function ToString() As String
        Return "Saldo C. Ahorro(" & numero & "):" & saldo.ToString("C2")
    End Function
#End Region

End Class
