<AttributeUsage(AttributeTargets.Method Or AttributeTargets.Class)>
Public Class AuthRequiredAttribute
    Inherits AuthorizeAttribute

    Public Overrides Sub OnAuthorization(filterContext As AuthorizationContext)
        If SessionManager.User Is Nothing Then
            filterContext.Result = New RedirectToRouteResult(New RouteValueDictionary(New With {Key .Action = "Index", .Controller = "Home"}))
        End If
    End Sub
End Class
