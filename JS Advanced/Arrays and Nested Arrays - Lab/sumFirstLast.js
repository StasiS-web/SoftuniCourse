'use strict'

function sumFirstLast(array) {
    let first = array[0];
    let last = array[array.length - 1];
    
    return Number(first) + Number(last);
}

sumFirstLast(['20', '30', '40']);
console.log('-------------')
sumFirstLast(['5', '10']);