Public Class Conexion
    Public Function AbrirConexion() As Npgsql.NpgsqlConnection
        Dim conexion As Npgsql.NpgsqlConnection
        Try
            conexion = New Npgsql.NpgsqlConnection
            Dim cadenadeconexion As String
            cadenadeconexion = "Server=127.0.0.1;Port=1433;User Id='postgres';Password='SA3652pi';Database=Veterinaria"
            conexion.ConnectionString = cadenadeconexion
            conexion.Open()
        Catch ex As Exception
            conexion.Close()
            Throw ex

        End Try

        Return conexion

    End Function
End Class
