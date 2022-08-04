Imports System.ComponentModel.DataAnnotations
Imports System.Data.Common
Imports AccountManager.Tools
Imports Microsoft.Extensions.DependencyInjection

<AttributeUsage(AttributeTargets.Property)>
Public Class EmailAlreadyExistsAttribute
    Inherits ValidationAttribute

    Public Overrides Function IsValid(value As Object) As Boolean
        If TypeOf (value) IsNot String Then
            ErrorMessage = "Cet attribut de validation ne peut-être utilisé que sur des propriété de type String"
            Return False
        End If

        Using dbConnection As DbConnection = ResourceProvider.Instance.ServiceProvider.GetService(Of DbConnection)()
            Dim count As Integer = dbConnection.ExecuteScalar("Select Count(*) From [User] Where Email = @Email;", parameters:=New With {Key .Email = value})

            If count > 0 Then
                ErrorMessage = "Vous vous êtes déjà enregistré"
                Return False
            End If

            Return True
        End Using
    End Function

End Class
