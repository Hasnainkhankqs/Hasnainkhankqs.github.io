var button = document.getElementsByTagName("input")[0];
var signincontainer = document.getElementById("signincontainer");
var signupcontainer = document.getElementById("signupcontainer");
button.addEventListener("click",function(){
    signupcontainer.style.top = "80px";
    signincontainer.style.top = "-480px";
    body.opacity = "0.4s";

})

// signup validation
var signup = document.getElementById("signup");
var fname = document.getElementById("fname");
var contact = document.getElementById("cntct");
var password = document.getElementById("pswrd");
var errormsg = document.getElementById("errormsg");
function checkname(){
    var nameVal = document.getElementById("name").value;
    if(isNaN(nameVal) || nameVal == ""  ){
        errormsg.style.display = "block";
        errormsg.style.padding = "8px";
        errormsg.innerHTML += "Please write correct name";
    }
    else{
       errormsg.style.display = "none";
    }
 
}


signup.addEventListener("click",checkname);