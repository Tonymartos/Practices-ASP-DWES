Public Class Lista
    Inherits ArrayList

    Public Overloads Shared Operator +(ByVal x As Lista, ByVal y As Lista) As Lista
        x.AddRange(y)
        Return x
    End Operator

    Public Overloads Shared Operator +(ByVal x As Lista, ByVal a As Object) As Lista
        x.Add(a)
        Return x
    End Operator

    Public Overloads Shared Operator -(ByVal x As Lista, ByVal y As Lista) As Lista
        For Each i In y
            x.Remove(i)
        Next
        Return x
    End Operator

    Public Overloads Shared Operator -(ByVal x As Lista, ByVal a As Object) As Lista
        x.Remove(a)
        Return x
    End Operator

    Public Overloads Shared Operator -(ByVal x As Lista) As Lista
        x.Reverse()
        Return x
    End Operator

    Public Shared Operator <>(ByVal x As Lista, ByVal y As Lista) As Boolean
        Dim ok As Boolean = False
        If x.Count <> y.Count Then
            ok = True
        Else
            For i = 0 To x.Count - 1
                If Not x(i).Equals(y(i)) Then ' Ojo. Se comparan objetos
                    ok = True
                    Exit For
                End If
            Next
        End If
        Return ok
    End Operator

    Public Shared Operator =(ByVal x As Lista, ByVal y As Lista) As Boolean
        Return Not x <> y
    End Operator

End Class