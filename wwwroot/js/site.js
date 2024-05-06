// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function ()
{
    $('#cidades').DataTable({
        language:
        {
            "decimal": "",
            "emptyTable": "Não há nenhum dado nesta tabela",
            "info": "Mostrando _START_ registro de _END_ em um total de _TOTAL_ entradas",
            "infoEmpty": "Mostrando 0 até 0 de 0 entradas",
            "infoFiltered": "(filtered from _MAX_ total entries)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ entradas",
            "loadingRecords": "Carregando...",
            "processing": "",
            "search": "Procurar:",
            "zeroRecords": "Nenhum registro correspondente encontrado",
            "paginate": {
                "first": "Primeiro",
                "last": "Último",
                "next": "Próximo",
                "previous": "Anterior"
            },
            "aria": {
                "sortAscending": "Ordenar por esta coluna",
                "sortDescending": "Ordem inversa nesta coluna"
            }
        }
    });

    $('#clientes').DataTable({
        language:
        {
            "decimal": "",
            "emptyTable": "Não há nenhum dado nesta tabela",
            "info": "Mostrando _START_ registro de _END_ em um total de _TOTAL_ entradas",
            "infoEmpty": "Mostrando 0 até 0 de 0 entradas",
            "infoFiltered": "(filtered from _MAX_ total entries)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ entradas",
            "loadingRecords": "Carregando...",
            "processing": "",
            "search": "Procurar:",
            "zeroRecords": "Nenhum registro correspondente encontrado",
            "paginate": {
                "first": "Primeiro",
                "last": "Último",
                "next": "Próximo",
                "previous": "Anterior"
            },
            "aria": {
                "sortAscending": "Ordenar por esta coluna",
                "sortDescending": "Ordem inversa nesta coluna"
            }
        }
    });




    setTimeout(function ()
    {
        $(".alert").fadeOut("slow", function ()
        {
            $(this).alert('close');
        })
    }, 4000)

});
