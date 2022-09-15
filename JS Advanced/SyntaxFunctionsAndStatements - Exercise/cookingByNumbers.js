'use strict'

// chop - divide the number by two
// dice - square root of a number
// spice - add 1 to the number
// bake - multiply number by 3
// fillet - subtract 20% from the number

function cookingByNumbers(input, ...params) {

    for(let i = 0; i < params.length; i++) {
        input = operation(input, params[i]);
    }

    function operation(num, cmd) {
        switch(cmd) {
            case 'chop': 
                num /= 2; 
                console.log(num);
                break;
            case 'dice': 
                num = Math.sqrt(num);
                console.log(num); 
                break;
            case 'spice': 
                num+=1;
                console.log(num);
                break;
            case 'bake': 
                num *= 3; 
                console.log(num);
                break;
            case 'fillet': 
                num *= 0.80; 
                console.log(num);
                break;
        }
       return num;
    }
}

cookingByNumbers('32', 'chop', 'chop', 'chop', 'chop', 'chop');
console.log('-------------')
cookingByNumbers('9', 'dice', 'spice', 'chop', 'bake', 'fillet');