'use strict'

function sortArrayBy2Criteria(array) {
    array.sort((a, b) => a.length - b.length || a.localeCompare(b));
    
    for(let text of array) {
        console.log(text);
    }
}

console.log(sortArrayBy2Criteria(['alpha',
                                  'beta', 
                                  'gamma']));
console.log('-------------')
console.log(sortArrayBy2Criteria(['Isacc', 
                                  'Theodor', 
                                  'Jack', 
                                  'Harrison', 
                                  'George']));
console.log('-------------')
console.log(sortArrayBy2Criteria(['test', 
                                  'Deny', 
                                  'omen', 
                                  'Default']));