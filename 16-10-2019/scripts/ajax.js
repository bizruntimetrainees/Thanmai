$(document).ready(function () {
			
    $('#ajaxBtn').click(function(){
       $.ajax('getdata.txt',   // 
       {            
           success: function (data, status, xhr) {    
                   $('p').append(data);
           }
       });
    });

   });