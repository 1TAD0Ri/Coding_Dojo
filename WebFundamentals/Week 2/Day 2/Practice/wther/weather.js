function accept(elemnt){
    var ele=document.querySelector(".down-navbar");
    ele.remove();
}


function affiche(){
    alert("Loading the report of ....");
}


function convert(){
    var slect = document.querySelector('#myselect')
    if(slect.value == "°C") {
        slect.value = "°F";
    }
    else if(slect.value=="°F"){
        slect.value="°C";
    }
}