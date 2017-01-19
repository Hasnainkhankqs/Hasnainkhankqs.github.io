var count = 1;
var img = document.getElementById("carusol");
var dot = document.getElementById("dots");
var dots = dot.getElementsByTagName("span");

function point(l){
 img.src = "img/img"+l+".jpg";

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
    img.src = "img/img"+count+".jpg";
document.getElementById("counting").innerHTML = count;
}
setInterval(move,2000);



