@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h2>Account Manager</h2>
</div>

@If Not SessionManager.IsValid Then
    @<div Class="row">
        <div id="FormLogin" Class="col-md-6">
            @Html.Partial("LoginPartial")
        </div>
        <div id="FormRegister" Class="col-md-6">
            @Html.Partial("RegisterPartial")
        </div>
    </div>
Else
    @<div Class="row" id="AccountView">
        
    </div>
End If
