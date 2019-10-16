$(document).ready(function () {
    $('#ajaxBtn').click(function(){
    $.get('getdata.txt',  // url
    function (data, textStatus, jqXHR) {  // success callback
        alert('status: ' + textStatus + ', data:' + data);
  });
});
});