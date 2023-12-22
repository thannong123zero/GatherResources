// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function SubmitForm(form) {
    $.ajax({
        type: 'POST',
        url: form.action,
        data: new FormData(form),
        contentType: false,
        processData: false,
        success: function (res) {
            if (res.isValid) {
                var myModal = document.getElementById('btnModel');
                $('#popupMessage').text(res.message);
                myModal.click();
                setTimeout(() => {
                    window.location.href = '/';

                }, 15000);
            }
            else if (res.message) {
                var myModal = document.getElementById('btnModel');
                $('#popupMessage').text(res.message);
                myModal.click();
                setTimeout(() => {
                    window.location.href = '/';

                }, 15000);
            }
            else if (res.messageNotification) {
                $('#formSV').empty();
                $('#formSV').append(res.html);
                var myModalNotification = document.getElementById('btnModelNotification');
                $('#popupNotifiacation').text(res.messageNotification);
                myModalNotification.click();

            }
        },
        error: function (err) {
            console.log(err)
        }
    })
    return false;
}

//var myModal = new bootstrap.Modal(document.getElementById('exampleModal'), {
//    keyboard: false
//})
//myModal.show();