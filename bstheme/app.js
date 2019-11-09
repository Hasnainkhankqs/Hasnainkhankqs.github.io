(function($) {
    "use strict"; // Start of use strict

    // jQuery for page scrolling feature - requires jQuery Easing plugin
    $(document).on('click', 'a.page-scroll', function(event) {
        var $anchor = $(this);
        $('html, body').stop().animate({
            scrollTop: ($($anchor.attr('href')).offset().top - 50)
        }, 1250, 'easeInOutExpo');
        event.preventDefault();
    });

    // Highlight the top nav as scrolling occurs
    $('body').scrollspy({
        target: '.navbar-fixed-top',
        offset: 100
    });

    // Closes the Responsive Menu on Menu Item Click
    $('.navbar-collapse ul li a').click(function() {
        $('.navbar-toggle:visible').click();
    });

    // Offset for Main Navigation
    $('#mainNav').affix({
        offset: {
            top: 50
        }
    })

})(jQuery); // End of use strict
$(window).scroll(function(){
if($(this).scrollTop() > "300"){
    $(".navbar-fixed-top").css({"background-color":"rgba(223, 100, 223, 0.45)","transition":"0.5s"});
    $(".navbar-fixed-top a").css({"color":"white"});
    // $(".navbar-fixed-top").css({"box-shadow":"8px 8px 12px rgba(0,0,0,0.5)"});

}
else{
    $(".navbar-fixed-top").css({"background-color":"transparent","transition":"0.5s"});
     $(".navbar-fixed-top a").css({"color":"#fff"})
    //  $(".navbar-fixed-top").css({"box-shadow":"none"});
}
})