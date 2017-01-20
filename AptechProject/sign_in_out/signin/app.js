var signin = document.getElementById("signinbtn");
var email = document.getElementsByTagName("input")[0];
var pasword = document.getElementsByTagName("input")[1];
signin.addEventListener("click",function(){
    email = email.value;
    pasword = pasword.value;
    if(email.value == localStorage.getItem("email") && pasword.value == localStorage.getItem("pswrd")){
      window.location =  "..index.html"; 
    }
})