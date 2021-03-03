var dataTable;

$(document).ready(function () {
    cargarDatatable();
});

function cargarDatatable() {
    dataTable = $("#tbltipograncontribuyente").DataTable({
        "ajax": {
            "url": "/admin/TipoGranContribuyente/GetAll",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "tipoGranContribuyenteId", "width": "5%" },
            { "data": "nombreTipoGranContribuyente", "width": "10%" },

            {
                "data": "tipoGranContribuyenteId",
                "render": function (data) {
                    return `<div class="text-center">
                                <a href="/Admin/TipoGranContribuyente/Edit/${data}" class='btn btn-success text-white' style='cursor:pointer; width:100px;'>
                                    <i class='far fa-edit'></i> Editar
                                </a>
                                &nbsp;
                                <a onclick=Delete("/Admin/TipoGranContribuyente/Delete/${data}") class='btn btn-danger text-white' style='cursor:pointer; width:100px;'>
                                    <i class='far fa-trash-alt'></i> Borrar
                                </a>
                            </div>
                            `;
                }, "width": "30%"
            },
        ],
        "language": {
            "emptyTable": "No hay registros."
        },
        "width": "100%"
    });
}

function Delete(url) {
    swal({
        title: "Esta seguro de borrar?",
        text: "Este contenido no se puede recuperar!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Si, borrar!",
        closeOnconfirm: true
    }, function () {
        $.ajax({
            type: 'DELETE',
            url: url,
            success: function (data) {
                if (data.success) {
                    toastr.success(data.message);
                    dataTable.ajax.reload();
                }
                else {
                    toastr.error(data.message);
                }
            }
        });
    });
}

