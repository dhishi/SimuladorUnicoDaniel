
function AdicionarStatus() {
    $('#div-detalhe-principal-2').show();

    $.ajax({
        type: "GET",
        url: "Status/_Criar",
        ascync: true,
        success: function (data) {
            $('#divAdicionarStatus').show();
            $('#divAdicionarStatus').html(data);

        },
        error: function (xhr, error) {
            alert("Erro ao tentar criar o registro");
        },
        complete: function () {
            $('#div-detalhe-principal-2').hide();
        }
    });
}

function EditarStatus(id) {
    $('#div-detalhe-principal-2').show();

    $.ajax({
        type: "GET",
        url: "Status/_Editar/" + id,
        ascync: true,
        success: function (data) {
            $('#divAdicionarStatus').show();
            $('#divAdicionarStatus').html(data);

        },
        error: function (xhr, error) {
            alert("Erro ao editar o registro");
            $('#div-detalhe-principal-2').hide();
        },
        complete: function () {
            $('#div-detalhe-principal-2').hide();
        }
    });
}

function RemoverStatus(id) {
    $('#div-detalhe-principal-2').show();

    $.ajax({
        type: "GET",
        url: "Status/Excluir/" + id,
        ascync: true,
        success: function (data) {
            if (data != '') {
                $('#detalhe-div').html(data);
                alert('Grupo excluído com sucesso.');
            }

        },
        error: function (xhr, error) {
            alert("Erro ao tentar excluir o registro");
            $('#div-detalhe-principal-2').hide();
        },
        complete: function () {
            $('#div-detalhe-principal-2').hide();
        }
    });
}

function SalvarStatus() {
    $('#div-detalhe-principal-2').show();

    var obj = {
        NmStatus: $('#NmStatus').val()
        , DvAtivo: $('#DvAtivo').is(':checked')
        , IdGrupoStatus: $('#IdGrupoStatus').val()
        , IdStatusEx: $('#IdStatusEx').val()
        , IdStatus: $('#IdStatus').val()
    };

    console.log(obj);

    $.ajax({
        type: "POST",
        url: "Status/Salvar",
        contentType: 'application/json',
        data : JSON.stringify(obj),
        success: function (data) {
            if (data != '') {
                $('#div-detalhe-principal').show();
                $('#detalhe-div').html(data);
                alert('Registro salvo com sucesso.');
            }
            else
            {
                $('#detalhe-div').html('');
                $('#div-detalhe-principal').hide();
                $('#div-detalhe-principal-2').hide();
            }

        },
        error: function (xhr, error) {
            alert("Erro ao tentar criar um " + view);
        },
        complete: function () {
            $('#div-detalhe-principal-2').hide();
        }
    });
}


