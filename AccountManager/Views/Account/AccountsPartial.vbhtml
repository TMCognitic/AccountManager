@ModelType IEnumerable(Of AccountManager.DisplayAccount)

@Html.ActionLink("Create Account", "Create", "Account")

<div id="AccountsContent" style="@(If(Model.Count() > 0, "display:block", "display:none"))">
    <select id="AccountList" name="AccountList" onchange="onAccountChanged" >
        <option value="@(New Guid())">Sélectionner un compte...</option>
        @For Each item In Model
            @<option value="@item.Id">@item.AccountNumber</Option>
        Next
    </select>

    <div id="AccountDetail">
    </div>
</div>