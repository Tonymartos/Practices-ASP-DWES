Public Class Vector

    ' Devuelve la posición de la primera aparición del valor buscado
    Public Shared Function indiceOf(ByVal v As Object(), ByVal o As Object) As Int64
        Dim a = v.GetLength(0)
        Dim i As Int64
        For i = 0 To a - 1
            If Object.Equals(v(i), o) Then
                Exit For
            End If
        Next
        Return IIf(i = a, -1, i)
    End Function

    ' Unión completa de dos arrays
    Public Shared Function unionAll(ByVal u As Object(), ByVal v As Object()) As Object()
        Dim a = u.GetLength(0)
        Dim b = v.GetLength(0)
        Dim r(a + b - 1) As Object
        Dim i As Int64
        For i = 0 To a - 1
            r(i) = u(i)
        Next
        ' Se continúa por el valor de i del bucle anterior
        For Each item As Object In v
            r(i) = item
            i += 1
        Next
        Return r
    End Function

    ' Unión de dos arrays eliminando duplicados
    Public Shared Function union(ByVal u As Object(), ByVal v As Object()) As Object()
        Dim r(u.GetLength(0) + v.GetLength(0) - 1) As Object
        Dim i As Int64 = 0
        For Each item As Object In u
            If indiceOf(r, item) = -1 Then
                r(i) = item
                i += 1
            End If
        Next
        For Each item As Object In v
            If indiceOf(r, item) = -1 Then
                r(i) = item
                i += 1
            End If
        Next
        ' Se eliminan los posibles elementos vacíos del final
        ReDim Preserve r(i - 1)
        Return r
    End Function

End Class

