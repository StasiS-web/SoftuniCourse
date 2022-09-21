'use strict'

function magicMatrices(matrix) {
    let result = [];
    matrix.forEach(item => {
        result.push(item.reduce((a,b) => a + b, 0));
    });

    for (let i = 0; i < matrix.length; i++) {
         let sum = 0;
    
        for (let j = 0; j < matrix.length; j++) {
            sum += matrix[i][j];
        }

        result.push(sum);
    }

    return new Set(result).size === 1 ? true : false;
}

console.log(magicMatrices([[4, 5, 6],
               [6, 5, 4],
               [5, 5, 5]]));
console.log('-------------')
console.log(magicMatrices([[11, 32, 45], 
               [21, 0, 1], 
               [21, 1, 1]]));
console.log('-------------')
console.log(magicMatrices([[1, 0, 0], 
               [0, 0, 1], 
               [0, 1, 0]]));