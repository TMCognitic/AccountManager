Imports System.Data.Common
Imports AccountManager.Tools

Public Class AccountService
    Private ReadOnly _dbConnection As DbConnection

    Public Sub New(dbConnection As DbConnection)
        _dbConnection = dbConnection
    End Sub

    Public Function GetAll(userId As Integer) As IEnumerable(Of Account)
        Using _dbConnection
            Return _dbConnection.ExecuteReader("Select Id, [Description], AccountNumber, UserId From Account Where UserId = @UserId",
                                               Function(dr) dr.ToAccount(),
                                               immediately:=True,
                                               parameters:=New With {Key .UserId = userId})
        End Using
    End Function
End Class
