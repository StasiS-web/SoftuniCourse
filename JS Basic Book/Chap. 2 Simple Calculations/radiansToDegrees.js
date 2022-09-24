'use strict'

function radiansToDegrees(rad) {
    let deg = Math.round(rad * 180 / Math.PI);
    console.log(deg);
}

radiansToDegrees(3.1416);
console.log('-------------')
radiansToDegrees(6.2832)