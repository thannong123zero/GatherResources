// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function GetFromAjax(url) {
    $.ajax({
        type: 'GET',
        url: url,
        success: function (res) {
            $('#form-popup-modal .modal-body').empty();
            $('#form-popup-modal .modal-body').append(res.html);
            $('#form-popup-modal .modal-title').html(res.title);
            $('#form-popup-modal').modal('show');
        }
    })
}

function SubmitProduction(form) {
    $.ajax({
        type: 'POST',
        url: form.action,
        data: new FormData(form),
        contentType: false,
        processData: false,
        success: function (res) {
            if (res.isValid) {
                $('#productionList').empty();
                $('#productionList').append(res.html)
                $('#form-popup-modal').modal('hide');
            }
            else {
                $('#form-popup-modal .modal-body').empty();
                $('#form-popup-modal .modal-body').append(res.html);
            }
        },
        error: function (err) {
            console.log(err)
        }
    })
    return false;
}

function OpenPopupDelete(id) {
    $('#productionID').val(id);
    $('#DeleteProduction').modal('show');
}

function DeleteProduction(url) {
    let id = $('#productionID').val();
    if (id) {
        $.ajax({
            type: 'GET',
            url: url,
            data: { id },
            success: function (res) {
                if (res.isValid) {
                    $('#productionList').empty();
                    $('#productionList').append(res.html)
                    $('#DeleteProduction').modal('hide');
                }
            }
    });
    } else {
        $('#DeleteProduction').modal('hide')
    }
}