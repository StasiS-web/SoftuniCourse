'use strict'

function previousDay(year, month, day) {
    let inputDate = new Date(year, month - 1, day);
    inputDate.setDate(inputDate.getDate() - 1);
    
    console.log(`${inputDate.getFullYear()}-${inputDate.getMonth() + 1}-${inputDate.getDate()}`);
}

previousDay(2016, 9, 30);
console.log('-------------')
previousDay(2016, 10, 1);