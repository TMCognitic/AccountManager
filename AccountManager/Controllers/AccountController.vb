Imports AccountManager.Models
Imports Microsoft.Extensions.DependencyInjection

Namespace Controllers
    <AuthRequired>
    Public Class AccountController
        Inherits BaseController
        Private ReadOnly _accountService As AccountService

        Public Sub New()
            _accountService = ServiceProvider.GetService(Of AccountService)()
        End Sub

        ' GET: Account
        Function Index() As ActionResult
            Dim accounts As IEnumerable(Of Account) = _accountService.GetAll(SessionManager.User.Id)
            Return PartialView("AccountsPartial", accounts.Select(Function(a) a.ToDisplayAccount()))
        End Function

        Function Create() As ActionResult
            Return View()
        End Function

        Function Create(form As CreateAccountForm) As ActionResult
            Return View()
        End Function
    End Class
End Namespace