Imports AccountManager.Models

Public Class SessionManager

    Public Shared ReadOnly Property IsValid()
        Get
            Return HttpContext.Current.Session.Keys.OfType(Of String)().Contains(NameOf(User))
        End Get
    End Property

    Public Shared Property User() As User
        Get
            Return CType(HttpContext.Current.Session(NameOf(User)), User)
        End Get
        Set(value As User)
            If value Is Nothing Then
                HttpContext.Current.Session.Remove(NameOf(User))
                Return
            End If

            HttpContext.Current.Session(NameOf(User)) = value
        End Set
    End Property
End Class
