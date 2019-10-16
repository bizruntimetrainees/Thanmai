
$(document).ready(function()
{
  $("button").click(function()
  {
    $("p.intro").hide();
  });
});

$(document).ready(function(){
    $("button").click(function(){
      $("ul li:first").hide();
    });
  });

  $(document).ready(function(){
    $("button").click(function(){
      $("ul li:first-child").hide();
    });
  });

  $(document).ready(function(){
    $("button").click(function(){
        $(":button").hide();
    });
});

$(document).ready(function()
{
    $("tr:even").css("background-color","yellow");
    $("tr:odd").css("background-color","grey");

});

