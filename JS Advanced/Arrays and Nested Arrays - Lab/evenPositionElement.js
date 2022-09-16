'use strict'

function evenPosition(args) {
    let element = [];
    
    for (let i = 0; i < args.length; i++) {
         if(i % 2 === 0) {
            element[element.length] = args[i];
        }
    }

    console.log(element.join(' '));
}

evenPosition(['20', '30', '40', '50', '60']);
console.log('-------------')
evenPosition(['5', '10'])