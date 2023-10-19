/* ------------------ group activity -----------

    write a for-loop that starts at year 1996 and ends in 2023
    on every year (iteration) have it log the year and the string "JS is awesome!"
    on every 10 years, log "happy decade of JS!"
    when you reach the end, log "HAPPY 27 years of JAVASCRIPT! 🎈🎈🎈"

    ex. "1996 JS is awesome"
        "1997 JS is awesome"
        ...
        "2004 JS is awesome"
        "2005 JS is awesome"
        "happy decade of JS!"
        "2007 JS is awesome"
        ....
        "2022 JS is awesome"
        "HAPPY 27 years of JAVASCRIPT! 🎈🎈🎈"

 */

        // var year = 0 
        // var startYear = 1996

        // for(year = 1996; year<= 2023; year++){
        //     if(year==2023){
        //         console.log("HAPPY 27 years of JAVASCRIPT! 🎈🎈🎈")
        //     }else{
        //         if((year-startYear)%10==0 && year!=1996 ){
        //             console.log(year + "happy decade of JS!" )

        //         }else{
        //             console.log(year + "JS is awesome")
        //         }
        //     }
        // }

        // function hello() {
        //     console.log('hello');
        // }
        // hello();
        // console.log('Dojo');
        
        // function hello() {
        //     console.log('hello');
        //     return 15;
        // }
        // var result = hello();
        // console.log('result is', result);
        
        // function numPlus(num) {
        //     console.log('num is', num);
        //     return num+15;
        // }
        // var result = numPlus(3);
        // console.log('result is', result);
        
//         var num = 15;
// console.log(num);
// function logAndReturn(num){
//    console.log(num);   
//    return num;
// }
// var result = logAndReturn(10);
// console.log(result);
// console.log(num);


// var num = 15;
// console.log(num);
// function timesTwo(num){
//    console.log(num);   
//    return num*2;
// }
// var result = timesTwo(10);
// console.log(result);
// console.log(num);


// function timesTwoAgain(num) {
//     console.log('num is', num);
//     var y = num*2;
//     return y;
// }
// var result = timesTwoAgain(3) + timesTwoAgain(5);
// console.log('result is', result);


// function sumNums(num1, num2) {  
//     return num1+num2;
//  }
//  console.log(sumNums(2,3))
//  console.log(sumNums(3,5))

// function printSumNums(num1, num2) {
//     console.log(num1);   
//     return num1+num2;
//  }
//  console.log(printSumNums(2,3))
//  console.log(printSumNums(3,5))
 

// function sumNums(num1, num2) {
//     var sum = num1 + num2;
//     console.log('sum is', sum);
//     return sum;
// }
// var result = sumNums(2,3) + sumNums(3,5);
// console.log('result is', result);


function sumNums(num1, num2) {
    var sum = num1 + num2;
    console.log('sum is', sum);
    return sum;
}
var result = sumNums(2,3) + sumNums(3,sumNums(2,1)) + sumNums(sumNums(2,1),sumNums(2,3));
console.log('result is', result);
