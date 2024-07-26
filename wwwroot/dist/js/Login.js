$(document).ready(function () {
    $('#frm').submit(function (e) {
        e.preventDefault();

        var url = actionUrl;        
        var parametros = $(this).serialize();

        $.post(url, parametros, function (data) {
            if (data === "1") {
                document.location.href = 'Index'
            } else {
                alert(data);
            }
        });
    });
});
