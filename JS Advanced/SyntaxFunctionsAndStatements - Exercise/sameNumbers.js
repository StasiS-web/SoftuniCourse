'use strict'

function sameNumber(num) {
    let numAsString = num.toString();
    let firstChar = numAsString[0];
    let sameNum = true
    let sum = Number(firstChar);

    for(let i = 1; i < numAsString.length; i++) {
        let currentChar = numAsString[i];
        sum += Number(currentChar);

        if (firstChar !== currentChar) {
         sameNum = false;
        }
    }

    console.log(sameNum);
    console.log(sum);
}

sameNumber(2222222);
console.log('-------------')
sameNumber(1234);

