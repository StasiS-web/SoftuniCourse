'use strict'

function rotateArray (array, rotationCount) {
    for(let i = 0; i < rotationCount; i++) {
        array.unshift(array.pop());
    }

   return array.join(' ');
}

console.log(rotateArray(['1',
             '2',
             '3',
             '4'], 
              2));
console.log('-------------')
console.log(rotateArray(['Banana',
              'Orange',
              'Coconut',
              'Apple'], 
              15));