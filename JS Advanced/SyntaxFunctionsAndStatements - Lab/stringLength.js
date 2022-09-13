'use strict'

function result(first, second, third) {
    let firstString = first.length;
    let secondString = second.length;
    let thirdString = third.length;

    let sum = firstString + secondString + thirdString;

    console.log(sum);
    console.log(Math.floor(sum / arguments.length))
}

result('chocolate', 'ice cream', 'cake');
console.log('-------------')
result('pasta', '5', '22.3')