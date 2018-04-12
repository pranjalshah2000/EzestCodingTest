
function registerUser() {
    var user = {
        Username: $('#txtEmail').val(),
        Password: $('#txtPassword').val(),
        FirstName: $('#txtFirstName').val(),
        LastName: $('#txtLastName').val(),
        DateOfBirth: $('#txtDOB').val()
    };
    $.ajax({
        type: "POST",
        url: "http://localhost:51201/api/users",
        data: JSON.stringify(user),
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            window.location.href = '/Home/UserList';
        },
        error: function (err) {
            if (err != null && err.responseJSON != null)
                alert(err.responseJSON.Message);
            alert(err);
        }
    });
}

function getUserList()
{
    $.ajax({
        type: "GET",
        url: "http://localhost:51201/api/users",
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (users) {
            $.each(users, function (index, user) {
                var dobFullDate = new Date(user.DateOfBirth);
                var formattedDOB = dobFullDate.getDate() + "\\" + (dobFullDate.getMonth() + 1) + "\\" + dobFullDate.getFullYear();
                $('#tbodyUsers').append('<tr><td>' + user.Username + '</td><td>' + user.FirstName + '</td><td>' + user.LastName + '</td><td>' + formattedDOB + '</td></tr>');
            });
        },
        error: function (err) {
            if (err != null && err.responseJSON != null)
                alert(err.responseJSON.Message);
            alert(err);
        }
    });
}