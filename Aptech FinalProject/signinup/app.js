var button = document.getElementsByTagName("input")[0];
var signincontainer = document.getElementById("signincontainer");
var signupcontainer = document.getElementById("signupcontainer");
var welcome = document.getElementById("welcome");
button.addEventListener("click",function(){
    signupcontainer.style.top = "60px";
    signincontainer.style.top = "-480px";
    welcome.style.left = "50%";

})

// signup validation
function validate(){
    var nameVal = document.getElementById("name").value;
    var passValue = document.getElementById("password").value;  
    var emailVal = document.getElementById("email").value;
    var contact = document.getElementById("contact").value;
    // var radio = document.getElementsByName("gender");
    var attherat = emailVal.indexOf("@");
    var emailLastchr = emailVal.lastIndexOf(".");
    // (function(){
    //      for(var a = 0 ; a<radio.length; a++){
    //     if(radio[a].checked){
    //         alert("every thing is okay");
    //         return true;
    //     }
    //     else{
    //         alert("radio select");
    //         return false;
    //     }
    // }
    // }());
    for(var i = 0 ; i< emailVal.length ; i++){
        switch(emailVal.slice(i,i+1)){
        case "~":
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Don't Use ~ ";
        break;
        case "`":
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Don't Use `";
        break;
        case "!":
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Don't Use !";
        break;
        case "#":
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Don't Use #";
        break;
        case "$":
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Don't Use $";
        break;
        case "%":
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Don't Use %";
        break;
        case "^":
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Don't Use ^";
        break;
        case "&":
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Don't Use &";
        break;
        case "*":
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Don't Use *";
        break;
        case "(":
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Don't Use (";
        break;
        case ")":
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Don't Use )";
        break;
        case "+":
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Don't Use +";
        break;
        case "=":
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Don't Use =";
        break;
        case "/":
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Don't Use /";
        break;     
        }
    }
        
    // Name Validation
    if(!isNaN(nameVal) || nameVal == ""){
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning:  Write your name properly";
         return false;
    }
  
    else if(nameVal.length < 5 || nameVal.length > 15){
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Name should be within 5 to 15 characters ";
         return false;
    }
    // // Email validation
    else if(!isNaN(emailVal) || emailVal == ""){
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: please write your correct email";
         return false;
    }
    else if(attherat == -1){
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: please write @";
         return false;
    }
    else if(emailLastchr == -1){
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: please write . ";
         return false;
    }
    else if(emailLastchr < attherat){
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: please write @ befor .";
         return false;
    }
    else if(isNaN(contact) || contact == ""){
        errormsg.style.display = "block";
        errormsg.innerHTML = "Warning: Please write your number properly";
        return false;
    }
    else if(contact.length !== 11){
        errormsg.style.display = "block";
        errormsg.innerHTML = "Please write your correct number i.e 03121234567";
        return false;
    }

        else if(passValue.length < 8){
            errormsg.style.display = "block";
            errormsg.innerHTML = "Warning: there should be more than 8 characters in Password";
            return false;
        }
    else{
        var nameVal = document.getElementById("name").value;
    var passValue = document.getElementById("password").value;  
    var emailVal = document.getElementById("email").value;
    var contact = document.getElementById("contact").value;
        localStorage.setItem("UserName",nameVal);
        localStorage.setItem("Password",passValue);
        localStorage.setItem("Email",emailVal);
        localStorage.setItem("Contact",contact);
        errormsg.style.display = "none"
            return true;
    }
}
// for login
var loginform = document.getElementById("loginform");
var loginerror = document.getElementById("errormsg2");

function login(){
    var loginnameVal = document.getElementById("loginname").value;
    var loginpassVal = document.getElementById("loginpass").value;
    if(loginnameVal === localStorage.getItem("UserName") && loginpassVal ===localStorage.getItem("Password")){
        return true;
    }
    else if(loginnameVal == "" ||loginpassVal == ""  ){
         loginerror.style.display = "block";
        loginerror.innerHTML = "You can not login with empty field";
        return false;
    }
    else {
        loginerror.style.display = "block";
        loginerror.innerHTML = "Please write the userName and password same as you enterd in sign up";
        return false;
    }
}
