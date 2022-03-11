$(document).ready(function () {
    $("#CPF").mask("000.000.000-00");
    $("#CNPJ").mask("00.000.000/0000-00");
    $("#InscricaoEstadual").mask("000.000.000.000");
    $("#Celular").mask("(00) 0 0000-0000");
    $("#CEP").mask("00000-000");
    
});

 function pessoaTipoChange () {
     var tipoPessoaId = $("#TipoPessoa").val();
     if (tipoPessoaId == 1) {
         $("#DivNome").css("display","block")
     }
     else {
         $("#DivNome").css("display", "none")
     }

     var tipoPessoaId = $("#TipoPessoa").val();
     if (tipoPessoaId == 1) {
         $("#DivCPF").css("display", "block")
     }
     else {
         $("#DivCPF").css("display", "none")
     }

     var tipoPessoaId = $("#TipoPessoa").val();
     if (tipoPessoaId == 1) {
         $("#DivRazaoSocial").css("display", "none")
     }
     else {
         $("#DivRazaoSocial").css("display", "block")
     }

     var tipoPessoaId = $("#TipoPessoa").val();
     if (tipoPessoaId == 1) {
         $("#DivNomeFantasia").css("display", "none")
     }
     else {
         $("#DivNomeFantasia").css("display", "block")
     }

     var tipoPessoaId = $("#TipoPessoa").val();
     if (tipoPessoaId == 1) {
         $("#DivCNPJ").css("display", "none")
     }
     else {
         $("#DivCNPJ").css("display", "block")
     }

     var tipoPessoaId = $("#TipoPessoa").val();
     if (tipoPessoaId == 1) {
         $("#DivRazaoSocial").css("display", "none")
     }
     else {
         $("#DivRazaoSocial").css("display", "block")
     }

     var tipoPessoaId = $("#TipoPessoa").val();
     if (tipoPessoaId == 1) {
         $("#DivDataDeNascimento").css("display", "block")
     }
     else {
         $("#DivDataDeNascimento").css("display", "none")
     }

     var tipoPessoaId = $("#TipoPessoa").val();
     if (tipoPessoaId == 1) {
         $("#DivAtuacaoId").css("display", "none")
     }
     else {
         $("#DivAtuacaoId").css("display", "block")
     }

     var tipoPessoaId = $("#TipoPessoa").val();
     if (tipoPessoaId == 1) {
         $("#DivFotoPerfil").css("display", "block")
     }
     else {
         $("#DivFotoPerfil").css("display", "none")
     }
     
};