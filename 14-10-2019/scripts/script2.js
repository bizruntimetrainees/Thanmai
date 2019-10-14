
$(document).ready(function(){
    $("#hide").click(function(){
      $("p").hide();
    });

    $("#show").click(function(){
      $("p").show();
    });

    $("#toggle").click(function()
        {
            $("p").toggle();
        }
    );
  });

  //fadein
  $(document).ready(function(){
    $("#fadein").click(function(){
      $("#div1").fadeIn();
      $("#div2").fadeIn("slow");
      $("#div3").fadeIn(3000);
    });
  });

  //fadeout
  $(document).ready(function(){
 $("button").click(function(){
    $("#div4").fadeOut();
    $("#div5").fadeOut("slow");
    $("#div6").fadeOut(3000);
  });
});