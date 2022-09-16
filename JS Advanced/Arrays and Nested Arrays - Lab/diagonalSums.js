'use strict'

function diagonalSums(matrix) {
    let sumPrimary = 0;
    let sumSecondary = 0;

    for (let i = 0; i < matrix.length; i++) {
        sumPrimary += matrix[i][i];
        sumSecondary += matrix[i][matrix.length - i - 1];
    }
        
    console.log(sumPrimary, sumSecondary);
}

diagonalSums([
    [20, 40], 
    [10, 60]
]);
console.log('-------------')
diagonalSums([
    [3, 5, 17], 
    [-1, 7, 14], 
    [1, -8, 89]
]);
