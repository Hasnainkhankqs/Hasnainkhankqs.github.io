
$(window).scroll(function(){
if($(this).scrollTop() > "300"){
    $(".navbar-fixed-top").css({"background-color":"rgba(227, 174, 87, 0.45)","transition":"0.5s"});
    $(".navbar-fixed-top a").css({"color":"white"});
    // $(".navbar-fixed-top").css({"box-shadow":"8px 8px 12px rgba(0,0,0,0.5)"});

}
else{
    $(".navbar-fixed-top").css({"background-color":"transparent","transition":"0.5s"});
     $(".navbar-fixed-top a").css({"color":"#777"})
    //  $(".navbar-fixed-top").css({"box-shadow":"none"});
}
})
// animation on text
var $txt = $(".animatetxt");
var $window = $(window);
function animatetext(){
    var $windowheight = $window.height();
    var $toptillscroll = $window.scrollTop();
    var $windowbottom = ($windowheight+$toptillscroll);
    $.each($txt,function(){
        var $thisimg = $(this);
        var $elementheightbp = $thisimg.outerHeight();
        var $toptillscrollelement = $thisimg.offset().top;
        var $elementbottom = ($elementheightbp+$toptillscrollelement);
        if(($elementbottom >= $toptillscroll)&&($toptillscrollelement <= $windowbottom)){
           $thisimg.addClass(" effect");
        }
        else{
            $thisimg.removeClass("effect");
        }
    })
}
$window.on('scroll resize', animatetext);

