'use strict'

function solve(number) {
    let result;

    if(number === 'Monday') {
        result = 1;
    }
    else if (number === 'Tuesday') {
        result = 2;
    }
    else if (number === 'Wednesday') {
        result = 3;
    }
    else if (number === 'Thursday') {
        result = 4;
    }
    else if(number === 'Friday') {
        result = 5;
    }
    else if (number === 'Saturday') {
        result = 6;
    }
    else if(number === 'Sunday') {
        result = 7;
    }
    else {
        result = 'error'
    }

    console.log(result);
}

solve('Monday')
console.log('-------------')
solve('Friday')
console.log('-------------')
solve('Invalid')