// var input = document.getElementsByTagName("input")[0];
// var button = document.getElementsByTagName("input")[1];
// var ul = document.getElementsByTagName("ul")[0];
// button.addEventListener("click",function(){
//     var li = document.createElement("li");
//     var txt = input.value;
//     var txtcreated = document.createTextNode(txt);
//     li.appendChild(txtcreated);
//     console.log(ul.appendChild(li));
// })

var txt = document.getElementById("txt");
var input = document.getElementsByTagName("input")[0];
var button = document.getElementsByTagName("input")[1];
var ul = document.getElementsByTagName("ul")[0];
var div = document.getElementsByTagName("div")[0];
var allinputs = div.getElementsByTagName("input");
var span = document.getElementsByTagName("span")[0];
button.addEventListener("click",function(){
    var inputVal = parseInt(input.value);
        var addtxtbtn = document.createElement("button");
        var AddText = document.createTextNode("Create Now");
        addtxtbtn.appendChild(AddText);
        span.appendChild(addtxtbtn);
    for(var i = 0 ; i < inputVal ; i++){
        var inputt = document.createElement("input"); //creatin input fields as per demand
        var att = document.createAttribute("type"); // adding type attribute
        att.value = "text";  //adding type attribute
        inputt.setAttributeNode(att);  //apending type attribute
        div.appendChild(inputt);     //wrapping all inputs into a div
    }
})
var list = document.getElementsByTagName("ul")[0].getElementsByTagName("li");
span.addEventListener("click",function(){
    for(var j = 0 ; j < allinputs.length ; j++){
        var ancor = document.createElement("a"); // creating ancor tag
        var ancoratt = document.createAttribute("href"); //setting href attribute
        var li = document.createElement("li"); //creating li elements
        ul.appendChild(li);    // apending li into ul 
        li.appendChild(ancor); //apending a into li
        ancoratt.value = "#"; //setting href attribute
        ancor.setAttributeNode(ancoratt); //apending  href attribute
        var createtxt =document.createTextNode(allinputs[j].value);
        list[j].getElementsByTagName("a")[0].appendChild(createtxt);
    }
        txt.style.marginLeft = "40%";
})


// text
