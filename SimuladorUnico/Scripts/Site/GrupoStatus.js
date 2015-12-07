

function Adicionar() {
    $('#div-detalhe-principal-2').show();

    $.ajax({
        type: "GET",
        url: "GrupoStatus/_Criar",
        ascync: true,
        success: function (data) {
            $('#divAdicionarGrupoStatus').show();
            $('#divAdicionarGrupoStatus').html(data);

        },
        error: function (xhr, error) {
            alert("Erro ao tentar criar o registro");
        },
        complete: function () {
            $('#div-detalhe-principal-2').hide();
        }
    });
}

function EditarGrupoStatus(id) {
    $('#div-detalhe-principal-2').show();

    $.ajax({
        type: "GET",
        url: "GrupoStatus/_Editar/" + id,
        ascync: true,
        success: function (data) {
            $('#divAdicionarGrupoStatus').show();
            $('#divAdicionarGrupoStatus').html(data);

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

function RemoverGrupoStatus(id) {
    $('#div-detalhe-principal-2').show();

    $.ajax({
        type: "GET",
        url: "GrupoStatus/Excluir/" + id,
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

function SalvarGrupoStatus() {
    $('#div-detalhe-principal-2').show();

    var obj = { NmGrupoStatus: $('#NmGrupoStatus').val(), DvAtivo: $('#DvAtivo').is(':checked'), IdGrupoStatus : $('#IdGrupoStatus').val() };

    console.log(obj);

    $.ajax({
        type: "POST",
        url: "GrupoStatus/Salvar",
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


