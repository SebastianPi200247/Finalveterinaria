Public Class Logicamascota
    Public Sub altamascota(mascota As Mascotas)
        Dim persistencia As New PersistenciaMascota
        Return PersistenciaMascota.altamascota(mascota)
    End Sub
    Public Function BuscarMascota(ci As Integer) As Mascotas
        Dim persistencia As New PersistenciaMascota
        Return PersistenciaMascota.BuscarMascota(ci)
    End Function
    Public Function ModificarMascotas(ci As Integer) As Mascotas
        Dim persistencia As New PersistenciaMascota
        Return PersistenciaMascota.ModificarMascotas(mascota)
    End Function
End Class
