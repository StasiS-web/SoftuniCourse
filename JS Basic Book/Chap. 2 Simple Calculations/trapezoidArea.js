'use strict'

function trapezoidArea([arg1, arg2, arg3]) {
    let a = parseFloat(arg1);
    let b = parseFloat(arg2);
    let h = parseFloat(arg3);
    let area = (a + b) * h / 2;

    console.log(`Trapezoid area =  ${area}`);
}

trapezoidArea([3, 4, 5]);