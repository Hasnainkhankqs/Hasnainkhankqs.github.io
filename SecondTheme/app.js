// http://pegodesign.com/wp-themes/stephens/
// text animation start
var h1 = document.getElementsByTagName("header")[0].getElementsByTagName("h1")[0].innerHTML;    
function removefirst(){
var breakedword = h1.split("");
var lastword = breakedword.shift();
var firstword = breakedword.push(lastword);
 h1 = breakedword.join("");
breakedword = [];
document.getElementsByTagName("header")[0].getElementsByTagName("h1")[0].innerHTML = h1;

} 
setInterval("removefirst()",200);

// text animation completed 
// hide and display protfolioimg start
var centralnav = document.getElementById("centralnav");
var ancor = centralnav.getElementsByTagName("a");
var protfolioimg = document.getElementById("protfolioimg");
var imgs = protfolioimg.getElementsByTagName("img");
ancor[0].addEventListener("click",function(){
    for(var h = 0 ; h < imgs.length ; h++){
        imgs[h].style.display = "block";
    }
})
ancor[1].addEventListener("click",function(){
     for(var h = 0 ; h < imgs.length ; h++){
         if(h === 0 || h === 5){
        imgs[h].style.display = "none";
         }
         else{
        imgs[h].style.display = "block";
         }
    }

})
ancor[2].addEventListener("click",function(){
     for(var h = 0 ; h < imgs.length ; h++){
         if(h === 0 || h === 1 || h === 2){
        imgs[h].style.display = "none";
         }
         else{
        imgs[h].style.display = "block";
         }
    }

})
ancor[3].addEventListener("click",function(){
     for(var h = 0 ; h < imgs.length ; h++){
         if(h === 0 || h === 1 || h === 2 || h === 3 || h === 4){
        imgs[h].style.display = "none";
         }
         else{
        imgs[h].style.display = "block";
         }
    }

})
// hide and display protfolioimg ended
// header start
var header = document.getElementsByTagName("header")[0];
var count = 7;
function slider(){
    count++;
    if(count == 10){
        count = 7;
    }
header.style.backgroundImage = "url(img/img"+count+".jpg)";
}
setInterval("slider()",2000);

// header ended
// sticky navigation start
    jQuery(document).ready(function(){
        var navofset  = jQuery("ul").offset().top;
        console.log(navofset);
        var $window = $(window);
        $window.scroll(function(){
            var scrol = $(this).scrollTop();
            console.log(scrol);
            if(scrol >= navofset){
                jQuery("ul").addClass("fixed");
            }
            else{
                jQuery("ul").removeClass("fixed");
            }
        })
    })
// sticky navigation ended

// jqery started all elements will comeup with animations

var $element = $(".allimg");
var $window = $(window);
function animateimg(){
    var $windowheight = $window.height();
    var $toptillscroll = $window.scrollTop();
    var $windowbottom = ($windowheight+$toptillscroll);
    $.each($element,function(){
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
$window.on('scroll resize', animateimg);

// ended animation
// animation on blog
var $blog = $("#blogheading");
function blogbig(){
var windowsscroll = $(window).scrollTop();
console.log(windowsscroll);
if(windowsscroll >= 2687 && windowsscroll <= 2947 ){
    $blog.addClass("blogheadingbig");
}
else{
    $blog.removeClass("blogheadingbig");
}
}
$window.on('scroll resize', blogbig);