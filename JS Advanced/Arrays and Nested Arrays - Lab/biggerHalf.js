'use strict'

function biggerHalf(array) { 
    let sortedArr =  array.sort((a, b) => a - b);
    let arr = Math.floor(sortedArr.length/2);
    let result = sortedArr.slice(arr);
    return result;
}

console.log(biggerHalf(['4', '7', '2', '5']));
console.log('-------------')
console.log(biggerHalf(['3', '19', '14', '7', '2', '19', '6']));