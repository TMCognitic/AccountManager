

$(function () {
    let accountView = $('#AccountView');

    if (accountView != undefined) {
        $.ajax({
            url: 'account/',
            method: 'get',
            dataType: 'html',
            success: function (data) {
                $('#AccountView').html(data);
            },
            error: function (e) {
                console.log(e)
            }
        });
    }
});

function onAccountChanged() {

}

function login() {
    let email = $('#LoginEmail').val();
    let passwd = $('#LoginPasswd').val();

    if (email != undefined && passwd != undefined) {
        let data = {
            'email': email,
            'passwd': passwd
        };
        let json = JSON.stringify(data);

        $.ajax({
            url: 'auth/login',
            method: 'post',
            dataType: 'html',
            data: json,
            headers: { 'content-type': 'application/json' },
            statusCode: {
                200: function (data) {
                    $('#FormLogin').html(data);
                },
                204: function () {
                    document.location = "/";
                }
            },
            error: function (e) {
                console.log(e)
            }
        });
    }
}

function register() {
    let lastName = $('#RegisterLastName').val();
    let firstName = $('#RegisterFirstName').val();
    let email = $('#RegisterEmail').val();
    let passwd = $('#RegisterPasswd').val();
    let confirm = $('#RegisterConfirm').val();

    let data = {
        'lastName': lastName,
        'firstName': firstName,
        'email': email,
        'passwd': passwd,
        'confirm': confirm
    };
    let json = JSON.stringify(data);

    $.ajax({
        url: 'auth/register',
        method: 'post',
        dataType: 'html',
        data: json,
        headers: { 'content-type': 'application/json' },
        statusCode: {
            200: function (data) {
                $('#FormRegister').html(data);
            },
            204: function () {
                $('#RegisterLastName').val(null);
                $('#RegisterFirstName').val(null);
                $('#RegisterEmail').val(null);
                $('#RegisterPasswd').val(null);
                $('#RegisterConfirm').val(null);
                $('#RegisterResult').html('<p class="text-success">Votre enregistrement est effectué</p>')
            }
        },
        error: function (e) {
            console.log(e)
        }
    });
}