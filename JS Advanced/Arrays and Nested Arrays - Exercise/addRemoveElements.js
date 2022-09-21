'use strict'

function addRemoveElements (array) {
    let number = 0;
    let arrNum = [];

    for(let i = 0; i < array.length; i++) {
        number++;

        if(array[i] === 'add') {
            arrNum.push(number);
        }
        else if(array[i] === 'remove') {
            arrNum.pop();
        }
    }

    if(arrNum.length > 0) {
        console.log(arrNum.join('\n'));
    }
    else{
        console.log('Empty');
    }

}

addRemoveElements(['add', 
                    'add', 
                    'add', 
                    'add']);
console.log('-------------')
addRemoveElements(['add', 
                    'add', 
                    'remove', 
                    'add', 
                    'add']);
console.log('-------------')
addRemoveElements(['remove', 
                    'remove', 
                    'remove']);
