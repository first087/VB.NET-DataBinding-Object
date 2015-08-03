Public Class Employee

    Private _name As String
    Private _age As Byte
    Private _gender As GenderEnum

    Public Enum GenderEnum As Byte
        Unknown
        Male
        Female
    End Enum

    Public Sub New(ByVal name As String, ByVal age As Byte, ByVal gender As GenderEnum)
        _name = name
        _age = age
        _gender = gender
    End Sub

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property Age() As Byte
        Get
            Return _age
        End Get
        Set(ByVal value As Byte)
            _age = value
        End Set
    End Property

    Public Property Gender() As GenderEnum
        Get
            Return _gender
        End Get
        Set(ByVal value As GenderEnum)
            _gender = value
        End Set
    End Property
End Class
