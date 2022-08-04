@ModelType AccountManager.LoginForm

@Html.AntiForgeryToken()

<div class="form-horizontal">
    <h4>Login</h4>
    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    <div Class="form-group">
        @Html.LabelFor(Function(model) model.Email, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Email, New With {.htmlAttributes = New With {.class = "form-control", .id = "LoginEmail"}})
            @Html.ValidationMessageFor(Function(model) model.Email, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Passwd, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Passwd, New With {.htmlAttributes = New With {.class = "form-control", .id = "LoginPasswd"}})
            @Html.ValidationMessageFor(Function(model) model.Passwd, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <button onclick="login()" class="btn btn-default">Login</button>
        </div>
    </div>
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
