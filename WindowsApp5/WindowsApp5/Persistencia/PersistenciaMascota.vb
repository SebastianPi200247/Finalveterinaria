Public Class PersistenciaMascota
    Dim conexion As Npgsql.NpgsqlConnection
    Public Sub altamascota(mascota As Mascotas)
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion
            Dim cadenadecomando As String
            cadenadecomando = "insert into (Nombre,Dueno,Añonacimiento,id ) values(@Nombre,@Dueno,@Añonacimiento,@id);"

            cmd.Parameters.Add("@Nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = mascota.Nombre
            cmd.Parameters.Add("@Dueno", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = mascota.Dueno
            cmd.Parameters.Add("@Añonacimiento", NpgsqlTypes.NpgsqlDbType.Integer).Value = mascota.Añonacimiento
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = mascota.id

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Friend Shared Sub altamascota()
        Throw New NotImplementedException()
    End Sub

    Public Function BuscarMascota(id As Integer) As Mascotas
        Try
            Dim ClaseSln As New Conexion
            conexion = ClaseSln.AbrirConexion
            Dim cmd As Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim CadenaDeComandos = "Select * from persona where idmascota = @id "
            cmd.CommandText = CadenaDeComandos
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id
            Dim lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader


            If lector.HasRows Then
                lector.Read()
                Dim MascotasNueva As New Mascotas
                MascotasNueva.Añonacimiento = Convert.ToInt32(lector(0).ToString)
                MascotasNueva.Dueno = lector(1).ToString
                MascotasNueva.Nombre = lector(2).ToString
                MascotasNueva.id = lector(3).ToInt32(lector(0).ToString)
            End If
        Catch ex As Exception
        Finally
        End Try

    End Function
    Public Function ModificarMascotas(mascota As Integer) As Mascotas
        Try

        Catch ex As Exception

        Finally

        End Try

    End Function
End Class
