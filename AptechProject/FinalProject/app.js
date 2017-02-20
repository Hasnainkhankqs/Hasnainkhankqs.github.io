var count = 1;
var img = document.getElementById("carusol");
var dot = document.getElementById("dots");
var dots = dot.getElementsByTagName("span");
function point(l) {
    img.src = "img/slider/img" + l + ".jpg";
}
function move(n) {
    if (n) {
        count = count + n;
    }
    else {
        count++;
    }
    if (count > 4) {
        count = 1;
    }
    else if (count < 1) {
        count = 4;
    }
    img.src = "img/slider/img" + count + ".jpg";
}

setInterval(move, 3000);
//slider completed

// map start
//    var mapCanvas = document.getElementById("map");
//    function myMap() {
//    var mapOptions = {
//        center: new google.maps.LatLng(24.9018300,67.0405020),
//        zoom: 10
//    };
//    var map = new google.maps.Map(mapCanvas, mapOptions);
//}
// navpane list start
var switchbtn = document.getElementsByClassName("switchbtn");
var list = document.getElementsByClassName("list");

for (var i = 0; i < switchbtn.length; i++) {
    switchbtn[i].addEventListener("click", function () {
        this.classList.toggle("active");
        this.nextElementSibling.classList.toggle("show");
    })
}
// navpan
var navpaneopener = document.getElementById("navpaneopener");
var navpane = document.getElementById("navpane");
// shatter
var closebtn = document.getElementsByClassName("closebtn");
var panal = document.getElementById("panal");

for (var j = 0; j < closebtn.length; j++) {
    closebtn[j].addEventListener("click", function () {
        navpane.style.width = "0px";
        panal.style.height = "0px";
    })
}
navpaneopener.addEventListener("click", function () {
    navpane.style.width = "300px";
})


var shatterheading = document.getElementById("shatterheading");

window.addEventListener("load", function () {
    document.getElementById("panal").style.height = "100%";
    shatterheading.style.top = "50px";
    shatterheading.style.transform = "rotate(360deg)";
})
// image open in products
var clicking = document.getElementsByClassName("clicking");
var model = document.getElementsByClassName("model");
var modelspan = document.getElementsByClassName("modelspan");
for (var b = 0; b < clicking.length; b++) {
    clicking[b].addEventListener("click", function () {
        this.nextElementSibling.style.display = "block";
    })
}


for (var d = 0; d < modelspan.length; d++) {
    modelspan[d].addEventListener("click", function () {
        for (var c = 0; c < model.length; c++) {
            model[c].style.display = "none"
        }
    })
}

// changing model image 
var modelleftnavigator = document.getElementsByClassName("modelleftnavigator");
var modelrightnavigator = document.getElementsByClassName("modelrightnavigator");
var modelContent = document.getElementsByClassName("model-content");
for (var g = 0; g < model - content.length; g++) {
    var div = modelContent[g].getElementsByTagName("div");
}

for (var f = 0; f < modelleftnavigator.length; f++) {
    modelleftnavigator[f].addEventListener("click", function () {
        modelimage.src = "img/panasonic/panasonic10.jpg"
    })

}
// form validation
function validate(){
    var nameVal = document.getElementById("name").value;
    // var passValue = document.getElementById("password").value;  
    var emailVal = document.getElementById("email").value;
    var contact = document.getElementById("contact").value;
    var textarea = document.getElementById("textarea").value;
    var attherat = emailVal.indexOf("@");
    var emailLastchr = emailVal.lastIndexOf(".");

    for(var i = 0 ; i< emailVal.length ; i++){
        switch(emailVal.slice(i,i+1)){
        case "~":
        alert("dont use ~ in email");
        break;
        case "`":
        alert("dont use ` in email");
        break;
        case "!":
        alert("dont use ! in email");
        break;
        case "#":
        alert("dont use # in email");
        break;
        case "$":
        alert("dont use $ in email");
        break;
        case "%":
        alert("dont use % in email");
        break;
        case "^":
        alert("dont use ^ in email");
        break;
        case "&":
        alert("dont use & in email");
        break;
        case "*":
        alert("dont use * in email");
        break;
        case "(":
        alert("dont use ( in email");
        break;
        case ")":
        alert("dont use ) in email");
        break;
        case "+":
        alert("dont use + in email");
        break;
        case "=":
        alert("dont use = in email");
        break;
        case "/":
        alert("dont use / in email");
        break;
        case "*":
        alert("dont use * in email");
        break;        
        }
    }
    // Name Validation
    if(!isNaN(nameVal) || nameVal == ""){
        alert("please write your correct name");
         return false;
    }
  
    else if(nameVal.length < 5 || nameVal.length > 15){
        alert("name should be within 5 to 15 characters");
         return false;
    }
    // // Email validation
    else if(!isNaN(emailVal) || emailVal == " "){
        alert("please write your correct email");
         return false;
    }
    else if(attherat == -1){
        alert("please write @");
         return false;
    }
    else if(emailLastchr == -1){
        alert("please write . ");
         return false;
    }
    else if(emailLastchr < attherat){
        alert("please write @ befor .");
         return false;
    }
    else if(isNaN(contact) || contact == ""){
        alert("Please write your number");
        return false;
    }
    else if(textarea.length > 550){
        alert("the message should be within 50 to 550 characters");
        return false;
    }
        else if(textarea == ""){
        alert("the message should be within 50 to 550 characters");
        return false;
    }
        // else if(passValue.length < 8){
        //     alert("there should be more than 8 characters in Password");
        //     return false;
        // }
    else{
            return true;
    }
}
