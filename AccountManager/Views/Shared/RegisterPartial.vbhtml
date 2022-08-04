@ModelType AccountManager.RegisterForm

    @Html.AntiForgeryToken()
    
<div class="form-horizontal">
    <h4>Register</h4>
    <hr />
    @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
    <div class="form-group">
        @Html.LabelFor(Function(model) model.LastName, htmlAttributes:= New With { .class = "control-label col-md-2" })
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.LastName, New With {.htmlAttributes = New With {.class = "form-control", .id = "RegisterLastName"}})
            @Html.ValidationMessageFor(Function(model) model.LastName, "", New With { .class = "text-danger" })
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.FirstName, htmlAttributes:= New With { .class = "control-label col-md-2" })
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.FirstName, New With {.htmlAttributes = New With {.class = "form-control", .id = "RegisterFirstName"}})
            @Html.ValidationMessageFor(Function(model) model.FirstName, "", New With { .class = "text-danger" })
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Email, htmlAttributes:= New With { .class = "control-label col-md-2" })
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Email, New With {.htmlAttributes = New With {.class = "form-control", .id = "RegisterEmail"}})
            @Html.ValidationMessageFor(Function(model) model.Email, "", New With { .class = "text-danger" })
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Passwd, htmlAttributes:= New With { .class = "control-label col-md-2" })
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Passwd, New With {.htmlAttributes = New With {.class = "form-control", .id = "RegisterPasswd"}})
            @Html.ValidationMessageFor(Function(model) model.Passwd, "", New With { .class = "text-danger" })
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.Confirm, htmlAttributes:= New With { .class = "control-label col-md-2" })
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.Confirm, New With {.htmlAttributes = New With {.class = "form-control", .id = "RegisterConfirm"}})
            @Html.ValidationMessageFor(Function(model) model.Confirm, "", New With { .class = "text-danger" })
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <button class="btn btn-default" onclick="register()">Register</button>
        </div>
    </div>

    <div id="RegisterResult">
    </div>
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
