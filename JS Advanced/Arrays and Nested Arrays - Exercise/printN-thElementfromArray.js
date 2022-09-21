'use strict'

function printNElementArray(array, number) {
    let result = [];

    for(let i = 0; i < array.length; i += number) {
        result.push(array[i]);
    }

    return result;
}

printNElementArray(
    ['5', 
    '20', 
    '31', 
    '4', 
    '20'], 2);
console.log('-------------')
printNElementArray(
    ['dsa', 
    'asd', 
    'test', 
    'tset'], 2);
console.log('-------------')
printNElementArray(
    ['1', 
    '2', 
    '3', 
    '4', 
    '5'], 6);