Imports System.Data.Common
Imports AccountManager.Tools

Public Class AuthService
    Private ReadOnly _dbConnection As DbConnection

    Public Sub New(dbConnection As DbConnection)
        _dbConnection = dbConnection
    End Sub

    Public Function Register(user As User) As Result
        Using _dbConnection
            Try
                _dbConnection.ExecuteNonQuery("TSP_Register", True, New With {Key .LastName = user.LastName, .FirstName = user.FirstName, .Email = user.Email, .Passwd = user.Passwd})
                Return Result.Success()
            Catch ex As Exception
                Return Result.Failure(ex.Message)
            End Try
        End Using
    End Function

    Public Function Login(email As String, passwd As String) As User
        Using _dbConnection
            Return _dbConnection.ExecuteReader("TSP_Authorize", Function(dr) dr.ToUser(), True, New With {Key .Email = email, .Passwd = passwd}).SingleOrDefault()
        End Using
    End Function
End Class
