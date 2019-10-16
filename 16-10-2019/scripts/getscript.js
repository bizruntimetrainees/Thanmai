
$(document).ready(function () {
    $('#ajaxBtn').click(function(){
    $.getScript('http://127.0.0.1:5500/scripts/script1.js', function(script,status,jqxhr){
        alert(status);
        alert(script);
});
});
});