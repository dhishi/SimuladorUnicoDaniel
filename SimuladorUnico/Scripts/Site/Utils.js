function serializeFormJSON (form) {

    var o = {};
    var objForm = $('#' + form);
    var a = objForm.serializeArray();
    $.each(a, function () {
        if (o[this.name]) {
            if (!o[this.name].push) {
                o[this.name] = [o[this.name]];
            }
            o[this.name].push(this.value || '');
        } else {
            o[this.name] = this.value || '';
        }
    });
    return o;
};

function FecharDivDetalhe()
{
    $('#div-detalhe-principal').hide();
}

function AbrirDivListagem(view) {
    $('#div-detalhe-principal-2').show();

    $.ajax({
        type: "GET",
        url: view + "/_Lista",
        ascync: true,
        success: function (data) {
            $('#div-detalhe-principal').show();

            $('#detalhe-div').html(data);

        },
        error: function (xhr, error) {
            alert("Erro ao listar " + view);
        },
        complete: function () {
            $('#div-detalhe-principal-2').hide();
        }
    });
}