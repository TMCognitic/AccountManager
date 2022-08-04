Imports System.Runtime.CompilerServices

Module DataRecordExtensions
    <Extension>
    Public Function ToUser(dataRecord As IDataRecord) As User
        Return New User() With {
            .Id = CType(dataRecord("Id"), Integer),
            .LastName = CType(dataRecord("LastName"), String),
            .FirstName = CType(dataRecord("FirstName"), String),
            .Email = CType(dataRecord("Email"), String)
        }
    End Function

    <Extension>
    Public Function ToAccount(dataRecord As IDataRecord) As Account
        Return New Account() With {
            .Id = CType(dataRecord("Id"), Guid),
            .Description = CType(dataRecord("Description"), String),
            .AccountNumber = CType(dataRecord("AccountNumber"), String)
        }
    End Function
End Module
