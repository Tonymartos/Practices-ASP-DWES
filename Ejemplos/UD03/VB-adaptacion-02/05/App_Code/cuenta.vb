'''
''' Clase base (abstracta).
'''
Public MustInherit Class Cuenta

#Region "Campos"
    Private cNumero As String
    Private cApertura As Date
    Protected cSaldo As Decimal
#End Region

#Region "Propiedades implementadas automáticamente"
    Public Property estado() As Boolean = True
#End Region

#Region "Propiedades"
    Public ReadOnly Property numero() As String
        Get
            Return cNumero
        End Get
    End Property

    Public ReadOnly Property apertura() As Date
        Get
            Return cApertura
        End Get
    End Property

    Public ReadOnly Property saldo() As Decimal
        Get
            Return cSaldo
        End Get
    End Property
#End Region

#Region "Métodos"
    Public Sub Ingreso(ByVal cantidad As Decimal)
        If Not estado Then
            Throw New Exception("Error: Cuenta bloqueada")
        End If

        If Not (IsNumeric(cantidad) And cantidad > 0) Then
            Throw New Exception("Error: No es posible realizar la operación")
        End If
        cSaldo += Math.Round(cantidad, 2)
    End Sub

    ''' 
    ''' MustOverride (abstract). 
    ''' Un método que se debe reemplazar en la clase derivada y que solo se define en la clase base sin ningún código ejecutable. Los métodos abstractos son virtuales por defecto y solo se pueden declarar en clases abstractas.
    '''
    Public MustOverride Sub Reintegro(ByVal cantidad As Decimal)

    Public Sub Traspaso(ByVal cantidad As Decimal, ByRef cuenta As Cuenta)
        Reintegro(cantidad)
        cuenta.Ingreso(cantidad)
    End Sub
#End Region

#Region "Métodos privados"
    Protected Sub Init(ByVal n As String, ByVal s As Decimal)
        If Not Regex.IsMatch(n, "^\d{10}$") Or s < 0 Then
            Throw New Exception("Error: No es posible crear la cuenta")
        End If
        cNumero = n
        cApertura = Date.Now.Date
        cSaldo = Math.Round(s, 2)
    End Sub
#End Region

End Class
