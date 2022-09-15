'use strict'

function greatestDivisor(a, b) {
    if(b) {
        greatestDivisor(b, a % b);
    }
    else {
        console.log(a);
    }
}

greatestDivisor(15, 5);
console.log('-------------')
greatestDivisor(2154, 458);