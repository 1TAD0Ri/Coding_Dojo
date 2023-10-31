var button = document.querySelector("#likee");
var count= 0;
var spano = document.querySelector("#spano");


function countlike(){
    count++;
    spano.textContent = count;
}

button.addEventListener('click',button)