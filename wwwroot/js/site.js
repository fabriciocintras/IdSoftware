$(function () {
    $('[data-toggle="tooltip"]').tooltip()
  });

                          
  $('#formContato').on('submit', function(e){
    $('#modalConfirma').modal('show');
    e.preventDefault();
  });