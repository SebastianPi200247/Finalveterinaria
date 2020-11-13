Public Class Mascotas
    Private _nombre As String
    Private _dueno As personas
    Private _añonacimiento As Integer
    Private _id As Integer



    Public Property Dueno As personas
        Get
            Return _dueno
        End Get
        Set(value As personas)
            _dueno = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property Añonacimiento As Integer
        Get
            Return _añonacimiento
        End Get
        Set(value As Integer)
            _añonacimiento = value
        End Set
    End Property

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Sub Mascotas()

    End Sub

    Public Sub Mascotas(nombre_ As String, dueno_ As personas, añonacimiento_ As Integer, id_ As Integer)
        Nombre = nombre_
        Dueno = dueno_
        Añonacimiento = añonacimiento_
        id = id_
    End Sub

End Class
