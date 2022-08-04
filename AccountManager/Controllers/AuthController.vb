Imports AccountManager.Models
Imports AccountManager.Tools
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
            If Not ModelState.IsValid Then
                Return PartialView("LoginPartial", form)
            End If

            Dim user As User = _authService.Login(form.Email, form.Passwd)
            If user Is Nothing Then
                ModelState.AddModelError("", "Bad Email or Password...")
                Return PartialView("LoginPartial", form)
            End If

            SessionManager.User = user
            Return NoContent() 'Voir BaseController
        End Function

        <HttpPost>
        Public Function Register(form As RegisterForm) As ActionResult
            If Not ModelState.IsValid Then
                Return PartialView("RegisterPartial", form)
            End If

            Dim user As New User() With {.LastName = form.LastName, .FirstName = form.FirstName, .Email = form.Email, .Passwd = form.Passwd}
            Dim result As Result = _authService.Register(user)

            If result.IsFailure Then
                ModelState.AddModelError("", "Something wrong call the administrator...")
                Return PartialView("RegisterPartial", form)
            End If

            Return NoContent() 'Voir BaseController
        End Function
    End Class
End Namespace