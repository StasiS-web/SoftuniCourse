'use strict'

function increasingSubsequenceFromArray (array) {
    let result = [];
    let currentBiggest = array[0];
 
   for (let i = 0; i < array.length; i++) {
        let currNum = array[i];
 
        if (currNum >= currentBiggest) {
            result.push(currNum);
            currentBiggest = currNum;
        }
    }
 
    return result;
}

console.log(increasingSubsequenceFromArray(['1',
                                 '3',
                                 '8',
                                 '4',
                                 '10',
                                 '12',
                                 '3',
                                 '2',
                                 '24']));
console.log('-------------');
console.log(increasingSubsequenceFromArray(['1', 
                                 '2', 
                                 '3', 
                                 '4']));
console.log('-------------')
console.log(increasingSubsequenceFromArray(['20', 
                                 '3', 
                                 '2', 
                                 '15', 
                                 '6', 
                                 '1'])); 
                            