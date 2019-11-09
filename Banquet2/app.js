// toggle navigation

// var openmenu = document.getElementsByClassName("openmenu");
// var showit = document.getElementsByClassName("showit");
// for(var a = 0 ; a < openmenu.length ; a++){
//     openmenu[a].addEventListener("mouseenter",function(){
//         this.nextElementSibling.className += " showmenu";
//     })
//         showit[a].addEventListener("mouseenter",function(){
//         this.className += " showmenu";
//     })
//         openmenu[a].addEventListener("mouseleave",function(){
//         this.nextElementSibling.classList.remove("showmenu");
//     })
//         showit[a].addEventListener("mouseleave",function(){
//         this.classList.remove("showmenu");
//     })
// }
var row2col2 = document.getElementsByClassName("row2col2")[0];
row2col2.style.display = "block";
// row2col2.style.height = "150px";
// row2col2.style.overflow = "hidden";
var togglebtn = document.getElementById("togglebtn");
togglebtn.addEventListener("click",function(){
    if(row2col2.style.display === "block" &&  window.innerWidth < 763){
        row2col2.style.display = "none";
    }
    else {
        row2col2.style.display = "block";
    }
})
if(window.innerWidth >= 763){
        // row2col2.style.display = "block";
        row2col2.style.backgroundColor = "red";
    }
// slider animation start
// var img = document.getElementById("slider").style;
// var count = 1;
// function slidering(){
//     count++;
//     if(count > 4){
//         count = 1;
//     }
//     img.backgroundImage = "url(img/slider"+count+".jpg"+")";
//     if(count === 1){
//         document.getElementById("changeabletxt").innerHTML = "<span>We Create</span><br/> You<br/> Celebrate"
//     }
//         if(count === 2){
//         document.getElementById("changeabletxt").innerHTML = "<span>We Make</span><br/> You<br/> Special"
//     }
//         if(count === 3){
//         document.getElementById("changeabletxt").innerHTML = "<span>We Relize</span><br/> You <br/> Comfortable"
//     }
//         if(count === 4){
//         document.getElementById("changeabletxt").innerHTML = "<span>We Wish</span><br/> You<br/> Best"
//     }

//     console.log("image changed");
// }
// setInterval("slidering()",10000);

// map start
// function initMap() {
//         var uluru = {lat: -2.363, lng: 11.044};
//         var map = new google.maps.Map(document.getElementById('map'), {
//           zoom: 4,
//           center: uluru
//         });
//         var marker = new google.maps.Marker({
//           position: uluru,
//           map: map
//         });
//       }


// var last = document.getElementById("last").addEventListener("click",function(){
//     alert(window.innerWidth)
// })

// var last = document.getElementById("last");
// var para = document.getElementById("para");
// last.addEventListener("click",function(){
//     alert(para.style.valueOf.color);
// })