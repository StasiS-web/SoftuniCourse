'use strict'

function sortingNumbers(array) {
    let smallest = array.sort((a, b) => a -b);
    let result = [];

    while (smallest.length) {
        result.push(smallest.shift());
        result.push(smallest.pop());
    }

    return result;
}


console.log(sortingNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));