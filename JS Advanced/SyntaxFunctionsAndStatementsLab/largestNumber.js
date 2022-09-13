'use strict'

function largestNum(x, y, z) {
    const arrayNums = new Array(x, y, z);
    let result = Math.max(...arrayNums);
 
    console.log(`The largest number is ${result}.`);
}

largestNum(5, -3, 16)
console.log('-------------')
largestNum(-3, -5, -22.5)