

$(document).ready(function () {
    $('#ajaxBtn').click(function(){
       $.ajax({
           url: 'submitdata',
           type: 'POST',  // http method
           data: { myData: 'This is my data.' },  // data to submit
           success: function (data, status, xhr) {
               $('p').append('status: ' + status + ', data: ' + data);
           },
           error: function (jqXhr, textStatus, errorMessage) {
                   $('p').append('Error: ' + errorMessage);
               }
       });
   });
});