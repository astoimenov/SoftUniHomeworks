function checkPasswordMatch() {
    var password = $("#regPass").val();
    var confirmPassword = $("#confirmPass").val();

    if (password != confirmPassword){
        $("#divCheckPasswordMatch").html("Passwords do not match.");
        document.getElementById("confirmPass").style.border = "1px solid red";
        document.getElementById("confirmPass").focus();
    }
    else
        $("#divCheckPasswordMatch").html("Passwords match.");
}

$(document).ready(function () {
   $("#confirmPass").keypress(checkPasswordMatch);
});
