$(document).ready(function () {
			
    $('#ajaxBtn').click(function(){
       
       $.post('postdata.txt',   // url
          { myData: 'This is my data.' }, // data to be submit
          function(data, status, jqXHR) {// success callback
                   $('p').append('status: ' + status + ', data: ' + data);
           }).done(function() { alert('Request done!'); })
             .fail(function(jqxhr, settings, ex) { alert('failed, ' + ex); });


       });
});