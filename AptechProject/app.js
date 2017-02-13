var count = 1;
var img = document.getElementById("carusol");
var dot = document.getElementById("dots");
var dots = dot.getElementsByTagName("span");
function point(l){
 img.src = "img/slider/img"+l+".jpg";
}
function move(n){
    if(n){
        count = count + n;
    }
    else{
        count++;
    }
    if(count > 4 ){
      count = 1;
    }
    else if(count < 1){
     count = 4;
    }
    img.src = "img/slider/img"+count+".jpg";
}

setInterval(move,3000); 
//slider completed

// map start
    var mapCanvas = document.getElementById("map");
    function myMap() {
    var mapOptions = {
        center: new google.maps.LatLng(24.9018300,67.0405020),
        zoom: 10
    };
    var map = new google.maps.Map(mapCanvas, mapOptions);
}
// navpane list start
var switchbtn = document.getElementsByClassName("switchbtn");
var list = document.getElementsByClassName("list");

for(var i = 0; i<switchbtn.length;i++){
    switchbtn[i].addEventListener("click",function(){
        this.classList.toggle("active");
     this.nextElementSibling.classList.toggle("show");
    })
}
// navpan
var navpaneopener = document.getElementById("navpaneopener");
var navpane = document.getElementById("navpane");
// shatter
var closebtn = document.getElementsByClassName("closebtn");
var panal =document.getElementById("panal");

for(var j = 0; j<closebtn.length ;j++){
    closebtn[j].addEventListener("click",function(){
        navpane.style.width = "0px";
        panal.style.height = "0px";
        })
}
navpaneopener.addEventListener("click",function(){
        navpane.style.width= "300px";
})



window.addEventListener("load",function(){
    document.getElementById("panal").style.height = "100%";
})
// image open in products


var clicking = document.getElementsByClassName("clicking");
var model = document.getElementsByClassName("model");
var modelspan = document.getElementsByClassName("modelspan");
for(var b= 0; b < clicking.length ;b++){
    clicking[b].addEventListener("click",function(){
        this.nextElementSibling.style.display = "block";
    })
}


for(var d = 0; d < modelspan.length; d++){
    modelspan[d].addEventListener("click",function(){
        for(var c = 0; c< model.length;c++){
            model[c].style.display = "none"
        }
    })
}

// changing model image 
var modelleftnavigator = document.getElementsByClassName("modelleftnavigator");
var modelrightnavigator = document.getElementsByClassName("modelrightnavigator");
var modelContent  = document.getElementsByClassName("model-content");
for(var g = 0; g<model-content.length; g++){
    var div = modelContent[g].getElementsByTagName("div");
}

for(var f = 0 ; f<modelleftnavigator.length ; f++ ){
    modelleftnavigator[f].addEventListener("click",function(){
        modelimage.src = "img/panasonic/panasonic10.jpg"
    })
    
}
