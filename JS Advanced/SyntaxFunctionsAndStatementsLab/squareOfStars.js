'use strict'

function rectangleFromStars(size = 5){
    for(let i = 0; i < size; i++) {
        let result = '* '.repeat(size).trimEnd();
        console.log(result);
    }
}

rectangleFromStars(1);
console.log('-------------')
rectangleFromStars(2);
console.log('-------------')
rectangleFromStars(5);
console.log('-------------')
rectangleFromStars(7);
console.log('-------------')
rectangleFromStars();