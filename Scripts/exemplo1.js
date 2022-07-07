function inicializar() {
    bloquear_data(true);
}

function bloquear_botao(acao) {
    var botao = $('.btnPesquisar')[0];

    botao.disabled = acao;
}

function bloquear_data(acao) {
    var data = $('.txtData')[0];

    data.disabled = acao;
}

function changeDropdown(sender) {
    var produtoCategoriaSelecionado = sender.options[sender.selectedIndex].value;
    var controlID = sender.id.replace("ddlProdutoCategoria", "ddlProdutoSubCategoria");
    var produtoSubCategoria = $('#' + controlID)[0];

    if (produtoCategoriaSelecionado.length <= 0) {
        produtoSubCategoria.options.selectedIndex = 0;

        $('#' + controlID).attr('disabled', true);
    }
    else {
        $('#' + controlID).attr('disabled', false);

        switch (produtoCategoriaSelecionado) {
            case '201':
                produtoSubCategoria.options.selectedIndex = 1;
                break;
            case '202':
                produtoSubCategoria.options.selectedIndex = 2;
                break;
            case '203':
                produtoSubCategoria.options.selectedIndex = 3;
                break;
        }
    }
}

function ddlCliente_Change(sender) {
    var clienteSelecionado = sender.options[sender.selectedIndex].text;

    console.log('ddlCliente_Change - Você selecionou o', clienteSelecionado);

    if (sender.selectedIndex <= 0) {
        bloquear_data(true);
        bloquear_botao(true);
        esconder_Produtos();
    }
    else {
        bloquear_data(false);
        bloquear_botao(false);
    }
}

function esconder_Produtos() {
    var divProdutos = $('#MainContent_divProdutos');

    divProdutos.hide();
}

function txtData_Change(sender) {
    console.log('txtData_Change - Você alterou a data para', sender.value);
}
