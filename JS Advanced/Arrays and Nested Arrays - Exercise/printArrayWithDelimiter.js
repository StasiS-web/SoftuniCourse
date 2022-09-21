'use strict'

function printArrayWithDelimiter(array, delimiter) {
    console.log(array.join(`${delimiter}`));
}

printArrayWithDelimiter(
    ['One',
    'Two',
    'Three',
    'Four',
    'Five'],
    '-')
console.log('-------------')
printArrayWithDelimiter(
    ['How about no?', 
    'I', 
    'will', 
    'not', 
    'do', 
    'it!'], 
    '_')