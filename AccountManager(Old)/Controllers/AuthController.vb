Imports AccountManager.Models
Imports Microsoft.Extensions.DependencyInjection

Namespace Controllers
    Public Class AuthController
        Inherits BaseController

        Private ReadOnly _authService As AuthService

        Public Sub New()
            _authService = ServiceProvider.GetService(Of AuthService)()
        End Sub

        ' GET: Auth
        Function Index() As ActionResult
            Return RedirectToAction("Index", "Home")
        End Function

        <HttpPost>
        Public Function Login(form As LoginForm) As ActionResult
            TempData("Error") = "Bad Email or Password..."
            Return RedirectToAction("Index", "Home")
        End Function

        <HttpPost>
        Public Function Register(form As RegisterForm) As ActionResult
            Return RedirectToAction("Index", "Home")
        End Function
    End Class
End Namespace