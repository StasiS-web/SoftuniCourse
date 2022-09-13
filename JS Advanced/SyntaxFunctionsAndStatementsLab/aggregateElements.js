'use strict'
/*
    Sum(ai) - calculates the sum of all elements from the input array
    Sum(1/ai) - calculates the sum of the inverse values (1/ai) of all elements from the array
    Concat(ai) - concatenates the string representations of all elements from the array
*/
function operations(array) {
    let sum = 0;
    let inverseSum = 0;
    let concat = '';

    for(let i = 0; i < array.length; i++) {
        sum += array[i];
        inverseSum += 1 / array[i];
        concat += array[i];
    }

    console.log(sum);
    console.log(inverseSum);
    console.log(concat);
}

operations([1, 2, 3]);
console.log('-------------')
operations([2, 4, 8, 16]);
