Imports System.Runtime.CompilerServices
Imports AccountManager.Models

Module AccountMappers
    <Extension>
    Function ToDisplayAccount(account As Account) As DisplayAccount
        Return New DisplayAccount() With {.Id = account.Id, .Description = account.Description, .AccountNumber = account.AccountNumber}
    End Function
End Module
