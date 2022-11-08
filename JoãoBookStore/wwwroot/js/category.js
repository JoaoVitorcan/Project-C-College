var dataTable;

$(document).ready(function () {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Category/GetAll"
        },
        "colums": [
            { "data": "name", "width": "60%" },
            {
                "data": "id",
                "reder": function (data) {
                    return
                    <div class="text-center">
                        <a href="/Admin/Category/Upsert/id" class="btn btn-success text-white" style="cursor:pointer">
                            <i class="fas fa-edit"></i>&nbsp;
                         </a>
                        <a class="btn btn-danger text-white" style="cursor:pointer" >
                            <i class="fas fa-trash-alt"></i>&nbsp;
                         </a>
                    </div>
                        ;
                }
            }
        ]
    });
});