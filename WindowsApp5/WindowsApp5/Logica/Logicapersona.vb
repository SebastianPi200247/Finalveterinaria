Public Class LogicaPersona
    Public Sub altapersona(personita As personas)
        Dim persistencia As New PersistenciaPersona
        Return persistencia.altapersona(personita)
    End Sub
    Public Function buscarPersona(ci As Integer) As personas
        Dim persistencia As New PersistenciaPersona
        Return persistencia.Buscarpersona(ci)
    End Function
    Public Function ModificarPersonas(ci As Integer) As personas
        Dim persistencia As New PersistenciaPersona
        Return persistencia.ModificarPersonas(ci)
    End Function
End Class
