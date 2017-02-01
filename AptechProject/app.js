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


// map start
    var mapCanvas = document.getElementById("map");
    function myMap() {
    var mapOptions = {
        center: new google.maps.LatLng(24.9018300,67.0405020),
        zoom: 10
    };
    var map = new google.maps.Map(mapCanvas, mapOptions);
}