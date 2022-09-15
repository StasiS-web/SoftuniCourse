'use strict'

function solve(input) {
    let inputType = typeof(input);
    let area;

    if(inputType === 'number') {
    
        area = (Math.pow(input, 2) * Math.PI).toFixed(2);
    }
    else {
        area = `We can not calculate the circle area, because we receive a ${inputType}.`
    }

    console.log(area)
}

solve(5);
console.log('-------------')
solve('name');