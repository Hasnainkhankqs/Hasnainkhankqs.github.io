var count = 1;
var img = document.getElementById("carusol");
var dot = document.getElementById("dots");
var dots = dot.getElementsByTagName("span");
var figure = document.getElementsByTagName("figure");
var imgp = document.getElementById("products").getElementsByTagName("img");
var hidetxt = document.getElementById("hidetxt");
// hidetxt.style.color = "white";   
var inputfield = document.getElementById("inputfield");
// setInterval(move,1000);  //setInterval is not working after for loop
for(var b = 0 ; b < imgp.length ; b++){
    imgp[b].addEventListener("mouseenter",enterr)
}
for(var a = 0 ; a < imgp.length ; a++){
    imgp[a].addEventListener("mouseleave",leavee)
}
function enterr(){
this.parentNode.style.backgroundColor = "red";
}
function leavee(){
 this.parentNode.style.backgroundColor = "green";
}
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
}

inputfield.addEventListener("focus",focs);
inputfield.addEventListener("blur",blr);
function focs(){
    hidetxt.style.display = "none";
    hidetxt.style.transition = "0.1s all"
}
function blr(){
    hidetxt.style.color = "white";
    hidetxt.style.display = "block";
}

