// JavaScript Document
var attemp = 3;
function login(){
var email = document.getElementById("inemail").value;
var pswrd = document.getElementById("inpswrd").value;
if(email === "hasnainkhan@gmail.com" && pswrd === "aptech"){
alert("Long in successfully!");
window.location = "page3.html";
return false;
}
else{
attemp--;
alert("You have left Attempt"+ attemp);
if(attemp == 0){
document.getElementById("inemail").disabled =true;
document.getElementById("inpswrd").disabled = true;
document.getElementById("signinbtn").disabled = true;
return false;
}
}
}