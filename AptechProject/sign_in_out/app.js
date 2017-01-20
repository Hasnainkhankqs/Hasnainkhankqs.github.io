// JavaScript Document
var nam = document.getElementsByTagName("input")[0];
var fname = document.getElementsByTagName("input")[1];
var contact = document.getElementsByTagName("input")[2];
var psword = document.getElementsByTagName("input")[3];
var mail = document.getElementsByTagName("input")[4];
var sign = document.getElementById("signupbtn");
// localStorage.setItem("email",mail);
// localStorage.setItem("password",psword);
sign.addEventListener("click",function(){
 var nm =  nam.value;
 var fn =  fname.value;
 var cntct =  contact.value;
 var pswrd =  psword.value;
 var mal =  mail.value;
 if(nm.length > 1 && fn.length > 1 && cntct.length > 1 && pswrd.length > 1 && mal.length > 1){
    localStorage.setItem("email",mal);
    localStorage.setItem("pswrd",psword);
    window.location = "page3.html";
 }
})



// var attemp = 3;
// function login(){
// var email = document.getElementById("inemail").value;
// var pswrd = document.getElementById("inpswrd").value;
// if(email === "hasnainkhan@gmail.com" && pswrd === "aptech"){
// alert("Long in successfully!");
// window.location = "page3.html";
// return false;
// }
// else{
// attemp--;
// alert("You have left Attempt"+ attemp);
// if(attemp == 0){
// document.getElementById("inemail").disabled =true;
// document.getElementById("inpswrd").disabled = true;
// document.getElementById("signinbtn").disabled = true;
// return false;
// }
// }
// }