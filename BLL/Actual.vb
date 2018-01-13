Public Class Actual


    Private Shared Property _usuario As BE.UsuarioBE
    Public Shared Property usuario() As BE.UsuarioBE
        Get
            Return _usuario
        End Get
        Set(ByVal value As BE.UsuarioBE)
            _usuario = value
        End Set
    End Property
End Class
