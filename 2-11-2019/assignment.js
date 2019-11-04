$(document).ready(function()
{
    $("#btn1").fadeIn(function()
    {
        $(".tabcontent").hide(); 
        $(".tabcontent2").hide();     
         $(".tabcontent3").hide();
    });
})

$(document).ready(function()
{
    $("#btn1").click(function()
    {
        $(".tabcontent").show();
        $(".tabcontent2").hide();
        $(".tabcontent3").hide();
        $("#postbutton").hide();
        $("#putbutton").hide(); 
        $("#patchbutton").hide();
        $("#delbutton").hide();
    });
})

$(document).ready(function()
{
    $("#btn2").click(function()
    {
        $(".tabcontent2").show();
        $(".tabcontent").hide(); 
        $(".tabcontent3").hide();


    });
})

$(document).ready(function()
{
    $("#btn3").click(function()
    {
        $(".tabcontent2").hide();
        $(".tabcontent").hide(); 
        $(".tabcontent3").show();


    });
})

$(document).ready(function()
{
  $("#getbtn").fadeIn(function()
  {
    $("#getbutton").hide();
    $("#gettext1").hide();
    $("#gettext2").hide();

  });
});


$(document).ready(function()
{
  $("#getbtn").click(function()
  {
    $("#getbutton").show();
    $("#gettext1").show();
    $("#gettext2").show();

  });
});

$(document).ready(function()
{
  $("#postbtn").fadeIn(function()
  {
    $("#posttext1").hide();
  });
});

$(document).ready(function()
{
  $("#postbtn").click(function()
  {
    $("#posttext1").show();
  });
});


$(document).ready(function()
{
  $("#postfrmbtn").fadeIn(function()
  {
    $("#postfrmtext1").hide();
    $("#postfrmtext2").hide();
    $("#postfrmbutton").hide();
  });
});

$(document).ready(function()
{
  $("#postfrmbtn").click(function()
  {
    $("#postfrmtext1").show();
    $("#postfrmtext2").show();
    $("#postfrmbutton").show();
  });
});

$(document).ready(function()
{
  $("#putbtn").fadeIn(function()
  {
    $("#puttext1").hide();
  });
});

$(document).ready(function()
{
  $("#putbtn").click(function()
  {
    $("#puttext1").show();
  });
});

$(document).ready(function()
{
  $("#patchbtn").fadeIn(function()
  {
    $("#patchtext1").hide();
  });
});

$(document).ready(function()
{
  $("#patchbtn").click(function()
  {
    $("#patchtext1").show();
  });
});

$(document).ready(function()
{
  $("#delbtn").fadeIn(function()
  {
    $("#deltext1").hide();
  });
});

$(document).ready(function()
{
  $("#delbtn").click(function()
  {
    $("#deltext1").show();
  });
});


  $(document).ready(function()
{
  $("#getbtn").fadeIn(function()
  {
    $("#getbutton").hide();
    $("#gettext1").hide();
    $("#gettext2").hide();
    $("#getbutton2").hide();


  });
});

$(document).ready(function()
{
  $("#postfrmbtn").fadeIn(function()
  {
    $("#postfrmbutton").hide();
    $("#postfrmbutton2").hide();
    $("#postfrmtext1").hide();
    $("#postfrmtext2").hide();


  });
});


$(document).ready(function()
{
  $("#getbtn").click(function()
  {
    $("#getbutton").show();
    $("#gettext1").hide();
    $("#gettext2").hide();
    $("#getbutton2").hide();
   $("#posttext1").hide();
   $("#postbutton").hide();
   $("#postfrmbutton") .hide();
   $("#postfrmbutton2").hide();
   $("#postfrmtext1") .hide();
   $("#postfrmtext2").hide();
   $("#puttext1").hide();
   $("#putbutton").hide();
   $("#patchtext1").hide();
   $("#patchbutton").hide();
   $("#delbutton") .hide();
   $("#deltext1").hide();

  });
});

$(document).ready(function()
{
  $("#getbutton").click(function()
  {
    $("#gettext1").show();
    $("#gettext2").show();
    $("#getbutton2").show();
  });
});



$(document).ready(function()
{
  $("#postfrmbtn").click(function()
  {
    $("#postfrmbutton").show();
    $("#postfrmtext1").hide();
    $("#postfrmtext2").hide();
    $("#postfrmbutton2").hide();
    $("#getbutton").hide();
    $("#gettext1").hide();
    $("#gettext2").hide();
    $("#getbutton2").hide();
    $("#posttext1") .hide();
    $("#puttext1") .hide();
    $("#patchtext1") .hide();
    $("#deltext1").hide();
    $("#postbutton").hide();
    $("#putbutton").hide();
    $("#patchbutton").hide();
    $("#delbutton").hide();
  });
});

$(document).ready(function()
{
  $("#postfrmbutton").click(function()
  {
    $("#postfrmtext1").show();
    $("#postfrmtext2").show();
    $("#postfrmbutton2").show();
  });
});


$(document).ready(function()
{
  $("#postbtn").click(function()
  {
    $("#getbutton").hide();
    $("#gettext1").hide();
    $("#gettext2").hide();
    $("#getbutton2").hide();
   $("#postbutton") .show();
   $("#posttext1") .show();
   $("#postfrmbutton") .hide();
   $("#postfrmbutton2") .hide();
   $("#postfrmtext1") .hide();
   $("#postfrmtext2").hide();
   $("#putbutton").hide();
   $("#puttext1").hide();
   $("#patchtext1").hide();
   $("#patchbutton").hide();
   $("#deltext1").hide();
   $("#delbutton").hide();
  });
});



$(document).ready(function()
{
  $("#putbtn").click(function()
  {
    $("#getbutton").hide();
    $("#gettext1").hide();
    $("#gettext2").hide();
    $("#getbutton2").hide();
   $("#postbutton") .hide();
   $("#posttext1") .hide();
   $("#postfrmbutton") .hide();
   $("#postfrmbutton2") .hide();
   $("#postfrmtext1") .hide();
   $("#postfrmtext2").hide();
   $("#putbutton").show();
   $("#puttext1").show();
   $("#patchtext1").hide();
   $("#patchbutton").hide();
   $("#deltext1").hide();
   $("#delbutton").hide();
  });
});



$(document).ready(function()
{
  $("#patchbtn").click(function()
  {
    $("#getbutton").hide();
    $("#gettext1").hide();
    $("#gettext2").hide();
    $("#getbutton2").hide();
   $("#postbutton") .hide();
   $("#posttext1") .hide();
   $("#postfrmbutton") .hide();
   $("#postfrmbutton2") .hide();
   $("#postfrmtext1") .hide();
   $("#postfrmtext2").hide();
   $("#putbutton").hide();
   $("#puttext1").hide();
   $("#patchtext1").show();
   $("#patchbutton").show();
   $("#deltext1").hide();
   $("#delbutton").hide();
  });
});

$(document).ready(function()
{
  $("#delbtn").click(function()
  {
    $("#getbutton").hide();
    $("#gettext1").hide();
    $("#gettext2").hide();
    $("#getbutton2").hide();
   $("#postbutton") .hide();
   $("#posttext1") .hide();
   $("#postfrmbutton") .hide();
   $("#postfrmbutton2") .hide();
   $("#postfrmtext1") .hide();
   $("#postfrmtext2").hide();
   $("#putbutton").hide();
   $("#puttext1").hide();
   $("#patchtext1").hide();
   $("#patchbutton").hide();
   $("#deltext1").show();
   $("#delbutton").show();
  });
});



