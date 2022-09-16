'use strict'

function negativePositiveNum(array) { 
    let newArr = [];

    for(let i = 0; i < array.length; i++) {
        if(array[i] < 0) {
            newArr.unshift(array[i]);
        }
        else {
            newArr.push(array[i]);
        }
    }

    console.log(newArr.join('\n'));
}

negativePositiveNum(['7', '-2', '8', '9']);
console.log('-------------')
negativePositiveNum(['3', '-2', '0', '-1']);