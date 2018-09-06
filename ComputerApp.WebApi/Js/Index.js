$(function () {
    GetMemories();
});

function GetMemories() {
    $.ajax({
        type: "GET",
        url: "/api/Memory/get",
        dataType: "json",
        success: function(data) {
            var trHTML = '';
            $.each(data, function (i, item) {
                trHTML += '<tr><td>' + item.MemoryId + '</td><td>' + item.ComputerName + '</td><td>' + item.Marcar + '</td><td>' + item.Tipo + '</td><td>' + item.Capacidad + ' GB</td></tr>';
            });
            $('#table').append(trHTML);
        },
        error: function(xhr, status, error) {
            var err = eval("(" + xhr.responseText + ")");
            alert(err.Message);
        }
    });
}