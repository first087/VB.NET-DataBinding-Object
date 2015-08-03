Imports System.ComponentModel


Public Class Employee
    Implements INotifyPropertyChanged


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
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Name"))
        End Set
    End Property

    Public Property Age() As Byte
        Get
            Return _age
        End Get
        Set(ByVal value As Byte)
            _age = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Age"))
        End Set
    End Property

    Public Property Gender() As GenderEnum
        Get
            Return _gender
        End Get
        Set(ByVal value As GenderEnum)
            _gender = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Gender"))
        End Set
    End Property

    Public Property GenderIsUnknown() As Boolean
        Get
            Return _gender = GenderEnum.Unknown
        End Get
        Set(value As Boolean)
            If value Then
                _gender = GenderEnum.Unknown
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Gender"))
            End If
        End Set
    End Property

    Public Property GenderIsMale() As Boolean
        Get
            Return _gender = GenderEnum.Male
        End Get
        Set(value As Boolean)
            If value Then
                _gender = GenderEnum.Male
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Gender"))
            End If
        End Set
    End Property

    Public Property GenderIsFemale() As Boolean
        Get
            Return _gender = GenderEnum.Female
        End Get
        Set(value As Boolean)
            If value Then
                _gender = GenderEnum.Female
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Gender"))
            End If
        End Set
    End Property

    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged
End Class
