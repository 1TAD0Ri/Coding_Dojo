var button = document.querySelector("#likee0");
var spano = document.querySelector("#spano0");
var count = 0;

function addlike() {
    count++;
    spano.textContent = count;
}

button.addEventListener('click', button);
// ------------------------------

var button1 = document.querySelector("#likee1");
var spano1 = document.querySelector("#spano1");
var count1 = 0;

function addlike1() {
    count1++;
    spano1.textContent = count1;
}

button1.addEventListener('click', button1);
// ____________________________________________________


var button2 = document.querySelector("#likee2");
var spano2 = document.querySelector("#spano2");
var count2 = 0;

function countlike() {
    count2++;
    spano2.textContent = count2;
}

button2.addEventListener('click', button2);











// var button = document.querySelector("#likee");
// var count= 0;
// var spano = document.querySelector("#spano");


// function countlike(){
//     count++;
//     spano.textContent = count;
// }

// button.addEventListener('click',button)